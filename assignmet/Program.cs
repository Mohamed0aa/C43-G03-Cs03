using System.Threading.Channels;

namespace assignmet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 : Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //int n=int.Parse(Console.ReadLine());
            //if(n%3==0 && n%4==0) Console.WriteLine("yes");
            //else Console.WriteLine("no");
            #endregion

            #region q2 : Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //int n = int.Parse(Console.ReadLine());
            //if (n < 0) Console.WriteLine("negative");
            //else Console.WriteLine("positive");
            #endregion

            #region q3 : Write a program that takes 3 integers from the user then prints the max element and the min element.
            //int a=int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int max,min;

            //if (a > b && a>c) max=a;
            //else if (b>a && b> c) max=b;
            //else max=c;

            //if (a <b && a < c) min = a;
            //else if (b < a && b <c) min = b;
            //else min = c;

            //Console.WriteLine($"max element : {max}" + '\n' + $"min element: {min}");

            #endregion

            #region q4 : Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //int n = int.Parse(Console.ReadLine());
            //if (n % 2 == 0) Console.WriteLine("even");
            //else Console.WriteLine("ood");
            #endregion

            #region q5 : Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //char c = char.Parse(Console.ReadLine());
            //if(c=='a' || c == 'u'|| c == 'e' || c == 'I' || c == 'o') Console.WriteLine("vowel");
            //else Console.WriteLine("consonant");
            #endregion

            #region q6 : Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //int n = int.Parse(Console.ReadLine());
            //for(int i=5;i<=n*12;i+=5)
            //    Console.Write(i+" ");
            #endregion

            #region q7: Write a program that takes two integers then prints the power.
            //int n=int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int result=1;
            //for (int i = 1; i <= m; i++)
            //    result *= n;

            //Console.WriteLine(result);
            #endregion

            #region q8 : Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());
            //int n4 = int.Parse(Console.ReadLine());
            //int n5 = int.Parse(Console.ReadLine());
            //int total;
            // double percenrage, avg;
            //total=n1+n2+n3+n4+n5;
            //avg=total/5.0;
            //percenrage=(total/500.0)*100;
            //Console.WriteLine($"total : {total}"+'\n'+$"avrage : {avg}"+'\n'+$"percentage : {percenrage}");
            #endregion

            #region q9 : Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter (x2, y2):");
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter (x3, y3):");
            //double x3 = double.Parse(Console.ReadLine());
            //double y3 = double.Parse(Console.ReadLine());

            //if ((y2 - y1) / (x2 - x1) == (y3 - y2) / (x3 - x2)) Console.WriteLine("these points lie on a single straight line");
            //else Console.WriteLine("NO");
            #endregion
        }
    }
}
