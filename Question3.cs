using System;
using System.Collections.Generic;


namespace Question3
{
    class Question3
    {
        static void Main(string[] args){

                triangleArea(2,2,2);
            static void triangleArea(int a,int b,int c){

                int s =(a+b+c)/2;
                object area = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
                Console.WriteLine(Convert.ToString(area));

            }
        }
       
        }


}       
        
        

       

    

