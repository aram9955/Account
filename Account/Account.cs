﻿namespace Account
{
    class Account
    {
        public static decimal bonus = 100;

        public decimal totalSum;
        public Account(decimal sum)
        {
            totalSum = sum + bonus;
        }
    }
}