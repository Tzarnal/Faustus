using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Faustus.Pages
{
    public partial class Index : ComponentBase
    {
        public string _stackSize { get; set; } = "1";
        public string _cost { get; set; } = "1";
        public string _currency { get; set; } = "c";

        public string _priceNote { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UpdatePriceNote();
        }

        public void UpdatePriceNote()
        {
            _priceNote = $"~b/o {_cost}/{_stackSize} {_currency}";
        }

        public async Task CopyPriceNote()
        {
            UpdatePriceNote();
            await CopyTextToClipboard();
        }

        public void UpdateCurrency(string currency)
        {
            _currency = currency;
            UpdatePriceNote();
        }

        private async Task CopyTextToClipboard()
        {
            await JSRuntime.InvokeVoidAsync("navigator.clipboard.writeText", _priceNote);
        }
    }
}