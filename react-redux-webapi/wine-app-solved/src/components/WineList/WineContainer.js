import React, { Component } from "react";
import WineInfo from "./WineInfo";
import WineList from "./WineList";

class WineContainer extends Component {
  constructor() {
    super();
    this.state = {
      searchedWine: {
        name: "Louis Max Hautes-Côtes de Beaune 2015",
        vintage: "2015",
        country: "Frankrike"
      }
    };
  }

  componentDidMount() {}

  containerStyle = {
    paddingTop: "10px",
    width: "80%",
    margin: "0 auto",
    display: "flex",
    alignItems: "center",
    justifyContent: "center",
    flexDirection: "column"
  };

  render() {
    return (
      <div style={this.containerStyle}>
        <WineInfo wine={this.state.searchedWine} />

        <hr />

        {/* <WineList>
          <WineInfo wine={this.state.searchedWine} />
          <WineInfo wine={this.state.searchedWine} />
          <WineInfo wine={this.state.searchedWine} />
          <WineInfo wine={this.state.searchedWine} />
          <WineInfo wine={this.state.searchedWine} />
        </WineList> */}
      </div>
    );
  }
}

export default WineContainer;
