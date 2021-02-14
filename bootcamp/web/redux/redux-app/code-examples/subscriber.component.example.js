import React, { useState } from "react";

import { increment } from "./counterSlice";
import { useDispatch, useSelector } from "react-redux";

export function CounterWithComponentState() {
  const [counter, setCounter] = useState(0);

  const increment = () => {
    setCounter((prevCounter) => prevCounter + 1);
  };

  return (
    <div>
      Value: {counter} <button onClick={increment}>Increment</button>
    </div>
  );
}

export function CounterRedux() {
  const counter = useSelector((state) => state.counter.value);
  const dispatch = useDispatch();

  return (
    <div>
      Value: {counter} <button onClick={() => dispatch(increment())}>Increment</button>
    </div>
  );
}



