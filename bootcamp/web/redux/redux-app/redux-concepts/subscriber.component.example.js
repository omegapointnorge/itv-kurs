import React from "react";

import { decrement, increment } from "./counterSlice";
import { useDispatch, useSelector } from "react-redux";

export function Counter() {
  const currentValue = useSelector((state) => state.counter.value);
  const dispatch = useDispatch();

  return (
    <div>
      <div>Current value is {currentValue}</div>
      <div>
        <button onClick={() => dispatch(increment())}>+</button>
        <button onClick={() => dispatch(decrement())}>-</button>
      </div>
    </div>
  );
}
