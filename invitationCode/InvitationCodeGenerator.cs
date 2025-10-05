namespace invitationCode
{
    public static class InvitationCodeGenerator
    {
        private static readonly string[] Seasons =
        {
            "Spring", "Summer", "Autumn", "Winter"
        };
        private static readonly string[] CommonNames =
        {
            "John", "Mary", "David", "Sarah", "Michael", "Lisa", "James", "Emma", "Robert", "Anna",
            "William", "Olivia", "Thomas", "Sophia", "Christopher", "Mia", "Daniel", "Isabella", "Matthew", "Charlotte",
            "Joseph", "Amelia", "Andrew", "Harper", "Joshua", "Evelyn", "Ryan", "Abigail", "Nicholas", "Emily"
        };
        private static readonly string[] ExploringStaff =
        {
            "Compass", "Map", "Lantern", "Rope", "Tent", "Boots", "Binoculars", "Knife", "Axe", "Shield",
            "Torch", "Backpack", "Whistle", "Canteen", "Saddle", "Cloak", "Hat", "Gloves", "Sextant", "Spyglass",
            "Crystal", "Scroll", "Amulet", "Ring", "Medallion", "Crown", "Gem", "LanternStone", "Key", "ScrollCase",
            "Totem", "Staff", "Horn", "Banner", "CompassRose", "Flask", "Pouch", "Spear", "Dagger", "Quiver"
        };

        private static readonly string[] GemExplorationActions =
        {
            "Discovering", "Exploring", "Hunting", "Mining", "Uncovering", "Seeking", "Finding", "Searching",
            "Excavating", "Digging", "Collecting", "Tracking", "Surveying", "Venturing", "Adventuring",
            "Prospecting", "Scouting", "Mapping", "TrackingDown", "Trekking", "Climbing", "Diving", "Navigating",
            "Charting", "Inspecting", "Investigating", "Observing", "Scavenging", "Recovering", "RecoveringGem",
            "Unearthing", "Extracting", "Examining", "Panning", "Sifting", "TrackingTreasure", "SurveyingCaves"
        };

        private static readonly string[] TreasureChestContents =
        {
            "GoldCoin", "SilverCoin", "Ruby", "Sapphire", "Emerald", "Diamond", "Pearl", "Crown", "Tiara",
            "Amulet", "Ring", "Necklace", "Bracelet", "Chalice", "Goblet", "TreasureMap", "Scroll", "Gemstone",
            "Medallion", "Orb", "Key", "Chest", "Potion", "Crystal", "Pendant", "CoinPouch", "Scepter",
            "Relic", "CoinBag", "GoldenCrown", "SilverRing", "MagicLamp", "EnchantedScroll", "TreasureChest",
            "RubyBracelet", "EmeraldRing", "JeweledDagger", "MysticOrb", "AncientCoin", "GoldenGoblet"
        };

        private static readonly string[] FortunateVibes =
        {
            "Lucky", "Blessed", "Fortunate", "Charmed", "Serendipitous", "Auspicious", "Golden", "Prosperous",
            "Joyful", "Radiant", "Fateful", "Destined", "Hopeful", "Bright", "Thriving", "Victorious", "Triumphant",
            "Blissful", "Fortuitous", "Cheerful"
        };

        private static readonly Random Random = new Random();
        private static readonly HashSet<string> GeneratedCodes = new HashSet<string>();

        public static string GenerateFriendlyCode(bool includeNumberPrefix = false, (int Min, int Max)? numberRange = null)
        {
            numberRange ??= (10, 99);

            string treasureChestContents = PickRandom(TreasureChestContents);
            string season = PickRandom(Seasons);
            string commonNames = PickRandom(CommonNames);
            string exploringStaff = PickRandom(ExploringStaff);
            string gemExplorationActions = PickRandom(GemExplorationActions);
            string fortunateVibes = PickRandom(FortunateVibes);

            string prefix = includeNumberPrefix
                ? Random.Next(numberRange.Value.Min, numberRange.Value.Max + 1).ToString()
                : string.Empty;

            string code;

            do
            {
                code = $"{prefix}-{season}-{commonNames}-{fortunateVibes}-{gemExplorationActions}-{exploringStaff}-{treasureChestContents}";
            }
            while (!GeneratedCodes.Add(code));

            return code;
        }

        private static string PickRandom(string[] source)
        {
            return source[Random.Next(source.Length)];
        }
    }
}
