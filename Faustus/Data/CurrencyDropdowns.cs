using BlazorFluentUI;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Faustus.Data
{
    public static class CurrencyDropdowns
    {
        public static List<IBFUDropdownOption> Currencies;
        public static List<IBFUDropdownOption> Shards;
        public static List<IBFUDropdownOption> DelveItems;
        public static List<IBFUDropdownOption> Scarabs;
        public static List<IBFUDropdownOption> OilsCatalysts;
        public static List<IBFUDropdownOption> Delirium;

        static CurrencyDropdowns()
        {
            DelveItemsBuilder();
            ScarabItemsBuilder();
            OilsCatalystsBuilder();
            DeliriumBuilder();
            CurrenciesBuilder();
            ShardsBuilder();
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

        private static void CurrenciesBuilder()
        {
            Currencies = new List<IBFUDropdownOption>
            {
                new BFUDropdownOption { Text = "Currencies", Key = "Currencies", ItemType = SelectableOptionMenuItemType.Header },

                new BFUDropdownOption { Text = "Orb of Alteration",Key = "alt",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Orb of Fusing",Key = "fusing",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Orb of Alchemy",Key = "alch",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Chaos Orb",Key = "chaos",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Gemcutter's Prism",Key = "gcp",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Exalted Orb",Key = "exalted",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Chromatic Orb",Key = "chrome",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Jeweller's Orb",Key = "jewellers",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Engineer's Orb",Key = "engineers",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Infused Engineer's Orb",Key = "infused-engineers-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Orb of Chance",Key = "chance",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Cartographer's Chisel",Key = "chisel",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Orb of Scouring",Key = "scour",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Blessed Orb",Key = "blessed",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Orb of Regret",Key = "regret",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Regal Orb",Key = "regal",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Divine Orb",Key = "divine",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Vaal Orb",Key = "vaal",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Orb of Annulment",Key = "annul",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Orb of Binding",Key = "orb-of-binding",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Ancient Orb",Key = "ancient-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Orb of Horizons",Key = "orb-of-horizons",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Harbinger's Orb",Key = "harbingers-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Scroll of Wisdom",Key = "wisdom",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Portal Scroll",Key = "portal",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Armourer's Scrap",Key = "scrap",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Blacksmith's Whetstone",Key = "whetstone",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Glassblower's Bauble",Key = "bauble",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Orb of Transmutation",Key = "transmute",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Orb of Augmentation",Key = "aug",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Mirror of Kalandra",Key = "mirror",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Eternal Orb",Key = "eternal",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Coins", Key = "Coins", ItemType = SelectableOptionMenuItemType.Header },
                new BFUDropdownOption { Text = "Perandus Coin",Key = "p",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Rogue's Marker",Key = "rogues-marker",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Silver Coin",Key = "silver",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Orbs", Key = "Orbs", ItemType = SelectableOptionMenuItemType.Header },
                new BFUDropdownOption { Text = "Crusader's Exalted Orb",Key = "crusaders-exalted-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Redeemer's Exalted Orb",Key = "redeemers-exalted-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Hunter's Exalted Orb",Key = "hunters-exalted-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Warlord's Exalted Orb",Key = "warlords-exalted-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Awakener's Orb",Key = "awakeners-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Maven's Orb",Key = "mavens-orb",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Heist", Key = "Heist", ItemType = SelectableOptionMenuItemType.Header },
                new BFUDropdownOption { Text = "Facetor's Lens",Key = "facetors",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Prime Regrading Lens",Key = "prime-regrading-lens",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Secondary Regrading Lens",Key = "secondary-regrading-lens",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Tempering Orb",Key = "tempering-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Tailoring Orb",Key = "tailoring-orb",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Sextant", Key = "Sextant", ItemType = SelectableOptionMenuItemType.Header },
                new BFUDropdownOption { Text = "Simple Sextant",Key = "apprentice-sextant",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Prime Sextant",Key = "journeyman-sextant",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Awakened Sextant",Key = "master-sextant",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Elevated Sextant",Key = "elevated-sextant",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Blessings", Key = "Blessings", ItemType = SelectableOptionMenuItemType.Header },
                new BFUDropdownOption { Text = "Blessing of Xoph",Key = "blessing-xoph",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Blessing of Tul",Key = "blessing-tul",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Blessing of Esh",Key = "blessing-esh",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Blessing of Uul-Netol",Key = "blessing-uul-netol",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Blessing of Chayula ",Key = "blessing-chayula",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Misc", Key = "Misc", ItemType = SelectableOptionMenuItemType.Header },
                new BFUDropdownOption { Text = "Stacked Deck",Key = "stacked-deck",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Ritual Vessel",Key = "ritual-vessel",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Orb of Unmaking",Key = "orb-of-unmaking",  ItemType = SelectableOptionMenuItemType.Normal },
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

        private static void ShardsBuilder()
        {
            Shards = new List<IBFUDropdownOption>
            {
                new BFUDropdownOption { Text = "Shards", Key = "Shards", ItemType = SelectableOptionMenuItemType.Header },
                new BFUDropdownOption { Text = "Annulment Shard",Key = "annulment-shard",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Mirror Shard",Key = "mirror-shard",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Exalted Shard",Key = "exalted-shard",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Binding Shard",Key = "binding-shard",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Horizon Shard",Key = "horizon-shard",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Harbinger's Shard",Key = "harbingers-shard",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Engineer's Shard",Key = "engineers-shard",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Ancient Shard",Key = "ancient-shard",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Chaos Shard",Key = "chaos-shard",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Regal Shard",Key = "regal-shard",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Splinter", Key = "Splinter", ItemType = SelectableOptionMenuItemType.Header },
                new BFUDropdownOption { Text = "Simulacrum Splinter",Key = "simulacrum-splinter",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Crescent Splinter",Key = "crescent-splinter",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Ritual Splinter",Key = "ritual-splinter",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Breach", Key = "Breach", ItemType = SelectableOptionMenuItemType.Header },
                new BFUDropdownOption { Text = "Splinter of Xoph",Key = "splinter-xoph",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Splinter of Tul",Key = "splinter-tul",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Splinter of Esh",Key = "splinter-esh",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Splinter of Uul-Netol",Key = "splinter-uul",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Splinter of Chayula",Key = "splinter-chayula",  ItemType = SelectableOptionMenuItemType.Normal },

                new BFUDropdownOption { Text = "Legion", Key = "Legion", ItemType = SelectableOptionMenuItemType.Header },
                new BFUDropdownOption { Text = "Timeless Karui Splinter",Key = "timeless-karui-splinter",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Timeless Maraketh Splinter",Key = "timeless-maraketh-splinter",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Timeless Eternal Empire Splinter",Key = "timeless-eternal-empire-splinter",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Timeless Templar Splinter",Key = "timeless-templar-splinter",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Timeless Vaal Splinter",Key = "timeless-vaal-splinter",  ItemType = SelectableOptionMenuItemType.Normal },
            };
        }

        private static void DeliriumBuilder()
        {
            Delirium = new List<IBFUDropdownOption>
            {
                new BFUDropdownOption { Text = "Fine Delirium Orb", Key = "fine-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Singular Delirium Orb", Key = "singular-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Thaumaturge's Delirium Orb", Key = "thaumaturge's-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Blacksmith's Delirium Orb", Key = "blacksmith's-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Armoursmith's Delirium Orb", Key = "armoursmith's-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Cartographer's Delirium Orb", Key = "cartographer's-delirium-orbb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Jeweller's Delirium Orb", Key = "jeweller's-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Abyssal Delirium Orb", Key = "abyssal-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Decadent Delirium Orb", Key = "decadent-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Foreboding Delirium Orb", Key = "foreboding-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Obscured Delirium Orb", Key = "obscured-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Whispering Delirium Orb", Key = "whispering-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Fragmented Delirium Orb", Key = "fragmented-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Skittering Delirium Orb", Key = "skittering-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Fossilised Delirium Orb", Key = "fossilised-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Portentous Delirium Orb", Key = "portentous-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Diviner's Delirium Orb", Key = "diviner's-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Delirium Orb", Key = "delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Primal Delirium Orb", Key = "primal-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Imperial Delirium Orb", Key = "imperial-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Timeless Delirium Orb", Key = "timeless-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Blighted Delirium Orb", Key = "blighted-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
                new BFUDropdownOption { Text = "Amorphous Delirium Orb", Key = "amorphous-delirium-orb",  ItemType = SelectableOptionMenuItemType.Normal },
            };
        }
    }
}