import React, { Component } from "react";

class WineInfo extends Component {
  render() {
    const { wine } = this.props;
    if (!wine) return null;

    return (
      <div style={this.containerStyle}>
        <div>{wine.name}</div>
        <div>{wine.vintage}</div>
        <div>{wine.country}</div>
      </div>
    );
  }

  containerStyle = {
    background: "white",
    border: "solid",
    textAlign: "center",
    width: "300px"
  };
}

export default WineInfo;
