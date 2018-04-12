using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

namespace NeoGovern.NeoGovernContracts
{
    public class Contract1 : SmartContract
    {
        public static void Main()
        {
            Storage.Put(Storage.CurrentContext, "Hello", "World");
        }
    }
}
