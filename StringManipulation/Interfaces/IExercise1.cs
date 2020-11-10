using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Interfaces
{
    interface IExercise1
    {
        int AskNumberFromUser();
        List<int> GenerateRandomNumbersFromUserInput(int count);
        void InsertNumbersToList();
        void Sort(bool sort);
        void PrintSumOfListElements();
    }
}
