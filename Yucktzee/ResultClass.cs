using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzeemk2
{
    class ResultClass
    {
        int total = new int();
        public int totalofdie(int[] numero)
        {
            
            for(int i = 0; i< 5; i++)
            {
                total += numero[i];
            }
            return total;
        }
         public int threeofakind(int[] numero) 
        {
            
             
             int result = new int();
            if (numero[0] == numero[1] && numero[1] == numero[2] || numero[0] == numero[1] && numero[1] == numero[3] ||
                numero[0] == numero[1] && numero[1] == numero[4] || numero[0] == numero[2] && numero[2] == numero[3] ||
                numero[0] == numero[2] && numero[2] == numero[4] || numero[0] == numero[3] && numero[3] == numero[4] ||
                numero[1] == numero[2] && numero[2] == numero[3] || numero[1] == numero[2] && numero[2] == numero[4] ||
                numero[2] == numero[3] && numero[3] == numero[4] || numero[1] == numero[3] && numero[3] == numero[4])
            {
                result = totalofdie(numero);
            }
            else
                result = 0;
             return result;

        }

        public int fourofakind(int[] numero)
         {

             int result = new int();
             if (numero[1] == numero[2] && numero[2] == numero[3] && numero[3] == numero[4] ||
                numero[0] == numero[1] && numero[1] == numero[2] && numero[2] == numero[3] ||
                numero[0] == numero[1] && numero[1] == numero[3] && numero[3] == numero[4] ||
                numero[0] == numero[2] && numero[2] == numero[3] && numero[3] == numero[4] ||
                numero[0] == numero[1] && numero[1] == numero[2] && numero[2] == numero[4])
             {
                 result = totalofdie(numero);
             }
             else result = 0;
             return result;
         }
        public int fullhouse(int[] numero)
        {
            int result = new int();
            if (numero[0] == numero[1] && numero[1] == numero[2] && numero[3] == numero[4] ||
                numero[0] == numero[1] && numero[1] == numero[3] && numero[2] == numero[4] ||
                numero[0] == numero[1] && numero[1] == numero[4] && numero[2] == numero[3] ||
                numero[0] == numero[2] && numero[2] == numero[3] && numero[1] == numero[4] ||
                numero[0] == numero[2] && numero[2] == numero[4] && numero[1] == numero[3] ||
                numero[0] == numero[3] && numero[3] == numero[4] && numero[1] == numero[2] ||
                numero[1] == numero[2] && numero[2] == numero[3] && numero[0] == numero[4] ||
                numero[1] == numero[2] && numero[2] == numero[4] && numero[0] == numero[3] ||
                numero[2] == numero[3] && numero[3] == numero[4] && numero[0] == numero[1] ||
                numero[1] == numero[3] && numero[3] == numero[4] && numero[0] == numero[2])
            {
                result = 25;
            }
            else result = 0;
            return result;

        }
        public int smallstraight(int[] numero)
        {
            int result = new int();
            Array.Sort(numero);
            if (
                numero[0] == numero[1] && (numero[4] - numero[3]) == 1 && (numero[3] - numero[2]) == 1 && (numero[2] - numero[1]) == 1||
                numero[1] == numero[2] && (numero[4] - numero[3]) == 1 && (numero[3] - numero[1]) == 1 && (numero[1] - numero[0]) == 1||
                numero[2] == numero[3] && (numero[4] - numero[2]) == 1 && (numero[2] - numero[1]) == 1 && (numero[1] - numero[0]) == 1||
                numero[3] == numero[4] && (numero[3] - numero[2]) == 1 && (numero[2] - numero[1]) == 1 && (numero[1] - numero[0]) == 1||
                (numero[4] - numero[3]) == 1 && (numero[3] - numero[2]) == 1 && (numero[2] - numero[1]) == 1 && (numero[1] - numero[0]) ==1 ||
                numero[0] != numero[1] && (numero[4] - numero[3]) == 1 && (numero[3] - numero[2]) == 1 && (numero[2] - numero[1]) == 1||
                numero[4] != numero[3] && (numero[3] - numero[2]) == 1 && (numero[2] - numero[1]) == 1 && (numero[1] - numero[0]) == 1
                )
            {
                result = 30;
            }
            else result = 0;
            return result;
        }

        public int largestraight(int[] numero)
        {
            int result = new int();
            Array.Sort(numero);
            if (
              
                (numero[4] - numero[3]) == 1 && (numero[3] - numero[2]) == 1 && (numero[2] - numero[1]) == 1 && (numero[1] - numero[0]) == 1

                )
            {
                result = 40;
            }
            else result = 0;
            return result;
        }
        public int other(int[] numero)
        {
            int result = new int();
            result = totalofdie(numero);
            return result;
        }
        public int allFive(int[] numero)
        {
            int result = new int();
            if (
                numero[0] == numero[1] && numero[1] == numero[2] && numero[2] == numero[3] && numero[3] == numero[4]
                )
            {
                result = 50;
            }

            else result = 0;
            return result;

        }

        public int faceval(int[] numero, int denom)
        {
            int fvcount = 0;
            int result = new int();

            if (numero[0] == denom) 
            {
                fvcount +=1;
            }
            if (numero[1] == denom)
            {
                fvcount += 1;
            }
            if (numero[2] == denom)
            {
                fvcount += 1;
            }
            if (numero[3] == denom)
            {
                fvcount += 1;
            }
            if (numero[4] == denom)
            {
                fvcount += 1;
            }

            result = denom * fvcount;
            return result;

        }

    }
}
