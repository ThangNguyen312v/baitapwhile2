using System;
namespace baitapwhile2{
    class Program{
        static void Main(string[] Args){
            Console.WriteLine("Nhap a:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap b");
            int b = Int32.Parse(Console.ReadLine());

            a = Math.Abs(a);
            b = Math.Abs(b);

            if(a == 0 || b == 0){
                Console.WriteLine("khong co UCLN");
            }
             while (a != b) {
            if (a > b)
                a = a - b;
            else
                b = b - a;
                }
            Console.WriteLine("Greatest common factor: " + a);
            

        }
    }
}
