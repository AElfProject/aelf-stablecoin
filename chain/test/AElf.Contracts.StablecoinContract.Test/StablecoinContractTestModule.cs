using AElf.Contracts.TestKit;
using AElf.Kernel.SmartContract;
using Volo.Abp.Modularity;

namespace AElf.Contracts.StablecoinContract
{
    [DependsOn(typeof(ContractTestModule))]
    public class StablecoinContractTestModule : ContractTestModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<ContractOptions>(o => o.ContractDeploymentAuthorityRequired = false);
        }
    }
}