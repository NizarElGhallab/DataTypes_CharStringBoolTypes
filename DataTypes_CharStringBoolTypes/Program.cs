using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
            int charMax = char.MaxValue;

            char MyVar = 'G';
            int MyVarValue = 'G';
            char MyVarValue2 = Convert.ToChar(75);
            Console.WriteLine("Min Char = {0} Max char = {1} My Character = {2} My Variable Number = {3} my conversion value is {4}"
                , charMin, charMax, MyVar, MyVarValue, MyVarValue2);

            string myString = "My Value is a Variable";
            Console.WriteLine("\nMy String is {0}", myString);

            bool mybool = true;
            Console.WriteLine("My Boolean Value is {0}", mybool);
           
            Console.ReadKey();
        }
    }
}
