using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string doubletrouble = String.Empty;
            for (int i = 0; i < original.Length; i++)
            {
                doubletrouble += original[i];
                doubletrouble += original[i];
            }

            return doubletrouble;

        }
    }
}
