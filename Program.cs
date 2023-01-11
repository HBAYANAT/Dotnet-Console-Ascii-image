using System;
using System.Drawing;



// the Set Window Size and Set Butter Size allows you to controle the windows Size and memory size in the computer
Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

// set Window position to the top letf corner of the screen
//  this simulates a fullscreen effect but there is nothing better than ALT-ENTER to togle btween FullScreen and Windowed mode
Console.SetWindowPosition(0, 0);


Console.ForegroundColor = ConsoleColor.Green;  // set text color to green
Console.BackgroundColor = ConsoleColor.Black;  // background to Black

Console.Clear();  // Clear the screen from any previouse text or commandes

// this can be removed it prints the screen size it can be handy to adjust the image on top of it
Console.WriteLine($"Width:{Console.WindowWidth},  Height:{Console.WindowHeight}");

string path = "img.png";


using (Bitmap image = new Bitmap(path))
{
    // Loop through the pixels in the image
    for (int y = 0; y < image.Height; y++)
    {
        for (int x = 0; x < image.Width; x++)
        {
            // current positions Pixel
            Color pixel = image.GetPixel(x, y);

            // Calculate the luminance of the pixel
            int PixelLight = (int)(0.2126 * pixel.R + 0.7152 * pixel.G + 0.0722 * pixel.B);

            // Choose an ASCII character based on the luminance
            char asciiChar;
            if (PixelLight < 50) asciiChar = '#';
            else if (PixelLight < 100) asciiChar = '*';
            else if (PixelLight < 150) asciiChar = '-';
            else if (PixelLight < 200) asciiChar = '.';
            else asciiChar = ' ';

            // Print the ASCII character to the console
            Console.Write(asciiChar);
        }

    }
    Console.ReadKey();
}