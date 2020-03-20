using System;
namespace CS_Practice
{
    public class Bingo
    {
        public int size = 0;
        public int[,] card;

        //ランダムでカードを生成するメソッド
        private void create_card()
        {
            this.card = new int[this.size, this.size];
            Random rnd = new Random();
            for (int i = 0; i < this.size * this.size; i++)
            {
                //ランダムな位置を指定し、まだ初期値であれば数字を入れる
                while (true)
                {
                    int row = rnd.Next(0, this.size);
                    int col = rnd.Next(0, this.size);

                    if (this.card[row, col] == 0)
                    {
                        this.card[row, col] = i + 1;
                        break;
                    }
                }
            }
        }

        //ビンゴの表示を行うメソッド
        public void Show()
        {
            this.create_card();
            //最大値の桁数の計算
            int digit = (this.size * this.size).ToString().Length;

            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    //最大の桁数に合わせて、各数字を空白埋めする。
                    Console.Write("|{0}", this.card[i, j].ToString().PadLeft(digit,' '));
                }
                //行末の"|"の表示
                Console.WriteLine("|");

                //横線の数を桁数から計算して表示
                for(int j = 0; j < this.size * (digit + 1) + 1; j++)
                    Console.Write("-");
                Console.WriteLine();

            }
        }

    }
}
