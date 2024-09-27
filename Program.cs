namespace ClassVsStructPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointClass pointClass1 = new PointClass(10, 20);
            PointClass pointClass2 = pointClass1; 

            pointClass2.X = 30;
            pointClass1.Display(); 
            pointClass2.Display(); 

            
            PointStruct pointStruct1 = new PointStruct(10, 20);
            PointStruct pointStruct2 = pointStruct1; 

            pointStruct2.X = 30;
            pointStruct1.Display(); 
            pointStruct2.Display(); 

            Console.ReadLine();
        }
    }
}
