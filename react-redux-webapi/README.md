# React + Redux api interaction
This exercise will give a short example of how a react app can be connected to a web api using axios and redux libraries.

If you are not at all familiar with react and concepts like jsx, props, component state, and component composition, it is recommended to first read the [Quick Start](https://reactjs.org/docs/hello-world.html) article and do the [Intro To React](https://reactjs.org/tutorial/tutorial.html) tutorial, which will provide a good foundation.


## Build wine list application
* Open `wine-app` directory in a terminal and run `yarn start` to run the development server. The app then be browsed at localhost:3000
* The app displays just a single page with a header. We want to connect it to an api serving wine data. The api might be unstable so we want to give the user a feel for what is happening while the data is fetched. 

### WineContainer component
Start by creating a new react component called `WineContainer` which will hold the data fetched from the API, as well as potential errors etc. 
The container component should only be responsible for holding the state and render other components. This pattern is used a lot when creating application using react, and will be usefull when we introduce redux later. [Read more](https://reactpatterns.com/#container-component).

Start with setting state in the constructor of the component, e.g. creating a 'searchedWine' property which we can populate with info about a wine. Start by hardcoding some values. Then render the info about the wine in the `render`-method of the component.

```javascript
constructor() {
  super();
  this.state = {
    searchedWine: {
      name: "Louis Max Hautes-Côtes de Beaune 2015",
      vintage: "2015",
      country: "Frankrike"
    }
  };
}
```

```jsx
render() {
  return (
    <div>
      <div>{this.state.wine.name}</div>
      <div>{this.state.wine.vintage}</div>
      <div>{this.state.wine.country}</div>
    </div>
  );
}
```

Check that the app render correctly in the browser, without errors.
Next create a `WineInfo` component and move the rendering of the wine info to this new component. 

The WineContainer components `render`-method should look something like this:

```jsx
render() {
  return (
    <div style={this.containerStyle}>
      <WineInfo wine={this.state.searchedWine} />
      <hr />
    </div>
  );
}
```

##Adding Redux
Instead of having the state of the application directly in the react container component we will use a immutable state container (redux). Have a look at [Redux Basics](https://redux.js.org/basics) for an introduction to redux.

Go to `index.js` in src-directory, and wrap the `<App />` component in a provider component from react-redux.

```jsx
import React from "react";
import ReactDOM from "react-dom";
import "./index.css";
import App from "./components/App/App";
import { Provider } from "react-redux";
import { createStore } from "redux";

const initialState = {
  pageTitle: "Wine App"
};

const store = createStore(() => initialState, initialState);

ReactDOM.render(
  <Provider store={store}>
    <App />
  </Provider>,
  document.getElementById("root")
);
``` 

This makes the redux state object available. Next we want to connect our react components to the redux state object. Go back to the `App`-component and connect it to redux.

The `connect`-function takes a function as parameter which maps from state to a new object that will be the `props` of the component.

```jsx
import { connect } from "./react-redux";

{/*.......*/}

const mapStateToProps = state => {
  return {
    title: state.pageTitle
  };
};

export default connect(mapStateToProps)(App);
```

Replace the title with this props. It should be accessible through `this.props.pageTitle`. 

##Reducers
The state in redux is never mutated, only changed through "actions" which are instructions about what to change. The action will be passed together with the current state to a "reducer" - a pure function that returns the new state of the application. 

We will move the searched wine property to redux as well. 

Start by creating a folder for the reducers, ext to the components folder, and create a file named `wines.js` with the following content:

```jsx
export const UPDATE_SEARCHED_WINE = "wines/UPDATE_SEARCHED_WINE";

const initialState = { searchedWine: {} };

export default (state = initialState, action) => {
  switch (action.type) {
    case UPDATE_SEARCHED_WINE:
      return {
        ...state,
        searchedWine: action.payload.wine
      };
    default:
      return initialState;
  }
};
```

Broken down, the reducer is a simple function transforming the current state using the given action. In this example the action updates the `searchedWine` property with the wine given in the action. Actions can be any plain javascript object, but typically includes a type and a payload as the one above. The first line above is the action-type, which must be used by the components wanting to update the state.

The `WineContainer`-component should emit this action to update the searchedWine property. Start by connecting the component to redux as previously done in `App`-component:

```jsx
// .....

const mapStateToProps = state => {
  return {
    searchedWine: state.searchedWine
  };
};

export default connect(mapStateToProps)(WineContainer);
```

The app will display nothing, since the state is empty, as we have not sent any actions yet. Actions are issued using a function named `dispatch` which is available in all redux-connected components. WineContainer should send a `UPDATE_SEARCHED_WINE`-action when loaded - use the `componentDidMount` lifecycle function.

```jsx
class WineContainer extends Component {
  componentDidMount() {
    this.props.dispatch({
      type: UPDATE_SEARCHED_WINE,
      payload: {
        wine: {
          name: "Louis Max Hautes-Côtes de Beaune 2015",
          vintage: "2015",
          country: "Frankrike"
        }
      }
    });
  }

  //....

}
```

Now the app should display the wine properties as before.


## Fetching data from the wine api




