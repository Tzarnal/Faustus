using BlazorFluentUI;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;
using Faustus.Data;

namespace Faustus.Pages
{
    public partial class Index : ComponentBase
    {
        public string _stackSize { get; set; } = "1";
        public string _cost { get; set; } = "1";
        public string _currency { get; set; } = "chaos";
        public string _priceNote { get; set; }

        private List<IBFUDropdownOption> _delveItems { get; set; }
        private List<IBFUDropdownOption> _scarabs { get; set; }
        private List<IBFUDropdownOption> _oils { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UpdatePriceNote();
            _delveItems = CurrencyDropdowns.DelveItems;
            _scarabs = CurrencyDropdowns.Scarabs;
            _oils = CurrencyDropdowns.OilsCatalysts;
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

        private void DropdownChangeHandler(BFUDropdownChangeArgs args)
        {
            _currency = args.Option.Key;
            UpdatePriceNote();
        }

        private async Task CopyTextToClipboard()
        {
            await JSRuntime.InvokeVoidAsync("navigator.clipboard.writeText", _priceNote);
        }
    }
}