using System;

namespace Lesson7._1
{
    class BCoder:ICoder
    {
        public string Encoder(string val)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                return null;
            }

            var charArr = val.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
                //foreach (var symbol in charArr)
            {
                var numSymbol = (int)charArr[i];

                if (numSymbol is >= 97 and <= 122)
                {
                    charArr[i] = (char)(122 - (numSymbol - 97));
                }
                else
                {
                    charArr[i] = (char)(90 - (numSymbol - 65));
                }
            }

            return new string(charArr);
        }

        public string Decoder(string val)
        {
            return string.IsNullOrWhiteSpace(val) ? "" : Encoder(val);
        }
    }
}
