using System.IO;
using System.Linq;
using Acs0;
using AElf.Contracts.TestKit;
using AElf.Cryptography.ECDSA;
using AElf.Kernel;
using AElf.Types;
using Google.Protobuf;
using Volo.Abp.Threading;

namespace AElf.Contracts.StablecoinContract
{
    public class StablecoinContractTestBase : ContractTestBase<StablecoinContractTestModule>
    {
        internal StablecoinContractContainer.StablecoinContractStub StablecoinContractStub { get; set; }
        private ACS0Container.ACS0Stub ZeroContractStub { get; set; }

        private Address StablecoinContractAddress { get; set; }

        protected StablecoinContractTestBase()
        {
            InitializeContracts();
        }

        private void InitializeContracts()
        {
            ZeroContractStub = GetZeroContractStub(SampleECKeyPairs.KeyPairs.First());

            StablecoinContractAddress = AsyncHelper.RunSync(() =>
                ZeroContractStub.DeploySystemSmartContract.SendAsync(
                    new SystemContractDeploymentInput
                    {
                        Category = KernelConstants.CodeCoverageRunnerCategory,
                        Code = ByteString.CopyFrom(File.ReadAllBytes(typeof(StablecoinContract).Assembly.Location)),
                        Name = ProfitSmartContractAddressNameProvider.Name,
                        TransactionMethodCallList =
                            new SystemContractDeploymentInput.Types.SystemTransactionMethodCallList()
                    })).Output;
            StablecoinContractStub = GetStablecoinContractStub(SampleECKeyPairs.KeyPairs.First());
        }

        private ACS0Container.ACS0Stub GetZeroContractStub(ECKeyPair keyPair)
        {
            return GetTester<ACS0Container.ACS0Stub>(ContractZeroAddress, keyPair);
        }

        private StablecoinContractContainer.StablecoinContractStub GetStablecoinContractStub(ECKeyPair keyPair)
        {
            return GetTester<StablecoinContractContainer.StablecoinContractStub>(StablecoinContractAddress, keyPair);
        }
    }
}