using System;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var Radio = new Radio();
            var Parrot = new Parrot();
            var FireWork = new Firework();

            ISound[] SoundList = { Radio , Parrot , FireWork };

            foreach (var item in SoundList)
            {
                Console.Write(item.ToString()+ " ");
                item.PlaySound();
            }
        }
    }
}