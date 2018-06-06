import React, { Component } from "react";

class WineInfo extends Component {
  containerStyle = {
    background: "white",
    border: "solid",
    textAlign: "center",
    width: "300px"
  };

  render() {
    const { wine } = this.props;
    return (
      <div style={this.containerStyle}>
        <div>{wine.name}</div>
        <div>{wine.vintage}</div>
        <div>{wine.country}</div>
      </div>
    );
  }
}

export default WineInfo;
