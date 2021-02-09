const addTodoAction = {
  type: "todos/todoAdded",
  payload: "Buy milk",
};

const addTodo = (text) => {
  return {
    type: "todos/todoAdded",
    payload: text,
  };
};

addTodo();
addTodoAction();
