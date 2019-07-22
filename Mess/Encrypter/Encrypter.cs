using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncrypterDLL
{
    public static class Encrypter
    {
        public static string Encrypt (string str, int key = 42) => new string(str.Select(c => (char)(c + key)).ToArray());
        public static string Deencrypt (string str, int key = 42) => new string(str.Select(c => (char)(c - key)).ToArray());
    }
}
