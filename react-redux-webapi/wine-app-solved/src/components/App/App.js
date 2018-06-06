import React, { Component } from "react";
import WineContainer from "../WineList/WineContainer";
import { connect } from "react-redux";
import "./App.css";

class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <h1 className="App-title">{this.props.pageTitle}</h1>
        </header>
        <WineContainer />
      </div>
    );
  }
}

const mapStateToProps = state => {
  return {
    pageTitle: state.pageTitle
  };
};

export default connect(mapStateToProps)(App);
