﻿using System;

namespace Lab4
{
	public class Rectangle:Shape
	{
        public Rectangle()
        {
            Height = 1.0;
            Width = 1.0;
            Color = "gold";
        }
        public Rectangle(string col, double wid, double hei)
        {
            Height = hei;
            Width = wid;
            Color = col;
        }
        public Rectangle(Rectangle a)
        {
            Height = a.Height;
            Width = a.Width;
            Color = a.Color;
        }
        public override double getArea()
        {
            return this.Height * this.Width;
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}{4}{5}]", this.Width, this.Height, this.getArea(), '"', this.Color, '"');
        }
    }
}

