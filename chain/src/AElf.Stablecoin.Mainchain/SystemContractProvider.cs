using System;
using System.Collections.Generic;
using System.Linq;
using AElf.Contracts.Consensus.AEDPoS;
using AElf.Contracts.Deployer;
using AElf.Contracts.Election;
using AElf.Contracts.MultiToken;
using AElf.Contracts.Profit;
using AElf.Contracts.Vote;

namespace AElf.Stablecoin.MainChain
{
    public class SystemContractProvider : ISystemContractProvider
    {
        public IEnumerable<string> GetSystemContractDllPaths()
        {
            return new List<Type>
            {
                typeof(ProfitContract),
                typeof(VoteContract),
                typeof(ElectionContract),
                typeof(AEDPoSContract),
                typeof(TokenContract),
            }.Select(t => t.Assembly.Location).ToList();
        }
    }
}