using System;

namespace MyModelingKitVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolKit schoolKit1 = new("Red", 15.7, 5);

            ColoredPencil coloredPencil1 = new("Blue", 20, 50);
            PaperPencil paperPencil1 = new("Grey", 20, 50);

            paperPencil1.Use("Bienvenue dans le monde de la fin des chose affreusement tester pour le moment");
        }
    }
}
