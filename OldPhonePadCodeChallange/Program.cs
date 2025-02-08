using System;
using System.Linq;
using System.Text;

namespace OldPhonePadCodeChallange
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "337**2#";
            string result = OldPhonePad(input);
            Console.WriteLine(result);
        }

        public static string OldPhonePad(string input)
        {
            StringBuilder outputBuilder = new StringBuilder();
            string keys = "";
            char prevChar = '\0';

            foreach (char c in input)
            {
                if (c == '*')
                {
                    HandleBackspace(ref outputBuilder, ref keys, ref prevChar);
                    continue;
                }

                if (ShouldProcessKey(keys, c))
                {
                    ProcessKey(ref outputBuilder, keys);
                    keys = "";
                }

                keys += c;
                prevChar = UpdatePrevChar(outputBuilder);
            }

            return outputBuilder.ToString();
        }

        private static void HandleBackspace(ref StringBuilder outputBuilder, ref string keys, ref char prevChar)
        {
            if (string.IsNullOrEmpty(keys) && outputBuilder.Length > 0)
            {
                outputBuilder.Remove(outputBuilder.Length - 1, 1);
                prevChar = UpdatePrevChar(outputBuilder);
                return;
            }

            char keyToCompare = keys.Length > 1 ? keys[keys.Length - 1] : prevChar;
            if (keys[0] == keyToCompare)
            {
                keys = "";
            }else
            {
                keys = keys.Substring(0, keys.Length - 1);
            }
        }

        private static bool ShouldProcessKey(string keys, char currentChar)
        {
            return !string.IsNullOrEmpty(keys) && keys[keys.Length - 1] != currentChar;
        }

        private static void ProcessKey(ref StringBuilder outputBuilder, string keys)
        {
            var keyConfig = KeyConfigItem.GetKeyConfig().FirstOrDefault(k => k.Key == keys[0]);
            if (keyConfig != null)
            {
                var values = keyConfig.Values;
                if (keys.Length <= values.Length)
                {
                    outputBuilder.Append(values[keys.Length - 1]);
                }
                if (keys.Length > values.Length)
                {
                    int index = (keys.Length - 1) % values.Length;
                    outputBuilder.Append(values[index]);
                }
            }
        }


        private static char UpdatePrevChar(StringBuilder outputBuilder)
        {
            if (outputBuilder.Length == 0)
                return '\0';

            char lastValue = outputBuilder[outputBuilder.Length - 1];
            return KeyConfigItem.GetKeyByValue(lastValue);
        }
    }
}
