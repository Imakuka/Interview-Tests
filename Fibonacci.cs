using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace InterviewTesting
{
    public class Fibonacci : MonoBehaviour
    {
        //Write a method Fib() that takes an integer n and returns the nnnth Fibonacci ↴ number.
        //Let's say our Fibonacci series is 0-indexed and starts with 0. So:

        [Header("Fibonacci Seq")]
        [SerializeField]
        private int _yourNumber;//user input - This is the number of sequence you want and the size of the sequence it creates
        [SerializeField]
        private List<int> _fibNumbers = new List<int>();//Creates a list of Fibonacci numbers based on the size from USer Input
        [SerializeField]
        private int _fibNumber;//This is _yourNumber from the list above - _yourNumber = _fibNumbers[_yourNumber]

        [Header("Is Fibonacci")]
        private int _isFibonacci;//Checking to see if this number is a Fibonacci number


        private void Start()
        {   
            Fib(_yourNumber);
            Print();      
        }

        private void Fib(int n)//n = the number you want to find
        {       
            int a = 0, b = 1, c = 0;// These are the Seed numbers for the start of the Fibonacci sequence
            _fibNumbers.Add(a);
            _fibNumbers.Add(b);

            for (int i = 0; i < n; i++)//n = the number you want to find & how long the sequence is
            {
                c = a + b;
                a = b;
                b = c;
                _fibNumbers.Add(c);
            }
            _fibNumber = _fibNumbers[n];
            Debug.Log(_fibNumber);
        }

        private void Print()//Prints to console
        {
            _isFibonacci = _yourNumber;

            if (IsFibonacci(_isFibonacci))//Calls the method and gives it the number we want to check
            {
                print("Is a Fibonacci");
            }
            else
            {
                print("Nope try again");
            }
        }
        private bool IsPerfectSquare(int number)
        {
            int square = (int)Mathf.Sqrt(number);//Stores the square root of the number int

            return square * square == number;//If "square root" sqaure * itself == the number int we have a perfect square
        }
        private bool IsFibonacci(int number)//Is this number a Fibonacci number?
        {
            return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4); //This is known as recursion
            //Checks to see if the square root of the product of our equation above is a perfect square
        }

    }
}

