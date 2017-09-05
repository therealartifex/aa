using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// ReSharper disable AssignNullToNotNullAttribute

namespace aa
{
    internal class Program
    {
        // index of this array is a block id; contents are what stack id it is in
        private static int[] indices;
        private static List<Stack<int>> stacks;
        private static void Main(string[] args)
        {
            indices = new int[int.Parse(Console.ReadLine())];
            for (var i = 0; i < indices.Length; i++)
            {
                indices[i] = i;
                stacks[i].Push(i);
            }

            while (true)
            {
                var tokens = Console.ReadLine()?.Split();
                if (tokens==null || tokens[0] == "quit") break;

                if (tokens[0] == "move" && tokens[2] == "onto") move_onto(int.Parse(tokens[1]), int.Parse(tokens[3]));
                if (tokens[0] == "move" && tokens[2] == "over") move_over(int.Parse(tokens[1]), int.Parse(tokens[3]));
                if (tokens[0] == "pile" && tokens[2] == "onto") pile_onto(int.Parse(tokens[1]), int.Parse(tokens[3]));
                if (tokens[0] == "pile" && tokens[2] == "over") pile_over(int.Parse(tokens[1]), int.Parse(tokens[3]));
            }
        }

        private static void pile_over(int a, int b)
        {
            throw new NotImplementedException();
        }

        private static void pile_onto(int a, int b)
        {
            throw new NotImplementedException();
        }

        private static void move_over(int a, int b)
        {
            var stack_a = stacks[indices[a]];
            var stack_b = stacks[indices[b]];

            while (stack_a.Count > 1)
            {
                var i = stack_a.Pop();
                indices[i] = i;
            }
        }

        private static void move_onto(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
