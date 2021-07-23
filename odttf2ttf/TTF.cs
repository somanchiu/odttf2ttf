using System;
using System.IO;
using System.Drawing.Text;

public class TTF
{
	public static string GetFontName(byte[] fontData)
	{
		unsafe
		{
			fixed (byte* ptr = fontData)
			{
				PrivateFontCollection fontCol = new PrivateFontCollection();
				fontCol.AddMemoryFont((IntPtr)ptr, fontData.Length);

				string fontName = fontCol.Families[0].Name;

				fontCol.Dispose();

				return fontName;
			}
		}
	}

	public static void Save(byte[] fontData)
	{
		string fontName = GetFontName(fontData);
		string outputFileName = fontName + ".ttf";

		using (FileStream fs = new FileStream(outputFileName, FileMode.Create))
		{
			fs.Write(fontData, 0, fontData.Length);
		}
	}
}