import React, { Component } from "react";
import "../css/navbar.css";
import { Link, Outlet } from "react-router-dom";

const linkStyle = {
  textDecoration: "none",
  color: 'white'
}

class Navbar extends Component {

    render (){
        return(
            <header className='navbar'>
                <Link to="/" className='navbar__title navbar__item' style={linkStyle}>
                    IPS-Marketplace
                </Link>
                <Link to="/contact" className='navbar__item' style={linkStyle}>
                    Contact
                </Link>
                <Link to="/404" className='navbar__item' style={linkStyle}>
                    404
                </Link>
            </header>
        )
    }
};

export default Navbar;