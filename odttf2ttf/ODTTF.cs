using System;
using System.IO;

public class ODTTF
{
	public static byte[] Deobfuscate(string odttfFilePath)
	{
		byte[] fontData;

		using (FileStream fs = new FileStream(odttfFilePath, FileMode.Open))
		{
			fontData = new byte[fs.Length];
			fs.Read(fontData, 0, fontData.Length);
		}

		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(odttfFilePath);

		string guid = fileNameWithoutExtension.Replace("-", "");

		byte[] key = new byte[16];
		for (int i = 0; i < key.Length; i++)
		{
			key[key.Length - 1 - i] = Convert.ToByte(guid.Substring(i * 2, 2), 16);
		}

		for (int i = 0; i < 32; i++)
		{
			fontData[i] ^= key[i % key.Length];
		}

		return fontData;
	}
}