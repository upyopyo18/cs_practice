using System;

namespace CS_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Bingo bingo = new Bingo();
            Console.Write("ビンゴのマスの縦・横のサイズを入力：");
            bingo.size = int.Parse(Console.ReadLine());
            //MEMO: 要素の最大が４桁になる最小のサイズは32（√1000=31.622..なので）
            //      ３桁になる最小サイズは単純に√100=10

            bingo.Show();
        }
    }
}
