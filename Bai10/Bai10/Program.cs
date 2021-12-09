using System;

namespace Bai10
{
    
    class Program
    {
        static void game()
        {
            Random rd = new Random();
            int number = rd.Next(1, 100);
            int count = 7;

            while (true)
            {
                Console.Write("Mời bạn đoán một số [1-100]: ");
                int guess = int.Parse(Console.ReadLine());



                count--;
                Console.WriteLine("Bạn còn {0} lượt dự đoán.", count);

                if (guess == number)
                {
                    Console.WriteLine("Chúc mừng bạn đã đoán đúng!\n");
                    break;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Bạn dự đoán sai, " +
                        "số bạn dự đoán lớn hơn đáp án của chương trình.\n");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Bạn dự đoán sai, " +
                        "số bạn dự đoán nhỏ hơn đáp án của chương trình.\n");
                }

                if (count == 0)
                {
                    Console.WriteLine("Bạn đã hết lượt dự đoán");
                    Console.WriteLine("Trò chơi kết thúc tại đây!!!\n1");
                    break;
                }
            }
        }

        static void endGame()
        {
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("CHÀO MỪNG BẠN ĐẾN VỚI TRÒ CHƠI ĐẾM SỐ!!!");


            while (true)
            {
                game();

                Console.Write("Bạn có muốn tiếm tục chơi không (c/k)? ");
                string c = Console.ReadLine();
                if (c == "c")
                {
                    Console.WriteLine("Trò chơi tiếp tục!");
                    game();
                }
                else
                {
                    Console.WriteLine("Trò chơi kết thúc! Tạm biệt :)");
                    break;
                }
            }
            

        }
    }
}
