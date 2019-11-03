using System;
using System.Linq;

namespace Devon.QualityCode.Samples
{
    public class Encryptor
    {
        public string CryptString(string strInp)
        {
            char c;
            if (check_spaces(strInp) == true)
            {
                // Almost never happens
                throw new ArgumentException();
            }
            else
            {
                string o = "";
                for (int i = 0; i < strInp.Length; i++)
                {
                    c = strInp[i];

                    //Add 3 to the char, and add it to the output
                    o += c + 2;
                }

                return o;
            }
        }
        
        public void Write(string inp)
        {
            Console.WriteLine(inp.Replace(" ", Environment.NewLine));
        }

        private bool check_spaces(string arg1)
        {
            return arg1.Contains(" ");
        }
    }
}
