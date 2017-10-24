using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNameQuad_GUI
{
    class STL
    {
        

            public static string Reverse( string s )
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse( charArray );
                return new string( charArray );
            }



    }
    class Signal
    {
        static public string Servo_Move(int leg, int servo, int angle)
        {
            string x;
            x = "SM ";
            x += leg;
            x += " ";
            x += servo;
            x += " ";
            x += angle;


           // Console.WriteLine(x);
            return x;

        }
        static public string Inverse_Kinematic(int leg, int x, int y,int z)
        {
            string s;
            s = "IK ";
            s += leg;
            s += " ";
            s += x;
            s += " ";
            s += y;
            s += " ";
            s += z;

            // Console.WriteLine(x);
            return s;

        }
    }
}
