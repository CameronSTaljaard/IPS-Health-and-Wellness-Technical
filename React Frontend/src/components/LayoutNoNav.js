import React, { Component } from "react";
import { Outlet } from "react-router-dom";

class LayoutNoNav extends Component {

  render (){
      return (
      <>
      <Outlet />
      </>
      )
  }
}

export default LayoutNoNav;
