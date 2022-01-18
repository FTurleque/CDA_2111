using System;

namespace MyModelingKitVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            ColoredPencil colorPencilGreen = new("vert");
            colorPencilGreen.Use();
            colorPencilGreen.Use();
            colorPencilGreen.Use();
            colorPencilGreen.Use();
            ColoredPencil colorPencilGreen2 = new("vert");
            NibPen nibPenBlue = new("bleu");
            BallPen ballPenRed = new("rouge");

            SchoolKit schoolKit = new SchoolKit(2);

            schoolKit.Open();
            schoolKit.AddTool(colorPencilGreen);
            schoolKit.AddTool(colorPencilGreen2);

        }
    }
}
