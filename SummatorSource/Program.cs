namespace SummatorSource
{
    public class Summator
    {
        public static int Sum(int[] args) {
            int sum = args[0];    
            for(int i = 1; i < args.Length; i++)
            {
                sum += args[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new int[] {1, 2, 3}));
        }
    }
}