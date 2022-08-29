import * as React from 'react';
import { Layout } from 'antd';
import './index.less';
const Footer = () => {
  
  return (
    <Layout.Footer className={'footer'} style={{ textAlign: 'center' }}>
      Nguyen Ngoc Thien - Pham Van Manh Hung <a href="https://github.com/ngocthien2306/Social-Media-Microservices">Github Page</a>
    </Layout.Footer>
  );
};
export default Footer;
