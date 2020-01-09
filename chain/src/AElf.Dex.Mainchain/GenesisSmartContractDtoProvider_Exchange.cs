using System.Collections.Generic;
using System.Linq;
using Acs0;
using AElf.OS.Node.Application;
using AElf.Types;

namespace AElf.Blockchains.MainChain
{
    /* Part of the GenesisSmartContractDtoProvider */
    public partial class GenesisSmartContractDtoProvider
    {
        public IEnumerable<GenesisSmartContractDto> GetGenesisSmartContractDtosForExchange(Address zeroContractAddress)
        {
            var l = new List<GenesisSmartContractDto>();
            l.AddGenesisSmartContract(
                // find the contracts code by name
                _codes.Single(kv => kv.Key.Contains("Exchange")).Value,
                // the name of the contract is built from the full name
                Hash.FromString("AElf.ContractNames.ExchangeContract"),
                new SystemContractDeploymentInput.Types.SystemTransactionMethodCallList());
            return l;
        }
    }
}