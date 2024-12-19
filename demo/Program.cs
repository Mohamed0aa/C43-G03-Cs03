using System.Diagnostics;
using System.Threading.Channels;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region implecit_casting (save castion)
            // put small data in big container
            //int x = 4;
            //long y =(long) x;
            //Console.WriteLine(y);
            #endregion
            #region explicit_casting(un saved casting)
            ////put big data in small container
            //long x = 1010110101010;
            //int y = (int)x;//=>cant save data over his capaciy
            #endregion
            #region parse(convert from string to any another data type
            //Console.WriteLine("enter_name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("enter_age");
            //int age=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter_salary");
            //double ss=double.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"name :{name}"+'\n'+$"age :{age}"+ '\n'+$"salary :{ss}");
            #endregion
            #region convert (from any to any)
            //Console.WriteLine("enter_name: ");
            //string name1 = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("enter_age");
            //int age1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter_salary");
            //double ss1 =Convert.ToDouble(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"name :{name1}" + '\n' + $"age :{age1}" + '\n' + $"salary :{ss1}");
            #endregion
            #region operator
            #region unary region
            //int x = 5;
            //x++; //postfix
            //++x; //prefix
            //x--;//incerement
            //--x;//decrement
            #endregion
            #region binary
            //+,-,*,/,%
            #endregion
            #region  assignment
            //+=,-=,*=,/=
            //do and assign
            #endregion
            #region relational
            //>,<,==,!= =>comparison
            #endregion
            #region logical (short_circute)
            //&&,||,!
            //first cheeck on first condition and cheeck on second if you need
            #endregion
            #region bitwise [long circute]
            //&,|,^
            // cheeck on first condition (and) cheeck on second 
            #endregion
            #region ternary
            //int x = 4;
            //string mo = x != 4 ? "false" : "true";
            //Console.WriteLine(mo);
            #endregion
            #region operator priority
            //1=perfix
            //2=()
            //3=*,/,%
            //4= +,-
            #endregion
            #endregion
            #region string_formate
            //string is imutable data type canr edite on it
            //to solve it use
            //1.comosite_formate:
            //string q="dvdf", w= "dvdf", e= "dvdf";
            //string mo =string.Format("he {1 } play with {2} and {3}",q,w,e);
            //2.string interpulation
            /*use($)*/
            #endregion
            #region if/switch
            /*if(condition){}
             * else if(condition)
             * else
             */
            /*
             * switch(varible_testing)
             * {
             *  case (condition):
             * }
             * make jumping with numerical data 
             * make jumping with non_numerical data  if cases number >5
             */
            #endregion
            #region go to
            //prevent redunducy of code in switch
            #endregion
            #region evaluation of switch
            #region c#6
            /* do Condition on switch
             * 
             * case>30
             * case<30
             */
            //not allow to && and or
            #endregion
            #region c#7
            /*
             * 1-cheeck on type of data 
             *case type + (varible name=>put it in this varible):
             
            2- when (extra option) allow &&  or 
             */
            #endregion
            #region c#8
            #region EX01
            //int x = 5;
            //string Massege = x switch
            //{
            // //(constant_patern)   1 => "mo",
            //    2=>"mo2",
            //    _=>"mooooo"  //(descard_patern)
            //};
            //Console.WriteLine(Massege);
            #endregion
            #region EX02

            //Empolyee E01 = new Empolyee();

            //E01.Name = "But";
            //E01.Id = 10;
            //E01.Age = 22;
            ////propirty pattern cheeck on correct of property
            //string Massege = E01 switch
            //{
            //    { Id: 10, Name: "Alaa", Age: 22 } => $"{E01.Id} : {E01.Name} :{E01.Age} ",
            //  { Id: 10, Name: "Ali", Age: 22 } => $"{ E01.Id } : { E01.Name } :{ E01.Age }"
            //};
            #endregion
            #endregion
            #region c#9
            //alllow  relational and logical operator
            //{ Id:  >5 && <12 , Name: "Alaa", Age: 22 } => $"{E01.Id} : {E01.Name} :{E01.Age}
            #endregion
            #endregion


        }
    }
}
