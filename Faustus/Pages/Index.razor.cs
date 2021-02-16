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
        private string _stackSize { get; set; } = "1";
        private string _cost { get; set; } = "1";
        private string _currency { get; set; } = "chaos";
        private string _priceNote { get; set; }

        private BFUDropdown _currenciesDropdown { get; set; }
        private BFUDropdown _shardsDropdown { get; set; }
        private BFUDropdown _delveDropdown { get; set; }
        private BFUDropdown _scarabsDropdown { get; set; }
        private BFUDropdown _oilsDropdown { get; set; }
        private BFUDropdown _deliriumDropdown { get; set; }

        private List<IBFUDropdownOption> _currencies
        { get; set; }

        private List<IBFUDropdownOption> _shards { get; set; }
        private List<IBFUDropdownOption> _delveItems { get; set; }
        private List<IBFUDropdownOption> _scarabs { get; set; }
        private List<IBFUDropdownOption> _oils { get; set; }
        private List<IBFUDropdownOption> _delirium { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UpdatePriceNote();
            _currencies = CurrencyDropdowns.Currencies;
            _shards = CurrencyDropdowns.Shards;
            _delveItems = CurrencyDropdowns.DelveItems;
            _scarabs = CurrencyDropdowns.Scarabs;
            _oils = CurrencyDropdowns.OilsCatalysts;
            _delirium = CurrencyDropdowns.Delirium;
        }

        public void UpdatePriceNote()
        {
            _priceNote = $"~price {_cost}/{_stackSize} {_currency}";
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

            _currenciesDropdown.SelectedOption = null;
            _shardsDropdown.SelectedOption = null;
            _delveDropdown.SelectedOption = null;
            _scarabsDropdown.SelectedOption = null;
            _oilsDropdown.SelectedOption = null;
            _deliriumDropdown.SelectedOption = null;
        }

        private async Task CopyTextToClipboard()
        {
            await JSRuntime.InvokeVoidAsync("navigator.clipboard.writeText", _priceNote);
        }
    }
}