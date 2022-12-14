using System;

namespace HomeWork_14_12_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Task No1
            //Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran metod

            //Console.WriteLine("Masiivin uzunlugunu teyin et:");
            //var countStr = Console.ReadLine();
            //var count = Convert.ToInt32(countStr);
            //int[] numbers= new int[count];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"{i}-ci indexdeki ededi daxil et: ");
            //    var numStr=Console.ReadLine();
            //    var num= Convert.ToInt32(numStr);
            //    numbers[i] = num;
            //}
            //Console.WriteLine(BigestIndex(numbers));

            //==========================================================================================================


            //Task No2
            //Verilmiş yazılar siyahısındaki (string array) verilmiş yazının yerləşdiyi indexi qaytaran metod.
            //Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın

            //Console.WriteLine("Massivin uzunlugunu teyin edin::");
            //var input = Console.ReadLine();
            //var size = Convert.ToInt32(input);
            //string[] words=new string[size];
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine($"{i}-ci indexde yerleshen sozu daxil et:");
            //    var str =Console.ReadLine();
            //    words[i] = str;
            //}

            //Console.WriteLine("Yazini daxil et:");
            //var inputWord = Console.ReadLine();

            //Console.WriteLine(StingIndex(words));


        }

        //Task No1:
        static int BigestIndex(int[] nums)
        {
            int max = nums[0];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                    index = i;
                }

            }
            return index;
           
        }

        //Task No2:
        static int StingIndex(string[] Str)
        {
            int result = 0;
            for (int i = 0; i < Str.Length; i++)
            {
                var word = Console.ReadLine();
                
                
                if (Str[i]==word)
                {
                    result = i; 

                }
                else
                {
                    result = -1;
                }
                
            }
            return result;
        }



    }
}
