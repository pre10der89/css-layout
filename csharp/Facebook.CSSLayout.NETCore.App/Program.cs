using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facebook.CSSLayout.NETCore.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CSSNode parent = new CSSNode();
            CSSNode child = new CSSNode();

            parent.Insert(0, child);

            parent.RemoveAt(0);
        }
    }
}
