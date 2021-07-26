using System;

namespace odttf2ttf
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[] { @"F:\Downloads\odttf2ttf\55CA5D26-42DC-2D5C-A974-88760365FB0A.odttf" };
            if (args.Length == 0)
            {
                Console.WriteLine("odttf2ttf <odttfFilePath1> [odttfFilePath2] [odttfFilePath3]...");
                return;
            }

            for (int i=0; i<args.Length;i++) 
            {
                TTF.Save(ODTTF.Deobfuscate(args[i]));
            }
        }
    }
}
