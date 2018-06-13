import React, { Component } from "react";
import WineInfo from "./WineInfo";
import SearchForm from "./SearchForm";
import { connect } from "react-redux";
import { updateSearchedWine } from "../../reducers/wines";

class WineContainer extends Component {
  constructor(props) {
    super(props);
    this.searchWine = this.searchWine.bind(this);
  }

  searchWine(vinmonopoletId) {
    console.log(vinmonopoletId);
    this.props.dispatch(updateSearchedWine(vinmonopoletId));
  }

  render() {
    return (
      <div style={containerStyle}>
        <SearchForm buttonClicked={this.searchWine} />
        <br />
        {this.props.isFetching ? "request pending...." : null}
        {this.props.errorMesage ? "ERROR" : null}
        <br />
        <WineInfo wine={this.props.searchedWine} />
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
    searchedWine: state.searchedWine,
    isFetching: state.isFetching,
    errorMesage: state.errorMessage
  };
};

export default connect(mapStateToProps)(WineContainer);
