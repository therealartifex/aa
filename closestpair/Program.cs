using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

// ReSharper disable AssignNullToNotNullAttribute

namespace closestpair
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var points = new Dictionary<string,Point>();
            var t = int.Parse(Console.ReadLine());

            for (var i = 0; i < t; i++)
            {
                var c = Console.ReadLine()?.Split();
                points.Add(c[2], new Point(double.Parse(c[0]),double.Parse(c[1])));
            }


        }
    }
}