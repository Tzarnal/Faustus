using BlazorFluentUI;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Faustus.Data
{
    public static class CurrencyDropdowns
    {
        public static List<IBFUDropdownOption> DelveItems;
        public static List<IBFUDropdownOption> Scarabs;
        public static List<IBFUDropdownOption> OilsCatalysts;

        static CurrencyDropdowns()
        {
            DelveItemsBuilder();
            ScarabItemsBuilder();
            OilsCatalystsBuilder();
        }

        private static void DelveItemsBuilder()
        {
            DelveItems = new List<IBFUDropdownOption>
            {
                new BFUDropdownOption { Text = "Resonators", Key = "Resonators",  ItemType = SelectableOptionMenuItemType.Header },

                new BFUDropdownOption { Text = "Primitive Alchemical Resonator", Key = "primitive-alchemical-resonator",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Potent Alchemical Resonator", Key = "potent-alchemical-resonator",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Powerful Alchemical Resonator", Key = "powerful-alchemical-resonator",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Prime Alchemical Resonator", Key = "prime-alchemical-resonator",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Primitive Chaotic Resonator", Key = "primitive-chaotic-resonator",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Potent Chaotic Resonator", Key = "potent-chaotic-resonator",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Powerful Chaotic Resonator", Key = "powerful-chaotic-resonator",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Prime Chaotic Resonator", Key = "prime-chaotic-resonator",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Fossils", Key = "Fossils",  ItemType = SelectableOptionMenuItemType.Header },

                new BFUDropdownOption { Text = "Scorched Fossil",       Key = "scorched-fossil",        ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Frigid Fossil",         Key = "frigid-fossil",          ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Metallic Fossil",       Key = "metallic-fossil",        ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Jagged Fossil",         Key = "jagged-fossil",          ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Aberrant Fossil",       Key = "aberrant-fossil",        ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Pristine Fossil",       Key = "pristine-fossil",        ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Dense Fossil",          Key = "dense-fossil",           ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Corroded Fossil",       Key = "corroded-fossil",        ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Prismatic Fossil",      Key = "prismatic-fossil",       ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Aetheric Fossil",       Key = "aetheric-fossil",        ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Serrated Fossil",       Key = "serrated-fossil",        ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Lucent Fossil",         Key = "lucent-fossil",          ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Shuddering Fossil",     Key = "shuddering-fossil",      ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Bound Fossil",          Key = "bound-fossil",           ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Perfect Fossil",        Key = "perfect-fossil",         ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Enchanted Fossil",      Key = "enchanted-fossil",       ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Encrusted Fossil",      Key = "encrusted-fossil",       ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Faceted Fossil",        Key = "faceted-fossil",         ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Bloodstained Fossil",   Key = "bloodstained-fossil",    ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Hollow Fossil",         Key = "hollow-fossil",          ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Fractured Fossil",      Key = "fractured-fossil",       ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Glyphic Fossil",        Key = "glyphic-fossil",         ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Tangled Fossil",        Key = "tangled-fossil",         ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Sanctified Fossil",     Key = "sanctified-fossil",      ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Fossil",         Key = "gilded-fossil",          ItemType = SelectableOptionMenuItemType.Normal },
            };
        }

        private static void ScarabItemsBuilder()
        {
            Scarabs = new List<IBFUDropdownOption>
            {
                new BFUDropdownOption { Text = " Rusted Breach Scarab",Key = "rusted-breach-scarab",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Polished Breach Scarab",Key = "polished-breach-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Breach Scarab",Key = "gilded-breach-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Breach Scarab",Key = "jewelled-breach-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Cartography Scarab",Key = "rusted-cartography-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Cartography Scarab",Key = "polished-cartography-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Cartography Scarab",Key = "gilded-cartography-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Cartography Scarab",Key = "jewelled-cartography-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Reliquary Scarab",Key = "rusted-reliquary-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Reliquary Scarab",Key = "polished-reliquary-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Reliquary Scarab",Key = "gilded-reliquary-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Reliquary Scarab",Key = "jewelled-reliquary-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Bestiary Scarab",Key = "rusted-bestiary-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Bestiary Scarab",Key = "polished-bestiary-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Bestiary Scarab",Key = "gilded-bestiary-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Bestiary Scarab",Key = "jewelled-bestiary-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Farric Lure",Key = "farric-lure",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Saqawine Lure",Key = "saqawine-lure",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Fenumal Lure",Key = "fenumal-lure",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Craicic Lure",Key = "craicic-lure",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Shaper Scarab",Key = "rusted-shaper-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Shaper Scarab",Key = "polished-shaper-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Shaper Scarab",Key = "gilded-shaper-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Shaper Scarab",Key = "jewelled-shaper-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Elder Scarab",Key = "rusted-elder-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Elder Scarab",Key = "polished-elder-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Elder Scarab",Key = "gilded-elder-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Elder Scarab",Key = "jewelled-elder-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Sulphite Scarab",Key = "rusted-sulphite-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Sulphite Scarab",Key = "polished-sulphite-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Sulphite Scarab",Key = "gilded-sulphite-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Sulphite Scarab",Key = "jewelled-sulphite-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Divination Scarab",Key = "rusted-divination-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Divination Scarab",Key = "polished-divination-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Divination Scarab",Key = "gilded-divination-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Divination Scarab",Key = "jewelled-divination-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Torment Scarab",Key = "rusted-torment-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Torment Scarab",Key = "polished-torment-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Torment Scarab",Key = "gilded-torment-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Torment Scarab",Key = "jewelled-torment-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Ambush Scarab",Key = "rusted-ambush-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Ambush Scarab",Key = "polished-ambush-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Ambush Scarab",Key = "gilded-ambush-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Ambush Scarab",Key = "jewelled-ambush-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Harbinger Scarab",Key = "rusted-harbinger-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Harbinger Scarab",Key = "polished-harbinger-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Harbinger Scarab",Key = "gilded-harbinger-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Harbinger Scarab",Key = "jewelled-harbinger-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Perandus Scarab",Key = "rusted-perandus-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Perandus Scarab",Key = "polished-perandus-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Perandus Scarab",Key = "gilded-perandus-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Perandus Scarab",Key = "jewelled-perandus-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Legion Scarab",Key = "rusted-legion-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Legion Scarab",Key = "polished-legion-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Legion Scarab",Key = "gilded-legion-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Legion Scarab",Key = "jewelled-legion-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rusted Metamorph Scarab",Key = "rusted-metamorph-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Polished Metamorph Scarab",Key = "polished-metamorph-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gilded Metamorph Scarab",Key = "gilded-metamorph-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Winged Metamorph Scarab ",Key = "jewelled-metamorph-scarab",  ItemType = SelectableOptionMenuItemType.Normal },
            };
        }

        private static void OilsCatalystsBuilder()
        {
            OilsCatalysts = new List<IBFUDropdownOption>
            {
                new BFUDropdownOption { Text = "Oils", Key = "Oils", ItemType = SelectableOptionMenuItemType.Header },

                new BFUDropdownOption { Text = "Clear Oil", Key = "clear-oil",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Sepia Oil", Key = "sepia-oil",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Amber Oil", Key = "amber-oil",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Verdant Oil", Key = "verdant-oil",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Teal Oil", Key = "teal-oil",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Azure Oil", Key = "azure-oil",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Violet Oil", Key = "violet-oil",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Crimson Oil", Key = "crimson-oil",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Black Oil", Key = "black-oil",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Opalescent Oil", Key = "opalescent-oil",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Silver Oil", Key = "silver-oil",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Golden Oil", Key = "golden-oil",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Catalysts", Key = "Catalysts", ItemType = SelectableOptionMenuItemType.Header },

                new BFUDropdownOption { Text = "Turbulent Catalyst",Key = "turbulent-catalyst",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Imbued Catalyst",Key = "imbued-catalyst",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Abrasive Catalyst",Key = "abrasive-catalyst",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Tempering Catalyst",Key = "tempering-catalyst",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Fertile Catalyst",Key = "fertile-catalyst",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Prismatic Catalyst",Key = "prismatic-catalyst",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Intrinsic Catalyst ",Key = "intrinsic-catalyst",  ItemType = SelectableOptionMenuItemType.Normal },
            };
        }
    }
}