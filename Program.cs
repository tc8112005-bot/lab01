﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Chuong trinh doan so ===");
            Random random = new Random();
            int targetNumber = random.Next(100, 999);
            string targetString = targetNumber.ToString();

            int attempt = 1, MAX_GUESS = 7;
            string guess, feedback = "";
            while (feedback != "+++" && attempt <= MAX_GUESS)
            {
                Console.Write("Lan doan thu {0}: ", attempt);
                guess = Console.ReadLine();
                feedback = GetFeedback(targetString, guess);
                Console.WriteLine("Phan hoi tu may tinh: {0}", feedback);
                attempt++;
            }
            Console.WriteLine("Nguoi choi da doan {0} lan. Tro choi ket thuc!", attempt - 1);
            if (feedback != "+++")
                Console.WriteLine("Nguoi choi thua cuoc. So can doan la: {0}", targetNumber);
            else
                Console.WriteLine("Nguoi choi thang cuoc!", attempt);
            Console.ReadLine();
        }
        static string GetFeedback(string target, string guess)
        {
            string feedback = "";
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == guess[i])
                    feedback += "+";
                else if (target.Contains(guess[i].ToString()))
                    feedback += "?";
            }
            return feedback;
        }
    }
}