import React, { Component } from "react";
import WineContainer from "../WineList/WineContainer";
import "./App.css";

class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <h1 className="App-title">Wine App</h1>
        </header>
        <WineContainer />
      </div>
    );
  }
}

export default App;
