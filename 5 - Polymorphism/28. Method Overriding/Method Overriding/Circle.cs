﻿using System;

namespace Method_Overriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }
}