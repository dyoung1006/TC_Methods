namespace MathExcercise
{
    class Program
    {
        public int rs;
        static void Main()
        {
            Console.WriteLine("Wee be doing some math");
              
            int resultAdd = Add(10, 20);
            int resultMultiply = Multiply(10, 20);
            int resultParamAdd = ParamAdd(2,4,6);
            int resultParamMultiply =ParamMultiply(2,5,5);

            Console.WriteLine("Hello, here is the ouput:");
            Console.WriteLine($"Addition: \n 10 + 20 = {resultAdd}\n ");
            Console.WriteLine($"Multiplication: \n 10 * 20 = {resultMultiply}\n ");
            Console.WriteLine($"Addition (Parameter): \n 2 + 4 + 6 = {resultParamAdd}\n ");
            Console.WriteLine($"Multiplication (Parameter): \n 2 * 5 * 5= {resultParamMultiply}\n ");

           
        }

        public static int Add(int num1, int numb2)
        { 
            return num1 + numb2; 
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2; 
        }

        public static int ParamAdd(params int[] intArray)
        {
            int paramResult=0;
            foreach (int num in intArray)
            {
                paramResult += num;
            }
            return paramResult;
        }

        public static int ParamMultiply(params int[] multiplyArray) 
        {
            int paramResult =1;
            foreach (int num in multiplyArray) 
            {
                paramResult *= num;
            }
            return paramResult;
        }
    }
}