﻿using HeaderUtility.Interfaces;

using static System.Console;

namespace HeaderUtility
{

    public class Header : IHeader
    {

        public void PrintHeader(char header, string title, int length = 100, ConsoleColor foregroundColor = ConsoleColor.Yellow)
        {
            var leftPadValue = ((length - title.Length) / 2) + title.Length;
            string headerValue = new(header, length);

            ForegroundColor = ConsoleColor.Yellow;

            WriteLine($"\n\n{headerValue}");
            WriteLine(title.PadLeft(leftPadValue));
            WriteLine($"{headerValue}\n");

            ResetColor();
        }

    }

}