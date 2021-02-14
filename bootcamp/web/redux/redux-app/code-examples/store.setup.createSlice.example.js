import { configureStore, createSlice } from "@reduxjs/toolkit";

const counterSlice = createSlice({
  name: "counter",
  initialState: 0,
  reducers: {
    increment: (state) => state + 1,
    decrement: (state) => state - 1,
    incrementBy: (state, action) => state + action.payload,
  },
});

const { increment, decrement, incrementBy } = counterSlice.actions;

const store = configureStore({
  reducer: counterSlice.reducer,
});

store.dispatch(increment());
store.dispatch(decrement());
store.dispatch(incrementBy(2));


