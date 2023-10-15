using System;


namespace practice2
{
    internal class Program
    {
        class Block
        {
            public Block()
            {
                isChecked = false;
                isBoom = false;
                surBoom_num = 0;
            }
            public bool isChecked, isBoom;
            public int surBoom_num;
        }
        static void Print_Map(Block[,] blocks)
        {
            Console.Write("   ");
            for (int i = 0; i < blocks.GetLength(1); i++) Console.Write($"{Convert.ToChar('A' + i)} ");
            Console.Write("\n");
            for (int i = 0; i < blocks.GetLength(0); i++)
            {
                Console.Write(i < 10 ? $"{i}  " : $"{i} ");
                for (int j = 0; j < blocks.GetLength(1); j++)
                {
                    Console.Write(!blocks[i, j].isChecked ? "- " : blocks[i, j].isBoom ? "X " : $"{blocks[i, j].surBoom_num} ");
                }
                Console.Write("\n");
            }
        }
        static void Main()
        {
            //Initializing Game Paras
            Console.Write("設定遊戲參數\n輸入空間的大小: ");
            string[]  ss = Console.ReadLine().Split(",");
            int height = Convert.ToInt32(ss[0]), width = Convert.ToInt32(ss[1]);
            Console.Write("輸入鬼的數量: ");
            int ghost_num = Convert.ToInt32(Console.ReadLine());
            if (height * width <= ghost_num) 
            {
                Console.WriteLine("遊戲參數錯誤，並結束程式。"); 
                Environment.Exit(1);
            }
            Console.Clear();
            Block[,] blocks = new Block[height, width];
            for(int i = 0; i < height; i++)
                for(int j = 0; j < width; j++)
                    blocks[i, j] = new Block();
            bool isFirstTime = true, lose = false;
            int checked_num = 0; //檢查已經check了幾個
            while (true)
            {
                Console.Clear();
                Print_Map(blocks);
                //有無效輸出時 會continue繼續下一個迴圈 否則就跑完最下面就會有一個break
                while (true)
                {
                    //確認沒有檢查到重覆的或是超出範圍的
                    Console.Write("輸入要查看的位置: ");
                    string[] s = Console.ReadLine().Split(",");
                    Tuple<int, int> pos = new(Convert.ToInt32(s[0]), Convert.ToChar(s[1]) - 'A');
                    if (pos.Item1 < 0 || pos.Item1 >= height || pos.Item2 < 0 || pos.Item2 >= width || blocks[pos.Item1, pos.Item2].isChecked)
                    {
                        Console.WriteLine("無效的輸入，請再試一次"); continue;
                    }
                    //檢查有沒有踩到鬼
                    if (blocks[pos.Item1, pos.Item2].isBoom)
                    {
                        lose = true;
                        Console.Clear();
                        break;
                    }
                    checked_num++;
                    blocks[pos.Item1, pos.Item2].isChecked = true;
                    //第一次踩，採完才安排鬼進來
                    if (isFirstTime)
                    {
                        Random rnd = new Random();
                        int ghost_num_copy = ghost_num;
                        for (; ghost_num_copy > 0; ghost_num_copy--)
                        {
                            Tuple<int, int> ghost_pos = new(rnd.Next(0, height), rnd.Next(0, width));
                            if (blocks[ghost_pos.Item1, ghost_pos.Item2].isChecked || blocks[ghost_pos.Item1, ghost_pos.Item2].isBoom)
                            {
                                ghost_num_copy++; continue;
                            }
                            blocks[ghost_pos.Item1, ghost_pos.Item2].isBoom = true;
                            //順便計算每個格子的值(相鄰鬼的數量)
                            for(int dx = -1; dx < 2; dx++)
                            {
                                for(int dy=-1;dy < 2; dy++)
                                {
                                    if (dx == 0 && dy == 0) continue;
                                    if (ghost_pos.Item1 + dx < 0 || ghost_pos.Item1 + dx >= height || ghost_pos.Item2 + dy < 0 || ghost_pos.Item2 + dy >= width) continue;
                                    blocks[ghost_pos.Item1 + dx, ghost_pos.Item2 + dy].surBoom_num++;
                                }
                            }
                        }
                        isFirstTime = false;
                    } 
                    break;
                }
                //檢查還能不能再猜 相等時就是已經把非炸彈都猜完了
                if (checked_num == height * width - ghost_num || lose) break;
            }
            Console.Clear();
            for (int i = 0; i < blocks.GetLength(0); i++)
                for (int j = 0; j < blocks.GetLength(1); j++)
                    blocks[i, j].isChecked = true;
            Print_Map(blocks);
            if (lose)
            {
                Console.WriteLine("遊戲結束! 你被鬼抓到了");
            } else
            {
                Console.WriteLine("遊戲結束! 你成功躲避所有的鬼了");
            }
        }
    }
}
