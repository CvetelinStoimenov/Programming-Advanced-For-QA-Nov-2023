using System.Reflection.Emit;
using System.Security.Principal;

namespace _09._01._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songComponents = Console.ReadLine().Split("_");
                string songTypeList = songComponents[0];
                string songName = songComponents[1];
                string songTime = songComponents[2];

            }
        }
    }
    public class Song
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public string TypeList { get; set; }
    }
}