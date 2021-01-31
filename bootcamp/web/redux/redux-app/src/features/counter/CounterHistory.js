import React from "react";
import { useSelector } from "react-redux";
import styles from "./Counter.module.css";

export function CounterHistory() {
  const history = useSelector((state) => state.counter.history);

  const numberStyles = (value) => {
    if (isNaN(value)) {
      return styles.failure;
    }
    return value > 0 ? styles.positive : styles.negative;
  };

  return (
    <div className={styles.historyList}>
      {history.map((historyElement, index) => (
        <div key={index} className={`${styles.historyElement} ${numberStyles(historyElement)}`}>
          {historyElement}
        </div>
      ))}
    </div>
  );
}
