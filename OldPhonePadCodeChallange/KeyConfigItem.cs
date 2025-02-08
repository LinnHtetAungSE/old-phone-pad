namespace OldPhonePadCodeChallange
{
    public class KeyConfigItem
    {
        private static readonly KeyConfigItem[] KeyConfig = {
            new KeyConfigItem { Key = '1', Values = new[] { "&", "'", "(" } },
            new KeyConfigItem { Key = '2', Values = new[] { "A", "B", "C" } },
            new KeyConfigItem { Key = '3', Values = new[] { "D", "E", "F" } },
            new KeyConfigItem { Key = '4', Values = new[] { "G", "H", "I" } },
            new KeyConfigItem { Key = '5', Values = new[] { "J", "K", "L" } },
            new KeyConfigItem { Key = '6', Values = new[] { "M", "N", "O" } },
            new KeyConfigItem { Key = '7', Values = new[] { "P", "Q", "R", "S" } },
            new KeyConfigItem { Key = '8', Values = new[] { "T", "U", "V" } },
            new KeyConfigItem { Key = '9', Values = new[] { "W", "X", "Y", "Z" } },
            new KeyConfigItem { Key = '0', Values = new[] { " " } },
        };

        public char Key { get; set; }
        public string[] Values { get; set; }

        public static KeyConfigItem[] GetKeyConfig()
        {
            return KeyConfig;
        }

        public static char GetKeyByValue(char value)
        {
            foreach (var keyConfig in KeyConfig)
            {
                if (keyConfig.Values.Contains(value.ToString()))
                {
                    return keyConfig.Key;
                }
            }
            return '\0';
        }

    }
}
