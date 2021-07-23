using System;

namespace odttf2ttf
{
    class Program
    {
		static void Main(string[] args)
		{
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
