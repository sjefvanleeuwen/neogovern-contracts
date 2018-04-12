using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Neo.VM;

namespace NeoGovern.NeonGovernContractsTests
{
    [TestClass]
    public class ContractTests
    {
        [TestMethod]
        public void ShouldReturn24WhenMultiplationOf3Times4Times2()
        {
            const string abi = "압汫歶刀쑺癬八穒泄歶剒쑺污歶쌀癬八ꃃ癬卫穒泄歶썓≤氀歶쌀癬八泃歶썒籡㙥销癬呫穒拄\"癬k泃歶썑籡ᱥ氀歶썒沕歶剔쑺͢氀歶썔污晵앓汫歶刀쑺癬八穒懄癬k泃歶썑沕歶剒쑺͢氀歶썒污晵";

            var engine = new ExecutionEngine(null, null);
            engine.LoadScript(Encoding.Unicode.GetBytes(abi));

            using (var sb = new ScriptBuilder())
            {
                int[] parameter = { 3, 4, 2 };
                parameter.Reverse().ToList().ForEach(p => sb.EmitPush(p));
                engine.LoadScript(sb.ToArray());
            }
            // Execute 3 * 4 * 2
            engine.Execute();
            var result = engine.EvaluationStack.Peek().GetBigInteger();
            Assert.IsTrue(result == 24);
        }
    }
}
