import AElf from 'aelf-sdk';
import config from './config';

const Wallet = AElf.wallet;
const { sha256 } = AElf.utils;

const {
  aelf,
  dexContractName
} = config;

const dexInstance = {};
// let alertLock = false;
export default async function getDexContract(privateKey) {
  if (dexInstance.privateKey) {
    return dexInstance.privateKey;
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

  const dexContractAddress = await zeroC.GetContractAddressByName.call(sha256(dexContractName));

  const dexContract = await aelf.chain.contractAt(dexContractAddress, wallet);

  dexInstance.privateKey = dexContract;
  return dexInstance.privateKey;
}
