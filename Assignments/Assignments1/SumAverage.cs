namespace Assignment
{
    class SumAvg
    {
        public static void Main(string[] args)
        {
            double sum=0, avg=0;
            Console.WriteLine("How many number you want to enter?");
            int n = Int32.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                sum = sum + numbers[i];
            }

            avg = sum / numbers.Length;
            Console.WriteLine($"The sum of numbers is : {sum} and Average is : {avg}.");
        }

        //public void  SumAverage(params int[] values)
        //{
        //    decimal sum = 0;
        //    decimal avg = 0;
        //    foreach (var value in values)
        //    {
        //        sum += value;
        //    }
        //    avg = sum / values.Length;
        //    Console.WriteLine($"The sum of numbers is {sum} and Average is {avg}");

        //}
    }
}
