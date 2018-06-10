import React from "react";
import ReactDOM from "react-dom";
import "./index.css";
import App from "./components/App/App";
import { Provider } from "react-redux";
import { createStore } from "redux";
import winesReducer from "./reducers/wines";
import ReduxChart from "./components/DevTools/ReduxChart";

const store = createStore(winesReducer);

ReactDOM.render(
  <Provider store={store}>
    <App />
    <ReduxChart />
  </Provider>,
  document.getElementById("root")
);
