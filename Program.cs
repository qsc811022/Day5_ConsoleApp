using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// 計算一天停車費, 一小時5 元, 每天最多收 30元
			Console.Write("請輸入停車的小時數(1~24):");
			string input = Console.ReadLine();

			// 在本練習裡,不特別針對輸入值是否正確進行檢查
			int hours = int.Parse(input);

			int fee = Q1(hours);

			Console.WriteLine($"停車時數={hours}, 停車費用為 {fee}");
		}
		static int Q1(int hours)
		{
            // todo
            if (hours >= 6)
            {
				return 30;
            }
            else
            {
				return hours*5;
            }


		}
	}
}
