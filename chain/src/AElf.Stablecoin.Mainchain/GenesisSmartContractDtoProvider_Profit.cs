using System.Collections.Generic;
using System.Linq;
using Acs0;
using AElf.OS.Node.Application;
using AElf.Types;

namespace AElf.Blockchains.MainChain
{
    public partial class GenesisSmartContractDtoProvider
    {
        public IEnumerable<GenesisSmartContractDto> GetGenesisSmartContractDtosForProfit(Address zeroContractAddress)
        {
            var l = new List<GenesisSmartContractDto>();

            l.AddGenesisSmartContract(
                _codes.Single(kv => kv.Key.Contains("Profit")).Value,
                ProfitSmartContractAddressNameProvider.Name, GenerateProfitInitializationCallList());

            return l;
        }

        private SystemContractDeploymentInput.Types.SystemTransactionMethodCallList
            GenerateProfitInitializationCallList()
        {
            var profitContractMethodCallList =
                new SystemContractDeploymentInput.Types.SystemTransactionMethodCallList();

            return profitContractMethodCallList;
        }
    }
}