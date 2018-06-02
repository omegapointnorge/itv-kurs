import React, { Component } from "react";
import "./App.css";
import WineContainer from "../WineList/WineContainer";

class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <h1 className="App-title">Wine List App</h1>
        </header>
        <WineContainer />
      </div>
    );
  }
}

export default App;
