using System;

namespace Lesson7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleString = "It is sample string to encoding and decoding";

            var aCoder = new ACoder();

            var encodeByACoder = aCoder.Encoder(sampleString);
            var decoderByACoder = aCoder.Decoder(encodeByACoder);

            Console.WriteLine($"After encoding and decoding string is equals = {sampleString == decoderByACoder}");

            var bCoder = new BCoder();

            var encodeByBCoder = bCoder.Encoder(sampleString);
            var decoderByBCoder = bCoder.Decoder(encodeByBCoder);

            Console.WriteLine($"After encoding and decoding string is equals = {sampleString == decoderByBCoder}");

            Console.ReadLine();
        }
    }
}
