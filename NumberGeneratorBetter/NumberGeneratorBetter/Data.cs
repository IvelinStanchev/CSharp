using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NumberGenerator
{
    public class Data
    {
        public List<int> numbers = new List<int>();

        public List<int> Numbers { get; set; }

        public void AddNumber(int number)
        {
            this.numbers.Add(number);
        }

        public void ClearList()
        {
            this.numbers = new List<int>();
        }

        public void WriteTheDataInAFile()
        {
            StreamWriter listForWriting = new StreamWriter(@"..\..\Numbers.txt");

            using (listForWriting)
            {
                for (int i = 0; i < this.numbers.Count; i++)
                {
                    listForWriting.WriteLine(numbers[i].ToString());
                }
            }
        }

        public void ClearTheData()
        {
            using (StreamWriter listForWriting = new StreamWriter(@"..\..\Numbers.txt"))
            { 
            }
        }
    }
}
