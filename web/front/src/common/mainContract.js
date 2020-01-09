import AElf from 'aelf-sdk';
import config from './config';

const Wallet = AElf.wallet;
const { sha256 } = AElf.utils;

const {
  aelf,
  mainContractName
} = config;

let contractInstance;
// let alertLock = false;
export default async function getMainContract(privateKey) {
  if (contractInstance) {
    return contractInstance;
  }

  const wallet = Wallet.getWalletByPrivateKey(privateKey);

  if (!aelf.isConnected()) {
    // alert('Blockchain Node is not running.');
    return false;
  }

  const chainStatus = await aelf.chain.getChainStatus();
  const {
    // directly accessible information
    GenesisContractAddress
  } = chainStatus;

  const zeroC = await aelf.chain.contractAt(GenesisContractAddress, wallet);

  const contractAddress = await zeroC.GetContractAddressByName.call(sha256(mainContractName));

  const contract = await aelf.chain.contractAt(contractAddress, wallet);

  contractInstance = contract;
  return contractInstance;
}
