/**
 * @file contract list
 * @author atom-yang
 */
import React, { useState, useEffect } from 'react';
import {
  Button
} from 'antd';
import config from '../../../../common/config';
import getMainContract from '../../../../common/mainContract';
import './index.less';

// address: 2hxkDg6Pd2d4yU1A16PTZVMMrEDYEPR8oQojMDwWdax5LsBaxX
const defaultPrivateKey = 'bdb3b39ef4cd18c2697a920eb6d9e8c3cf1a930570beb37d04fb52400092c42b';

const Status = () => {
  const [status, setStatus] = useState('');

  const getStatus = () => {
    config.aelf.chain.getChainStatus().then(res => {
      setStatus(JSON.stringify(res || 'Not connected'));
    }).catch(e => {
      console.log(e);
      setStatus(e.message || 'error happened');
    });
  };

  const hello = async () => {
    const mainContract = await getMainContract(defaultPrivateKey);
    if (!mainContract) {
      setStatus('Not connected');
      return;
    }
    const txid = await mainContract.Hello();
    setStatus((txid && txid.TransactionId) || 'Not connected');
  };


  useEffect(() => {
    getStatus();
  }, []);

  return (
    <div className="status">
      Hello world
      <pre>
        {status}
      </pre>
      <Button onClick={getStatus}>refresh</Button>
      &nbsp;
      <Button onClick={hello}>Hello</Button>
    </div>
  );
};

export default Status;
