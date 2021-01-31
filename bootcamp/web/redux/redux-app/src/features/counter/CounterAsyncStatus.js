import React, { useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import { selectCount, selectAsyncIncrementFailed, selectAsyncIncrementInProgress } from "./counterSlice";
import styles from "./Counter.module.css";

export function CounterAsyncStatus() {
  const failedToIncrement = useSelector(selectAsyncIncrementFailed);
  const asyncIncrementInProgress = useSelector(selectAsyncIncrementInProgress);

  return (
    <>
      {asyncIncrementInProgress && (
        <div className={styles.row}>
          <div className={styles.progress}> Increment in progress</div>
        </div>
      )}

      {failedToIncrement && (
        <div className={styles.row}>
          <div className={styles.warning}> Attempt to add amount failed</div>
        </div>
      )}
    </>
  );
}
