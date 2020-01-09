using System.Threading.Tasks;
using AElf.Types;
using Google.Protobuf;
using Shouldly;
using Xunit;

namespace AElf.Contracts.ExchangeContract
{
    public class ExchangeContractTest : ExchangeContractTestBase
    {
        [Fact]
        public async Task BuyCall_ReturnsExchangeMessage()
        {
            var txResult = await ExchangeContractStub.Buy.SendAsync(new BuyInput {Value = "Buy?"});
            txResult.TransactionResult.Status.ShouldBe(TransactionResultStatus.Mined);
            var text = new BuyOutput();
            text.MergeFrom(txResult.TransactionResult.ReturnValue);
            text.Value.ShouldBe("Buy!");
        }

        [Fact]
        public async Task SellCall_ReturnsExchangeMessage()
        {
            var txResult = await ExchangeContractStub.Sell.SendAsync(new SellInput {Value = "Sell?"});
            txResult.TransactionResult.Status.ShouldBe(TransactionResultStatus.Mined);
            var text = new SellOutput();
            text.MergeFrom(txResult.TransactionResult.ReturnValue);
            text.Value.ShouldBe("Sell!");
        }
    }
}