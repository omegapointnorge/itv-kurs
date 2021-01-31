import React from "react";
import { Counter } from "./features/counter/Counter";
import { CounterHistory } from "./features/counter/CounterHistory";
import { CounterTotal } from "./features/counter/CounterTotal";
import { CounterAsyncStatus } from "./features/counter/CounterAsyncStatus";
import "./App.css";

function App() {
  return (
    <div className="App">
      <main className="main">
        <Counter />
        <CounterAsyncStatus />
      </main>
      <aside className="sideBar">
        <h2 className="center">History</h2>
        <CounterHistory />
        <CounterTotal />
      </aside>
    </div>
  );
}

export default App;
