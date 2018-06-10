import React, { Component } from "react";
import WineInfo from "./WineInfo";
import { connect } from "react-redux";
import { updateSearchedWine } from "../../reducers/wines";

class WineContainer extends Component {
  componentDidMount() {
    this.props.dispatch(updateSearchedWine());
  }

  render() {
    return (
      <div style={containerStyle}>
        <WineInfo wine={this.props.searchedWine} />
        <hr />
      </div>
    );
  }
}

const containerStyle = {
  paddingTop: "10px",
  width: "80%",
  margin: "0 auto",
  display: "flex",
  alignItems: "center",
  justifyContent: "center",
  flexDirection: "column"
};

const mapStateToProps = state => {
  return {
    searchedWine: state.searchedWine
  };
};

export default connect(mapStateToProps)(WineContainer);
