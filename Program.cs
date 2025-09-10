using System.Numerics;
using System.Threading;
using Raylib_cs;

class Program
{
    static int[] elements = new int[198];
    static int barWidth = 5;
    static Random rand = new Random();
    static int numberOfAsync = 1;

    static bool sorted = false;
    static string algo = "";

    public static void Main(string[] args)
    {
        Raylib.InitWindow(1000, 300, "Sort Visualizer");
        Raylib.SetTargetFPS(144);

        Task.Run(() =>
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = rand.Next(0, 251);
                Thread.Sleep(5);

            }
            // Start Algorithm
            for (int i = 0; i < numberOfAsync; i++)
            {
                // * To change the algorithm change ths method
                Task.Run(() => GnomeSort());
            }
        });

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            Raylib.DrawText($"{algo}", 10, 12, 20, Color.WHITE);
            if (sorted){
                Raylib.DrawText("SORTED", 10, 35, 20, Color.GREEN);
            }

            // Draw each bar
            int currentX = 10;
            foreach (int number in elements)
            {
                Raylib.DrawRectangle(currentX, 300, -barWidth, -number, Color.WHITE);
                currentX += barWidth;
            }

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();

    }

    // Algorithms
    static void BubbleSort()
    {
        algo = "Bubble Sort";
        int maxPasses = 10000;
        while (true)
        {
            bool swapped = false;
            for (int i = 0; i < maxPasses; i++)
            {
                for (int j = 0; j < elements.Length - 1; j++)
                {
                    if (elements[j] > elements[j + 1]){
                        int temp = elements[j + 1];
                        elements[j + 1] = elements[j];
                        elements[j] = temp;
                        swapped = true;
                        Thread.Sleep(1);
                    }
                }
            }
            if (!swapped)
            {
                break;
            }
        }
        sorted = true;
    }

    static void InsertionSort(){
        algo = "Insertion Sort";
        int currentIndex = 0;
        for (int i = 1; i < elements.Length; i++)
        {
            currentIndex = i;
            while (elements[currentIndex] < elements[currentIndex - 1])
            {
                    int temp = elements[currentIndex - 1];
                    elements[currentIndex - 1] = elements[currentIndex];
                    elements[currentIndex] = temp;
                    if (currentIndex > 1){
                        currentIndex -= 1;
                    }
                    Thread.Sleep(1);
            }
        }
        sorted = true;
    }

    static void StalinSort()
    {
        algo = "Stalin Sort";
        int bigger = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] >= bigger)
            {
                bigger = elements[i];
            }
            else
            {
                elements[i] = 0;
            }
            System.Threading.Thread.Sleep(1);
        }
        sorted = true;
    }

    static void GnomeSort(){
        algo = "Gnome Sort";

        int i = 1;
        while (i < elements.Length)
        {
            if (elements[i] < elements[i - 1])
            {
                int temp = elements[i - 1];
                elements[i - 1] = elements[i];
                elements[i] = temp;
                Thread.Sleep(1);
                if (i > 1)
                {
                    i--;
                }
            }
            else{
                i++;
            }
        }
        sorted = true;
    }

}