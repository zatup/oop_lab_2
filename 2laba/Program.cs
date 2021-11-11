using System;
using System.Text;

namespace _2laba
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1a
            //Console.WriteLine("Enter types: ");
            //Console.Write("Bool: ");
            //bool TF = Convert.ToBoolean(Console.ReadLine()); //true или false

            //Console.Write("Byte: ");
            //byte by = Convert.ToByte(Console.ReadLine()); //0 to 255

            //Console.Write("Char: ");
            //char x = Convert.ToChar(Console.ReadLine()); //одиночный символ в кодировке Unicode

            //Console.Write("Decimal: ");
            //decimal y = Convert.ToDecimal(Console.ReadLine()); // mnogacifr

            //Console.Write("Double: ");
            //double z = Convert.ToDouble(Console.ReadLine()); //men'she cifr

            //Console.Write("Float: ");
            //float p = Convert.ToSingle(Console.ReadLine());//cifirki

            //Console.Write("Int: ");
            //int i = Convert.ToInt32(Console.ReadLine());//-/+

            //Console.Write("Long: ");
            //long l = Convert.ToInt64(Console.ReadLine());//-/+

            //Console.Write("SByte: ");
            //sbyte sb = Convert.ToSByte(Console.ReadLine());//-128 до 127

            //Console.Write("Short: ");
            //short sh = Convert.ToInt16(Console.ReadLine()); //-32768 до 32767

            //Console.Write("UInt: ");
            //uint ui = Convert.ToUInt32(Console.ReadLine());//0 до 4294967295

            //Console.Write("ULong: ");
            //ulong ul = Convert.ToUInt64(Console.ReadLine());//0 до 18 446 744 073 709 551 615

            //Console.Write("UShort: ");
            //ushort ush = Convert.ToUInt16(Console.ReadLine());//0 до 65535

            //Console.Write("String: ");
            //string st = Convert.ToString(Console.ReadLine());// набор символов Unicode

            //Console.WriteLine("\nTypes: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}",
            //        TF, by, x, y, z, p, i, l, sb, sh, ui, ul, ush, st);
            //// 1b
            //// Неявное преобразование
            //int pr1 = by;
            //ushort pr2 = by;
            //short pr3 = sb;
            //long pr4 = sh;
            //double pr5 = p;
            //// Явное преобразование
            //byte bt1 = (byte)sh;
            //byte bt2 = (byte)(l + sb);
            //decimal bt3 = (decimal)z;
            //double bt4 = (double)i;
            //long bt5 = (long)sh;
            //// 1c упаковка
            //int box = 47;
            //Object obj1 = box;
            //int unbox = (int)box;
            //// 1d неявно типизированная переменная
            //var strNew = "Variable";
            //var inNew = 20;
            //// 1e
            //int? nul = 46;
            //Nullable<int> nul2 = 47;
            //// 1f
            //var last = 1111;
            ////last = "err";
            ///*  Компилятор увидит, что мы пытаемся присвоить var тип int
            // и при переназначении на другой тип он выдаст ошибку. */
            //// 2a
            //string str1 = "english";
            //string str2 = "language";
            //Console.WriteLine("Compare: ", string.Compare(str1, str2));// сравнение
            //// 2b
            //string s1 = "1 строка ";
            //string s2 = "2 строка ";
            //string s3 = "3 строка";

            //string s4 = string.Concat(s1 + s2 + s3);//сцепление
            //Console.WriteLine(s4);

            //string s5 = string.Copy(s1);//копирование
            //Console.WriteLine(s5);

            //string s6 = s4.Substring(4, 10);// 4 beginning, 10 length
            //Console.WriteLine(s6);

            //string s7 = s1.Insert(3, s6);// вставка
            //Console.WriteLine(s7);

            //string StrToSplit = "Строка, которую щас распилят";
            //char[] delit = ".,;:!?\n\xD\xA\" ".ToCharArray();
            //string[] splittedWords = StrToSplit.Split(delit, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string word in splittedWords)
            //    Console.WriteLine(word);

            //string Strrem = StrToSplit.Remove(4, 5);
            //Console.WriteLine(Strrem);

            //int interpol1 = 15;
            //int interpol2 = 51;
            //string interstring = ($"Summ: {interpol1 + interpol2} ");
            //Console.WriteLine(interstring);

            //// 2c
            //string vstring = "";
            //string nstring = null;
            //if(String.IsNullOrEmpty(nstring))
            //    {
            //        Console.WriteLine("null or empty");
            //    }
            //// 2d
            //StringBuilder SB = new StringBuilder("stringbuilder string");
            //Console.WriteLine(SB);
            //SB.Remove(3, 4);
            //Console.WriteLine(SB);
            //SB.Insert(0, "inkabout");
            //Console.WriteLine(SB);
            //SB.AppendFormat("i");
            //Console.WriteLine(SB);

            //// 3a 
            //int[,] matrix = { { 0, 1, 2 },{ 3, 4, 5 },{ 7, 8, 9 } };
            //int rows = matrix.GetUpperBound(0) + 1;    // количество строк
            //int columns = matrix.Length / rows;        // количество столбцов
            //for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < columns; j++)
            //        {
            //            Console.Write($"{matrix[i, j]} \t");
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine();
            //    }
            //// 3b
            //string[] masstring = { "el1", "el2", "el3" };
            //for (int i = 0; i < masstring.Length; i++)
            //{
            //    Console.WriteLine("element[{0}]={1}", i, masstring[i]);
            //}
            //Console.WriteLine("Length= " + masstring.Length);
            //masstring[2] = "abobus";
            //for (int i = 0; i < masstring.Length; i++)
            //{
            //    Console.WriteLine("element[{0}]={1}", i, masstring[i]);
            //}

            //// 3c
            //double[][] mamas = new double[3][];
            //mamas[0] = new double[2];
            //mamas[1] = new double[3];
            //mamas[2] = new double[4];
            //for (int i = 0; i < mamas.Length; i++)
            //{
            //    for (int j = 0; j < mamas[i].Length; j++)
            //    {
            //        mamas[i][j] = double.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < mamas.Length; i++)
            //{
            //    for (int j = 0; j < mamas[i].Length; j++)
            //    {
            //        Console.WriteLine(mamas[i][j]);
            //    }
            //}

            //// 3d
            //var names = new[]
            //{
            //    new {name="putin"},
            //    new {name="abama"}
            //};
            //var anonimusstring = "";

            //// 4a
            //(int, string, char, string, ulong) tumbler1 = (3, "stroka", 'c', "2ya stroka", 123456789);
            //(int, string, char, string, ulong) tumbler2 = (3, "stroa", 'c', "2ya sroka", 12789);
            ////4b
            //Console.WriteLine(tumbler1);
            //Console.WriteLine(tumbler1.Item1 + " " + tumbler1.Item2 + " " + tumbler1.Item5);
            ////4c
            //var (a1, a2, a3, a4, a5) = tumbler1;
            //(var b1, var b2, var b3, var b4, var b5) = tumbler1;
            //(int c1, string c2, char c3, string c4, ulong c5) = tumbler1;
            ////4d
            //if (tumbler1 == tumbler2)
            //    {
            //        Console.WriteLine("Equal");
            //    }
            //else
            //    {
            //        Console.WriteLine("Not Equal");
            //    }
            //5
            //(int, int, int, char) func(int[] potato, string str)
            //  {
            //      int min = potato[0], max = potato[0], summ = 0;
            //      for (int i = 0; i < potato.Length; i++)
            //          {
            //              summ += potato[i];
            //              if (max < potato[i])
            //                  {
            //                      max = potato[i];
            //                  }
            //          }

            //      for (int i = 0; i < potato.Length; i++)
            //          {
            //              if (min > potato[i])
            //                  {
            //                      min = potato[i];
            //                  }
            //          }
            //      var result = (max, min, summ, str[0]);
            //      return result;
            //  }
            //6
            byte Checked_()
            {
                checked
                {
                    byte n = 255;
                    return 0;
                }
            }

            byte UnChecked_()
            {
                unchecked
                {
                    byte n = 255;
                    return 0;
                }
            }
            Checked_();
            UnChecked_();
        }
    }
}
