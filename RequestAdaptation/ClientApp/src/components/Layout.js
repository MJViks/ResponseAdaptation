import React, { Component } from 'react';
import { NavMenu } from './NavMenu';
import { Foter } from './Foter';
import './Home.css';

export class Layout extends Component {
    displayName = Layout.name

 

    backHide = () => {
        if (document.getElementById('layout').scrollTop > 850) 
          
            document.getElementsByClassName('home-first-deep-back')[0].style.display = 'none'
            else
            document.getElementsByClassName('home-first-deep-back')[0].style.display = ''
        
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
