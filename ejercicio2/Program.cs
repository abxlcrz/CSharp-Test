using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {   string[] dias= new string[] {"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo"};
            int[] tempDiarias= new int[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Ingrese la temperatura del dia "+dias[i]);
                string tempInput= Console.ReadLine();
                bool result= Int32.TryParse(tempInput, out int tempConverted); 
                if (result==true){    
                    tempDiarias[i]=tempConverted;
                   
                }
            }
            int suma=0;
            int tempMax=0;
            int tempMin=0;
            int aux=0;
            for (int j=0;j<7; j++)
                { 
                  aux=tempDiarias[0];
                  if(aux>tempDiarias[j]){
                      tempMax=aux;
                  }else
                  {
                      tempMin=aux;
                  }
                  suma=suma+tempDiarias[j];
                    
                }
            double prom= suma/7;
            Console.WriteLine("el promedio de temperatura es de  "+prom+" grados");
            Console.WriteLine("la temperatura mas alta es de "+tempMax);
            Console.WriteLine("la temperatura mas baja es de "+tempMin);

        }
    }
}

