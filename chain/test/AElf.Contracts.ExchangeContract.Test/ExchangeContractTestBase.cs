using System.IO;
using System.Linq;
using Acs0;
using AElf.Contracts.TestKit;
using AElf.Cryptography.ECDSA;
using AElf.Kernel;
using AElf.Types;
using Google.Protobuf;
using Volo.Abp.Threading;

namespace AElf.Contracts.ExchangeContract
{
    public class ExchangeContractTestBase : ContractTestBase<ExchangeContractTestModule>
    {
        internal ExchangeContractContainer.ExchangeContractStub ExchangeContractStub { get; set; }
        private ACS0Container.ACS0Stub ZeroContractStub { get; set; }

        private Address ExchangeContractAddress { get; set; }

        protected ExchangeContractTestBase()
        {
            InitializeContracts();
        }

        private void InitializeContracts()
        {
            ZeroContractStub = GetZeroContractStub(SampleECKeyPairs.KeyPairs.First());

            ExchangeContractAddress = AsyncHelper.RunSync(() =>
                ZeroContractStub.DeploySystemSmartContract.SendAsync(
                    new SystemContractDeploymentInput
                    {
                        Category = KernelConstants.CodeCoverageRunnerCategory,
                        Code = ByteString.CopyFrom(File.ReadAllBytes(typeof(ExchangeContract).Assembly.Location)),
                        Name = ProfitSmartContractAddressNameProvider.Name,
                        TransactionMethodCallList =
                            new SystemContractDeploymentInput.Types.SystemTransactionMethodCallList()
                    })).Output;
            ExchangeContractStub = GetExchangeContractStub(SampleECKeyPairs.KeyPairs.First());
        }

        private ACS0Container.ACS0Stub GetZeroContractStub(ECKeyPair keyPair)
        {
            return GetTester<ACS0Container.ACS0Stub>(ContractZeroAddress, keyPair);
        }

        private ExchangeContractContainer.ExchangeContractStub GetExchangeContractStub(ECKeyPair keyPair)
        {
            return GetTester<ExchangeContractContainer.ExchangeContractStub>(ExchangeContractAddress, keyPair);
        }
    }
}