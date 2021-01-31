import { createSlice } from "@reduxjs/toolkit";

export const counterSlice = createSlice({
  name: "counter",
  initialState: {
    value: 0,
    history: [],
    asyncIncrementInProgress: false,
    asyncIncrementFailed: false,
  },
  reducers: {
    increment: (state) => ({
      ...state,
      value: state.value + 1,
      history: [...state.history, 1],
    }),
    decrement: (state) => ({
      ...state,
      value: state.value - 1,
      history: [...state.history, -1],
    }),
    incrementByAmount: (state, action) => ({
      ...state,
      value: state.value + action.payload,
      history: [...state.history, action.payload],
    }),
    incrementByAmountAsyncStart: (state) => ({ ...state, asyncIncrementInProgress: true, asyncIncrementFailed: false }),
    incrementByAmountAsyncSuccess: (state, action) => ({
      ...state,
      asyncIncrementInProgress: false,
      value: state.value + action.payload,
      history: [...state.history, action.payload],
    }),
    incrementByAmountAsyncFailed: (state, action) => {
      // Redux Toolkit allows us to write "mutating" logic in reducers. It
      // doesn't actually mutate the state because it uses the Immer library,
      // which detects changes to a "draft state" and produces a brand new
      // immutable state based off those changes
      state.asyncIncrementFailed = true;
      state.asyncIncrementInProgress = false;
      state.history.push(`Failure: ${action.payload}`);
    },
  },
});

export const {
  increment,
  decrement,
  incrementByAmount,
  incrementByAmountAsyncStart,
  incrementByAmountAsyncSuccess,
  incrementByAmountAsyncFailed,
} = counterSlice.actions;

// The function below is called a thunk and allows us to perform async logic. It
// can be dispatched like a regular action: `dispatch(incrementAsync(10))`. This
// will call the thunk with the `dispatch` function as the first argument. Async
// code can then be executed and other actions can be dispatched
export const incrementAsync = (amount) => (dispatch) => {
  dispatch(incrementByAmountAsyncStart());
  setTimeout(() => {
    const isSuccess = !!Math.round(Math.random());
    if (isSuccess) {
      dispatch(incrementByAmountAsyncSuccess(amount));
    } else {
      dispatch(incrementByAmountAsyncFailed(amount));
    }
  }, 1000);
};

// The function below is called a selector and allows us to select a value from
// the state. Selectors can also be defined inline where they're used instead of
// in the slice file. For example: `useSelector((state) => state.counter.value)`
export const selectCount = (state) => state.counter.value;
export const selectAsyncIncrementInProgress = (state) => state.counter.asyncIncrementInProgress;
export const selectAsyncIncrementFailed = (state) => state.counter.asyncIncrementFailed;

export default counterSlice.reducer;
