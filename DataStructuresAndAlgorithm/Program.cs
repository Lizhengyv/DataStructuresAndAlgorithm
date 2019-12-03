using System;

namespace DataStructuresAndAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 0; i <= 100; i++)
            {


                for (int j = 0; j <= 100; j++)
                {

                    for (int z = 0; z <=100; z++)
                        if ((i + j + z) == 100 && (z/3  + j * 3 + i * 5) == 100)
                        {
                            Console.WriteLine("公鸡买" + i + "母鸡" + j + "小鸡" + z);
                        }


                }

            }
            Console.ReadLine();
        }
    }
}

