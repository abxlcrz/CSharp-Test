using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("ingrese un numero");
            string numberInput= Console.ReadLine();
            bool result= Int32.TryParse(numberInput, out int numberConverted); 
                if (result==true){
                    
                    int suma =0;
                    for (int i=0; i <numberConverted; i++) {
                      int k=i;
                      suma=suma+k;
                     
                    }
                    Console.WriteLine("la suma total es "+suma);

                }

            
        }
    }
}
