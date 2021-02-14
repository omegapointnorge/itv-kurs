const store = {
  dispatch: function () {},
};

const addTodo = (text) => {
  return {
    type: "todos/todoAdded",
    payload: text,
  };
};

store.dispatch(addTodo("Buy milk"));

console.log(store.getState());
