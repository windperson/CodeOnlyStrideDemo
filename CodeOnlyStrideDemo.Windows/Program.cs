using CodeOnlyStrideDemo.GameApp;
using System;

namespace CodeOnlyStrideDemo.Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var game = new CodeOnlyGame())
            {
                game.Run();
            }
        }
    }
}
