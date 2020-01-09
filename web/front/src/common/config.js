/**
 * @file config
 * @author atom-yang
 */
import AElf from 'aelf-sdk';

const endpoint = 'http://0.0.0.0:1235';
const aelf = new AElf(new AElf.providers.HttpProvider(endpoint));

export default {
  endpoint,
  aelf
};
