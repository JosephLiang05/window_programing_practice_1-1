using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int revenue = 0;
            string[] expendCategory = new string[5] { "食", "衣", "住", "行", "育樂" };
            int[] expend = new int[5];

            while (true)
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)計算比例 (4)剩餘金額 (5)退出程式");
                Console.Write("輸入數字選擇功能: ");
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.Write("輸入金額: ");
                        revenue += int.Parse(Console.ReadLine());
                        break;
                    


                    case 2:
                        Console.WriteLine("(1)食 (2)衣 (3)住 (4)行 (5)育樂");
                        Console.Write("輸入數字選擇支出項目: ");
                        choose = int.Parse(Console.ReadLine());

                        Console.Write("輸入支出金額: ");
                        int tmp = int.Parse(Console.ReadLine());
                        expend[choose - 1] += tmp;

                        break;
                    
                        
                    case 3:
                        for(int i = 0; i < 5; i++) {
                            double ratio = 100.0 * expend[i] / expend.Sum();
                            if (expend.Sum() == 0)
                            {
                                ratio = 0;
                            }
                            Console.WriteLine("{0}: {1}%",expendCategory[i], ratio);
                        }
                        break;
                    
                        
                    case 4:
                        Console.WriteLine("剩餘金額為: {0}", revenue - expend.Sum());
                        break;
                    case 5:
                        return;
                }
            }
            
        }
    }
}
