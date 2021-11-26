namespace Lesson7._1
{
    class ACoder: ICoder
    {
        public string Encoder(string val)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                return val;
            }

            var charArr = val.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
                //foreach (var symbol in charArr)
            {
                var numSymbol = (int)charArr[i];

                charArr[i] = numSymbol switch
                {
                    122 => (char)97,
                    90 => (char)65,
                    _ => (char)++numSymbol
                };
            }

            return new string(charArr);
        }

        public string Decoder(string val)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                return "";
            }

            var charArr = val.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
                //foreach (var symbol in charArr)
            {
                var numSymbol = (int)charArr[i];

                charArr[i] = numSymbol switch
                {
                    97 => (char)122,
                    65 => (char)90,
                    _ => (char)--numSymbol
                };
            }

            return new string(charArr);
        }
    }
}
