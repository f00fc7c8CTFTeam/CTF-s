using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace rotating_key
{
  public class Program
  {
    private static readonly byte[] Salt = new byte[8]
    {
      (byte) 10,
      (byte) 20,
      (byte) 30,
      (byte) 40,
      (byte) 50,
      (byte) 60,
      (byte) 70,
      (byte) 80
    };
    public string iv = "O8XBUoHeqwAdYduWRGGk1A==";
    public byte[] key;

    public static void Main(string[] args)
    {
      Console.WriteLine("Into the house, back\nfrom our summer vacation.\nNow, time to relax!");
      string cipherText = "ndxjmSJhE1Pu98hu2BwOAuzZufFDaPR07PmEU9FIGQ0=";
      string password = ((int) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds).ToString();
      try
      {
        Console.WriteLine(new Program()
        {
          key = Program.CreateKey(password, 32)
        }.DecryptString(cipherText));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
      }
     
    }

    private static byte[] CreateKey(string password, int keyBytes = 32)
    {
      return new Rfc2898DeriveBytes(password, Program.Salt, 300).GetBytes(keyBytes);
    }

    public string EncryptString(string plainText)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      rijndaelManaged.Key = this.key;
      rijndaelManaged.IV = Convert.FromBase64String(this.iv);
      MemoryStream memoryStream = new MemoryStream();
      ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor();
      CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write);
      byte[] bytes = Encoding.ASCII.GetBytes(plainText);
      cryptoStream.Write(bytes, 0, bytes.Length);
      cryptoStream.FlushFinalBlock();
      byte[] array = memoryStream.ToArray();
      memoryStream.Close();
      cryptoStream.Close();
      return Convert.ToBase64String(array, 0, array.Length);
    }

    public string DecryptString(string cipherText)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      rijndaelManaged.Key = this.key;
      rijndaelManaged.Mode = CipherMode.CBC;
      rijndaelManaged.IV = Convert.FromBase64String(this.iv);
      rijndaelManaged.Padding = PaddingMode.None;
      MemoryStream memoryStream = new MemoryStream();
      ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor();
      CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Write);
      string empty = string.Empty;
      try
      {
        byte[] buffer = Convert.FromBase64String(cipherText);
        cryptoStream.Write(buffer, 0, buffer.Length);
        cryptoStream.FlushFinalBlock();
        byte[] array = memoryStream.ToArray();
        return Encoding.ASCII.GetString(array, 0, array.Length);
      }
      finally
      {
        memoryStream.Close();
        cryptoStream.Close();
      }
    }
  }
}
