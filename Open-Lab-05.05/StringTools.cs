using System;

namespace Open_Lab_05._05
{
    public class StringTools
    {
        public string AlternatingCaps(string original)
        {
            char[] origchar = original.ToCharArray();
            int i = 1;
            int u = 0;
            char[] newchar = new char[origchar.Length];
            foreach(char c in origchar)
            {
                if (Char.IsWhiteSpace(c))
                {
                    newchar[u] = c;
                    u++;
                }
                else if ( i % 2 == 0) 
                {
                    newchar[u] = Char.ToLower(c);
                    u++;
                    i++;
                }
                else if ( i % 2 != 0)
                {
                    newchar[u] = Char.ToUpper(c);
                    u++;
                    i++;
                }
            }
            string result= new string(newchar);
            return result;
        }
    }
}
