/**
 * @file config
 * @author atom-yang
 */
import AElf from 'aelf-sdk';

const endpoint = 'http://192.168.199.156:1235';
const aelf = new AElf(new AElf.providers.HttpProvider(endpoint));
const mainContractName = 'AElf.ContractNames.StablecoinContract';

export default {
  endpoint,
  aelf,
  mainContractName
};
