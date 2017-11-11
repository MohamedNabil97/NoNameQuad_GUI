using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNameQuad_GUI
{
    class Controller
    {
        private Transmitter trans;
        public Controller(Transmitter x)
        {
            trans = x;
        }
        public void ResetEverything()
        {
            byte[] x = new byte[4];
            x[0] = 0;
            x[1] = 0;
            x[2] = 0;
            x[3] = 0;

            trans.SendArrayByte(x);

        }
        public void MoveServo(byte x, byte y, byte z)
        {
            byte[] arr = new byte[4];
            arr[0] = 1;
            arr[1] = x;
            arr[2] = y;
            arr[3] = z;
            trans.SendArrayByte(arr);


        }
        public void MoveServoIK(byte x, byte y, byte z)
        {
            byte[] arr = new byte[4];
            arr[0] = 2;
            arr[1] = x;
            arr[2] = y;
            arr[3] = z;
            trans.SendArrayByte(arr);


        }

        public void ChangeSpeed(byte x, byte y, byte z)
        {
            byte[] arr = new byte[4];
            arr[0] = 3;
            arr[1] = x;
            arr[2] = y;
            arr[3] = z;
            trans.SendArrayByte(arr);

        }
        public void ChangeLED(byte x, byte y, byte z)
        {
            byte[] arr = new byte[4];
            arr[0] = 4;
            arr[1] = x;
            arr[2] = y;
            arr[3] = z;
            trans.SendArrayByte(arr);
        }
        public void DebugServo(byte x, byte y, byte z)
        {
            byte[] arr = new byte[4];
            arr[0] = 5;
            arr[1] = x;
            arr[2] = y;
            arr[3] = z;
            trans.SendArrayByte(arr);
        }
        public void GetCoordinates(byte x, byte y, byte z)
        {
            byte[] arr = new byte[4];
            arr[0] = 42;
            arr[1] = x;
            arr[2] = y;
            arr[3] = z;
            trans.SendArrayByte(arr);

        }
        public void Sit(byte x, byte y, byte z)
        {
            byte[] arr = new byte[4];
            arr[0] = 7;
            arr[1] = x;
            arr[2] = y;
            arr[3] = z;
            trans.SendArrayByte(arr);
        }
        public void Stand(byte x, byte y, byte z)
        {
            byte[] arr = new byte[4];
            arr[0] = 8;
            arr[1] = x;
            arr[2] = y;
            arr[3] = z;
            trans.SendArrayByte(arr);

        }
        public void RotateRobot(byte x, byte y, byte z)
        {
            byte[] arr = new byte[4];
            arr[0] = 9;
            arr[1] = x;
            arr[2] = y;
            arr[3] = z;
            trans.SendArrayByte(arr);
        }
        public void Wiggle(byte x, byte y, byte z)
        {
            byte[] arr = new byte[4];
            arr[0] = 10;
            arr[1] = x;
            arr[2] = y;
            arr[3] = z;
            trans.SendArrayByte(arr);
        }

    }
}
