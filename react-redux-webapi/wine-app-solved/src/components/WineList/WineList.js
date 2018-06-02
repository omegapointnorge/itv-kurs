import React, { Component } from "react";
import PropTypes from "prop-types";

class WineList extends Component {
  style = {
    margin: "0 auto",
    display: "grid",
    gridTemplateColumns: "auto auto auto",
    gridGap: "50px"
  };

  render() {
    return <div style={this.style}>{this.props.children}</div>;
  }
}

WineList.propTypes = {
  children: PropTypes.array
};

export default WineList;
