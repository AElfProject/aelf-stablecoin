/**
 * @file contract list
 * @author atom-yang
 */
import React, { useState, useEffect } from 'react';
import {
  Button
} from 'antd';
import config from '../../../../common/config';
import './index.less';

const Status = () => {
  const [status, setStatus] = useState('');

  const getStatus = () => {
    config.aelf.chain.getChainStatus().then(res => {
      setStatus(res || 'Not connected');
    }).catch(e => {
      console.log(e);
      setStatus(e.message || 'error happened');
    });
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
    </div>
  );
};

export default Status;
