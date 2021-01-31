import React from "react";
import { useSelector } from "react-redux";

export function CounterTotal() {
  return (
    <div className="center">
      <header>Total number of clicks</header>
      <div>{useSelector((state) => state.counter.history.length)}</div>
    </div>
  );
}
