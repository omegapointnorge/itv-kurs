import { applyMiddleware, createStore } from "redux";

const initialTodosState = { todos: [] };
function todosReducer(state = initialTodosState, action) {
  switch (action.type) {
    case "todos/todoAdded":
      return { ...state, todos: [...state.todos, action.payload] };
    default:
      return state;
  }
}

export function saveNewTodo(text) {
  return async function saveNewTodoThunk(dispatch, getState) {
    const initialTodo = { text };
    const response = await fetch.post("/fakeApi/todos", { todo: initialTodo });
    dispatch({ type: "todos/todoAdded", payload: response.todo });
  };
}

const asyncFunctionMiddleware = (store) => (next) => (action) => {
  // If the "action" is actually a function instead...
  if (typeof action === "function") {
    // then call the function and pass `dispatch` and `getState` as arguments
    return action(store.dispatch, store.getState);
  }

  // Otherwise, it's a normal action - send it onwards in middleware chain. 
  return next(action);
};

const middlewareEnhancer = applyMiddleware(asyncFunctionMiddleware);
const store = createStore(todosReducer, middlewareEnhancer);

store.dispatch(saveNewTodo("Buy milk"));



