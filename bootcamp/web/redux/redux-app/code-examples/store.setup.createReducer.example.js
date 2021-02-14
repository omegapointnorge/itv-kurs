import { configureStore, createAction, createReducer } 
from "@reduxjs/toolkit";

const increment = createAction("INCREMENT");
const decrement = createAction("DECREMENT");
const incrementBy = createAction("INCREMENTBY");

const counter = createReducer(0, {
  [increment]: (state) => state + 1,
  [decrement]: (state) => state - 1,
  [incrementBy]: (state, action) => state + action.payload,
});

const store = configureStore({
  reducer: counter,
});

store.dispatch(increment());
store.dispatch(decrement());
store.dispatch(incrementBy(2));



