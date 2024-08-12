using System;
using System.Xml;


namespace TongCacPhanTuCuaMang
{
    class Program
    {
        static void Main (string[]args)
        {
            int quantityArray;
            int i;
            Console.Write("Nhap so luong phan tu cua mang: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(),out quantityArray)&& quantityArray>0)
                {
                    break;
                }
                else
                {
                    Console.Write("Nhap lai so luong phan tu cua mang: ");
                }
            }
            

            int [] myArray= new int [quantityArray];
            for (i=0;i<quantityArray;i++)
            {
                Console.Write("Nhap vao phan tu thu [{0}]: ", i);
                while(true)
                {
                    if (int.TryParse(Console.ReadLine(),out myArray[i]))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Nhap lai phan tu thu [{0}]: ", i);
                    }
                }
            }
            Console.Write("Ta co mang vua nhap vao la: ");
            foreach(int num in myArray)
            {
                Console.Write("{0,5}", num);
            }
            int sumNumber=0;
            foreach(int num in myArray)
            {
                sumNumber += num;
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("Tong gia tri cac phan tu trong mang la: "+ sumNumber);
            Console.ReadKey();
            
        }
    }
}
