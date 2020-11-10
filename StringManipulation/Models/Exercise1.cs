using StringManipulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Models
{
    class Exercise1 : IExercise1
    {
        private List<int> _randomlist;

        public List<int> RandomList
        {
            get { return _randomlist; }
            private set { _randomlist = value; }
        }

        public Exercise1()
        {
            InsertNumbersToList();
            Console.WriteLine("Before");
            PrintRandomList();

            Sort(true);
            Console.WriteLine("After ASC");
            PrintRandomList();

            Sort(false);
            Console.WriteLine("After DESC");
            PrintRandomList();

            Console.Write(" Sum of all elements in the list: ");
            PrintSumOfListElements();

        }

        public int AskNumberFromUser()
        {
            int result = 0;
            Console.Write("Give me a number: ");
            result = Convert.ToInt32(Console.ReadLine());
            return (result);
        }

        public List<int> GenerateRandomNumbersFromUserInput(int count)
        {
            int i = 0;
            List<int> result = new List<int>();
            for (int j = 0; j < count; j++)
            {
                i = AskNumberFromUser();
                Random random = new Random();
                result.Add(random.Next(0, Math.Abs(i)));
            }
            return (result);
        }

        public void InsertNumbersToList()
        {
            _randomlist = GenerateRandomNumbersFromUserInput(6);
        }

        public void PrintSumOfListElements()
        {
            int sum = 0;
            foreach (var item in _randomlist)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }

        public void Sort(bool sort)
        {
            _randomlist.Sort();
            if (!sort)
            {
                _randomlist.Reverse();
            }
        }

        private void PrintRandomList()
        {
            foreach (var item in _randomlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
