using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
      public static void Main(string[] args)
      {

          byte myByte = 225;

          sbyte mySbyte = -128;

          int myInt = 2147483647;

          uint myUint = 4294967295;

          short myShort = -32768;

          ushort myUShort = 65535;

          float myFloat = -31.1289f;

          double myDouble = -12.1231250;

          char myCharacter = 'A';

          bool myBool = true;

          string myText = "This is myText";

          string numText = "18";
      }

      public static int Text2Num(string numText)
      {
        Int32.TryParse(numText, out int stringInt);
        return stringInt;
        //throw new NotImplementedException();
      }
    }
}
