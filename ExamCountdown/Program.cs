class ExamCountdown 
{
    public static void Main(string[] args)
    {
        int d = int.Parse(Console.ReadLine());
     

        for (int i = d; i >=1; i-=1) 
        {
            Console.WriteLine($"{i} days before the exam",i);
        }
       
        Console.WriteLine("The exam has come");
    }
    
}