using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ORPI.Web.BL.Helper
{
    public static class StreamHelper
    {
        public static String GetStringFromFile(String path)
        {
            Char[] buffer;
            using (var sr = new StreamReader(path))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                sr.Read(buffer, 0, (int)sr.BaseStream.Length);
            }
            return new String(buffer);
        }
    }
}
