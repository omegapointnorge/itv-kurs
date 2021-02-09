import React, { useState } from "react";
import { useDispatch, useSelector } from "react-redux";

import styles from "./Counter.module.css";
import { decrement, increment } from "./counterSlice";

export function Counter() {
  const count = useSelector((state) => state.counter.value);
  const dispatch = useDispatch();

  return (
    <div className={styles.counterSection}>
      <div className={styles.row}>
        <button className={styles.button} aria-label="Increment value" onClick={() => dispatch(increment())}>
          +
        </button>
        <span className={styles.value}>{count}</span>
        <button className={styles.button} aria-label="Decrement value" onClick={() => dispatch(decrement())}>
          -
        </button>
      </div>
    </div>
  );
}
