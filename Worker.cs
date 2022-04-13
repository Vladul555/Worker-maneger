using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Worker
    {
        public static Random rand = new Random();
        public string name, phone_number, family_name, email, adress;
        public long id, pay;
        public static string[] names = { "Marcia", "Mona", "Darcy", "Johnathan", "Natalie", "Alyson", "Jesus", "Lynnette", "Andrea", "Julia" };
        public static string[] last_names = { "Manning", "Nguyen", "Mcknight", "Christensen", "Travis", "Paul", "Torres", "Richard", "Wolf", "Wood" };
        public static string[] usernames = { "Fearendyne", "Firstimer", "GodzillaNotes", "Highboline", "Infoneau", "KeepupCooled", "Kuninvety", "Laerdic", "Ludalertwo", "LudaRose" };
        public static string[] address = { "Tristin Corner", "Alice Path", " Margarita Summit", " Demario Dam", " Wuckert Fall ", " Langworth Unions Suite ", " Fisher Keys", " Lawrence Road", " Kemmer Road", " Chloe Rest Suite " };

        public Worker(string name, string family_name, string email, string adress, long id, string phone_number, long pay)
        {
            this.name = name;
            this.family_name = family_name;
            this.email = email;
            this.adress = adress;
            this.id = id;
            this.phone_number = phone_number;
            this.pay = pay;
        }
        public static string random(string[] array)
        {

            int index = rand.Next(10);
            Console.WriteLine(index);
            return array[index];
        }
        public static string Randome_name()
        {
            return random(names);
        }

        public static string Random_family_name()
        {
            return random(last_names);
        }

        public static string Random_email()
        {
            return random(usernames) + rand.Next(999);
        }

        public static string Random_adress()
        {
            return rand.Next(999) + " " + random(address);
        }

        public static string Random_phone_number()
        {
            return '0' + rand.Next(50, 59).ToString() + rand.Next(9).ToString() + rand.Next(9).ToString() + rand.Next(9).ToString() + "-" + rand.Next(9).ToString() + rand.Next(9).ToString() + rand.Next(9).ToString() + rand.Next(9).ToString();
        }

        public static long Random_pay()
        {
            return rand.Next(3000, 50000);
        }
        public static void bubbleSort(List<Worker> arr)
        {
            Worker temp;
            for (int j = 0; j <= arr.Count - 2; j++)
            {
                for (int i = 0; i <= arr.Count - 2; i++)
                {
                    if (arr[i].pay < arr[i + 1].pay)
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        public static bool SortArray(List<Worker> array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                var pivot = Partition(array, leftIndex, rightIndex);
                if (pivot > 1)
                {
                    SortArray(array, leftIndex, pivot - 1);
                }
                if (pivot + 1 < rightIndex)
                {
                    SortArray(array, pivot + 1, rightIndex);
                }
            }
            return true;
        }
        public static int Partition(List<Worker> array, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            long pivot = array[rightIndex].pay;
            Worker temp;

            for (int j = leftIndex; j <= rightIndex; j++)
            {
                if (array[j].pay > pivot)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }

            temp = array[rightIndex];
            array[rightIndex] = array[i];
            array[i] = temp;
            return i;
        }
    }
}

