namespace AElf.Contracts.ExchangeContract
{
    /// <summary>
    /// The C# implementation of the contract defined in hello_world_contract.proto that is located in the "protobuf"
    /// folder.
    /// Notice that it inherits from the protobuf generated code. 
    /// </summary>
    public class ExchangeContract : ExchangeContractContainer.ExchangeContractBase
    {
        /// <summary>
        /// The implementation of the Hello method. It takes no parameters and returns on of the custom data types
        /// defined in the protobuf definition file.
        /// </summary>
        /// <param name="input">Empty message (from Protobuf)</param>
        /// <returns>a HelloReturn</returns>
        public override BuyOutput Buy(BuyInput input)
        {
            return new BuyOutput {Value = "Buy!"};
        }

        public override SellOutput Sell(SellInput input)
        {
            return new SellOutput {Value = "Sell!"};
        }
    }
}