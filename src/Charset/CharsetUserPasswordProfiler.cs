using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crisis
{
    public partial class Charset
    {

        public static void BirthdatePerson()
        {
            string str = Console.ReadLine();
            if (str.Length == 8 & str != string.Empty)
            {
                Charset.CharsetSelecting.Add(str);
                Charset.CharsetSelecting.Add(str.Substring(0, 2));
                Charset.CharsetSelecting.Add(str.Substring(2, 2));
                Charset.CharsetSelecting.Add(str.Substring(4, 4));
                Charset.CharsetSelecting.Add(str.Substring(6, 2));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Length of the birth date false\n");
                Console.ResetColor();
            }
        }

    public static void initialPersonne(string name, string surname)
    {
      try
      {
        if (!(name.Length > 2 & surname.Length > 2 & name != null & surname != null & name != string.Empty & surname != string.Empty))
          return;
        string str1 = name[0].ToString() + surname[0].ToString();
        Charset.CharsetSelecting.Add(str1.ToUpper());
        Charset.CharsetSelecting.Add(str1.ToLower());
        Charset.CharsetSelecting.Add(name[0].ToString().ToUpper() + surname[0].ToString().ToLower());
        Charset.CharsetSelecting.Add(name[0].ToString().ToLower() + surname[0].ToString().ToUpper());
        string str2 = surname[0].ToString() + name[0].ToString();
        Charset.CharsetSelecting.Add(str2.ToUpper());
        Charset.CharsetSelecting.Add(str2.ToLower());
        Charset.CharsetSelecting.Add(surname[0].ToString().ToUpper() + name[0].ToString().ToLower());
        Charset.CharsetSelecting.Add(surname[0].ToString().ToLower() + name[0].ToString().ToUpper());
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" {0} \n", (object) ex.Message);
        Console.ResetColor();
      }
    }

    internal static string CustomCharsetWord()
    {
      string str = Console.ReadLine();
      if (str != string.Empty)
        Charset.CharsetSelecting.Add(str);
      return str;
    }

    internal static void CustomCharsetSpecial()
    {
      Charset.CharsetSelecting.Concat<string>((IEnumerable<string>) Charset.symbols_all).ToList<string>();
    }

    internal static void CustomCharsetNumber(int min, int max)
    {
      try
      {
        for (int index = min; index < max; ++index)
        {
          SubMenu.RemoveDuplicate();
          Charset.CharsetSelecting.Add(index.ToString());
        }
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" {0} \n", (object) ex.Message);
        Console.ResetColor();
      }
    }

    internal static void CustumCHarsetUpperCase()
    {
      try
      {
        for (int index = 0; index < Charset.CharsetSelecting.Count; ++index)
        {
          Charset.CharsetSelecting.Add(Charset.CharsetSelecting[index].ToUpper().ToString());
          SubMenu.RemoveDuplicate();
        }
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" {0} \n", (object) ex.Message);
        Console.ResetColor();
      }
    }

    internal static void CustumCHarsetLowerCase()
    {
      try
      {
        for (int index = 0; index < Charset.CharsetSelecting.Count; ++index)
        {
          Charset.CharsetSelecting.Add(Charset.CharsetSelecting[index].ToLower().ToString());
          SubMenu.RemoveDuplicate();
        }
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" {0} \n", (object) ex.Message);
        Console.ResetColor();
      }
    }
  }
}
