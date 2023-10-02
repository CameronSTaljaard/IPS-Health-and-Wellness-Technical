import "../css/nopage.css"
import React, { Component } from 'react';

class NoPage extends Component {
  render (){
    return (
      <div className="nopage__background">
        <div className="nopage__container">
          <div className="nopage__content">
            <h1 id="nopage__header1">Far out!</h1>
            <h2 id="nopage__header2">We're not sure how you got here...</h2>
            <h2 id="nopage__header3">But you may be lost in cyberspace</h2>
            <a href="/">
              <button className="nopage__button">Return Home</button>
            </a>
          </div>
        </div>
      </div>
    )
  };
}
  
  export default NoPage;
  