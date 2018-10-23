using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForSepik
{
    class Program
    {
        static void Main(string[] args)
        {
            string mostWidespread = Task.GetMostWidespread(new[] { "Emperor Penguin", "Macaroni Penguin", "Emperor Penguin", "Little Penguin" });
            Console.WriteLine(mostWidespread); // Emperor Penguin

            Console.ReadKey();
        }
    }

    public class Task
    {
        public static string GetMostWidespread(string[] arr)
        {
            int EmperorPenguins = 0;
            int LittlePenguins = 0;
            int MacaroniPenguins = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "Emperor Penguin")
                {
                    EmperorPenguins++;
                    //Console.WriteLine(arr[i]);
                }
                else if (arr[i] == "Little Penguin")
                {
                    LittlePenguins++;
                    //Console.WriteLine(arr[i]);
                }
                else if (arr[i] == "Macaroni Penguin")
                {
                    MacaroniPenguins++;
                    //Console.WriteLine(arr[i]);
                }
            }

            if (EmperorPenguins >= LittlePenguins && EmperorPenguins >= MacaroniPenguins)
            {
                return "Emperor Penguin";
            }
            else if (LittlePenguins >= EmperorPenguins && LittlePenguins >= MacaroniPenguins)
            {
                return "Little Penguin";
            }
            else
            {
                return "Macaroni Penguin";
            }
        }
    }
}

