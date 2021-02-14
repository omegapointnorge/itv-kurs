const initialCounterState = { value: 0 };

function counterReducer(state = initialCounterState, action) {
  switch (action.type) {
    case "counter/increment":
      return { ...state, value: state.value + 1 };
    default:
      return state;
  }
}

const initialTodoState = { todos: [] };

function todoReducer(state = initialTodoState, action) {
  switch (action.type) {
    case "todos/addTodo":
      return { ...state, todos: [...state.todos, action.payload] };
    default:
      return state;
  }
}

counterReducer();
todoReducer();
