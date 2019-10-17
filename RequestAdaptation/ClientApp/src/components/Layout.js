import React, { Component } from 'react';
import { NavMenu } from './NavMenu';
import { Foter } from './Foter';
import './Layout.css';

export class Layout extends Component {
    displayName = Layout.name
    backHide = () => {
        let st = document.getElementById('layout').scrollTop,
            ct = document.body.clientHeight,
            HFDB = document.getElementsByClassName('home-deep-back');
        for (let i = 0; i < HFDB.length; i++) {
            let dotOfEnd = HFDB[i].getBoundingClientRect().x + ct 
            if (st >= dotOfEnd) {
                HFDB[i].style.display = 'none'
            }
            else
                HFDB[i].style.display = ''
        }
    }

  render() {
      return (
          <div >
              <div onScroll={this.backHide} id="layout" className="parallax">
              {this.props.children}
              <Foter />
              </div>
              <NavMenu />
      </div>
    );
  }
}
