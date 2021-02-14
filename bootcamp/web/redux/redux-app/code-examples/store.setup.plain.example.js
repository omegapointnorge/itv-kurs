import { createStore } from "redux";

const INCREMENT = "INCREMENT";
const DECREMENT = "DECREMENT";
const INCREMENTBYAMOUNT = "INCREMENTBYAMOUNT";

// Action Creator
function increment() {
  return { type: INCREMENT }; //Action
}

// Action Creator
function decrement() {
  return { type: DECREMENT }; //Action
}

// Action Creator
function incrementBy(amount) {
  return { type: INCREMENTBYAMOUNT, payload: amount }; //Action
}

// Reducer
function counter(state = 0, action) {
  switch (action.type) {
    case INCREMENT:
      return state + 1;
    case DECREMENT:
      return state - 1;
    case INCREMENTBYAMOUNT:
      return state + action.payload;
    default:
      return state;
  }
}

//  Register the counter reducer.
var store = createStore(counter);

// Dispatch actions
store.dispatch(increment());
store.dispatch(decrement());
store.dispatch(incrementBy(2));


