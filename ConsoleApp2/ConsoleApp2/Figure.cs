﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Figure
    {
        public float Lenght { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public Figure(float lenght, float width, float height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
        }

        public void findSomeProperties()
        {
            if (Lenght <= 0 || Width <= 0 || Height <= 0)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Значение не может быть 0 или быть негативным");
                Console.WriteLine("-------------------------------------");
            }
            else
            {
                float SurfaceArea = 0.0f;      //Площадь поверхности
                float LateralSurfaceArea = 0.0f;  //Площадь боковой поверхности
                float Volume = 0.0f; //Объем

                SurfaceArea = (2 * (Lenght * Width)) + (2 * (Lenght * Height)) + (2 * (Width * Height));
                LateralSurfaceArea = (2 * (Lenght * Height)) + (2 * (Width * Height));
                Volume = (Lenght * Width * Height);

                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"Площадь поверхности - {SurfaceArea.ToString("0.00")}");
                Console.WriteLine($"Площадь боковой поверхности - {LateralSurfaceArea.ToString("0.00")}");
                Console.WriteLine($"Объем - {Volume.ToString("0.00")}");
                Console.WriteLine("-------------------------------------");
            }
        }

    }
}
