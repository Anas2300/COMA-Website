using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Encryption
    {
        public static int SetEncryption(int id)
        {
            return (id + 120) * 8;
        }
        public static int GetEncryption(int encry)
        {
            int stage1 = encry / 8;
            return stage1 - 120;
        }

    }
}
