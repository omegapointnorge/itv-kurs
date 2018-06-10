import React, { Component } from "react";
import WineInfo from "./WineInfo";
import { connect } from "react-redux";
import { UPDATE_SEARCHED_WINE } from "../../reducers/wines";

class WineContainer extends Component {
  componentDidMount() {
    this.props.dispatch({
      type: UPDATE_SEARCHED_WINE,
      payload: {
        wine: {
          name: "Louis Max Hautes-Côtes de Beaune 2015",
          vintage: "2015",
          country: "Frankrike"
        }
      }
    });
  }

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
        <WineInfo wine={this.props.searchedWine} />

        <hr />
      </div>
    );
  }
}

const mapStateToProps = state => {
  return {
    searchedWine: state.searchedWine
  };
};

export default connect(mapStateToProps)(WineContainer);
