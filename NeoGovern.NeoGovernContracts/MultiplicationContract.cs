using Neo.SmartContract.Framework;

namespace NeoGovern.NeoGovernContracts
{
    public class Multiplication : SmartContract
    {
        public static int Main(int a, int b, int c)
        {
            if (a > b)
                return a * Multiply(b, c);
            else
                return Multiply(a, b) * c;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}