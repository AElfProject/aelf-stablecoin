using System.Threading.Tasks;
using AElf.Types;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Shouldly;
using Xunit;

namespace AElf.Contracts.StablecoinContract
{
    public class StablecoinContractTest : StablecoinContractTestBase
    {
        [Fact]
        public async Task HelloCall_ReturnsStablecoinMessage()
        {
            var txResult = await StablecoinContractStub.Hello.SendAsync(new Empty());
            txResult.TransactionResult.Status.ShouldBe(TransactionResultStatus.Mined);
            var text = new HelloReturn();
            text.MergeFrom(txResult.TransactionResult.ReturnValue);
            text.Value.ShouldBe("Hello!");
        }
    }
}