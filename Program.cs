using System;


namespace Sum
{
    public class Program
    {
        const string _sum = "FindSum";
        const string _add = "Add";
        static int _requestsCount;
        static int _size;
        static long[] _array;
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            _size = Convert.ToInt32(line);
            _array = new long[_size];
            string[] temp = Console.ReadLine().Split(' ');
            int count = 0;
            
            foreach (var item in temp)
            {
                _array[count++] = Convert.ToInt64(item);
            }
            line = Console.ReadLine();
            _requestsCount = Convert.ToInt32(line);
        
            while(_requestsCount != 0)
            {
                line = Console.ReadLine();
                temp = line.Split(' ');
                if (temp[0] == _add)
                {
                    _array[Convert.ToInt64(temp[1])] += Convert.ToInt64(temp[2]);
                }
                else
                {
                    long result1 = 0;
                    long result2 = 0;
                   
                    for (int i = 0; i < Convert.ToInt32(temp[2]); i++)
                    {
                        if (i < Convert.ToInt32(temp[1]))
                        result1 += _array[i];
                        result2 += _array[i];
                    }
                    Console.WriteLine(result2 - result1);
                }
                _requestsCount--;
            }
           // results.ForEach(e => Console.WriteLine(e));
        }
    }
}
