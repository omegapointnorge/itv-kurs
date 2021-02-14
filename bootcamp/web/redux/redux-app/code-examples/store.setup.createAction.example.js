import { configureStore, createAction } from "@reduxjs/toolkit";

const increment = createAction("INCREMENT");
const decrement = createAction("DECREMENT");
const incrementBy = createAction("INCREMENTBY");

function counter(state = 0, action) {
  switch (action.type) {
    case increment.type:
      return state + 1;
    case decrement.type:
      return state - 1;
    case incrementBy.type:
      return state + action.payload;
    default:
      return state;
  }
}

const store = configureStore({
  reducer: counter,
});

store.dispatch(increment());
store.dispatch(decrement());
store.dispatch(incrementBy(2));


