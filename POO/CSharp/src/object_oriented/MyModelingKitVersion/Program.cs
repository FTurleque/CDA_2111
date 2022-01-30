using System;

namespace MyModelingKitVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tools creation and use.
            ColoredPencil colorPencilGreen = new("Green");
            colorPencilGreen.Use();
            ColoredPencil colorPencilGreen2 = new("Black");
            colorPencilGreen2.Use();
            PaperPencil paperPencil1 = new();
            paperPencil1.Use();
            NibPen nibPenBlue = new("Blue");
            nibPenBlue.Use();
            BallPen ballPenRed = new("Red");
            ballPenRed.Use();

            // School kit creation.
            SchoolKit schoolKit1 = new SchoolKit(2, "Blue");
            SchoolKit schoolKit2 = new SchoolKit(5, "Red");
            SchoolKit schoolKit3 = new SchoolKit(0, "Purple");

            // Fill in the school kit.
            schoolKit1.AddTool(colorPencilGreen);
            schoolKit1.Open();
            schoolKit1.AddTool(colorPencilGreen);
            schoolKit1.AddTool(colorPencilGreen2);
            schoolKit1.AddTool(nibPenBlue);
            schoolKit1.Close();

            schoolKit2.Open();
            schoolKit2.AddTool(nibPenBlue);
            schoolKit2.AddTool(nibPenBlue);
            schoolKit2.AddTool(paperPencil1);
            schoolKit2.Close();

            // Remove the tools in the school kit.
            schoolKit1.RemoveTool(colorPencilGreen);
            schoolKit1.Open();
            schoolKit1.RemoveTool(colorPencilGreen);
            schoolKit1.RemoveTool(colorPencilGreen2);
            schoolKit1.RemoveTool(nibPenBlue);
            schoolKit1.Close();

            schoolKit2.Open();
            schoolKit2.RemoveTool(nibPenBlue);
            schoolKit2.RemoveTool(nibPenBlue);
            schoolKit2.Close();
        }
    }
}
