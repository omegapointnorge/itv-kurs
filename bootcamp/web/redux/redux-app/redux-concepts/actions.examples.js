// Action
const addTodoAction = {
  type: "todos/todoAdded",
  payload: "Buy milk",
};


// Action Creator
const addTodo = (text) => {
  return {
    type: "todos/todoAdded",
    payload: text,
  };
};

addTodo();
addTodoAction();
