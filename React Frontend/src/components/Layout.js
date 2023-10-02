import Navbar from "./Navbar";
import React, { Component } from "react";
import { Outlet } from "react-router-dom";

class Layout extends Component {

  render (){
      return (
      <>
      {/* Nothing would render if a single element was not added. */}
      <p style={{visibility: "hidden"}}>?</p>
      <Navbar /> 
      <Outlet />
      </>
      )
  }
}

export default Layout;
