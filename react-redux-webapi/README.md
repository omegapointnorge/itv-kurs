# React + Redux api interaction
This exercise will give a short example of how a react app can be connected to a web api using axios and redux libraries.

If you are not at all familiar with react and concepts like jsx, props, component state, and component composition, it is recommended to first read the [Quick Start](https://reactjs.org/docs/hello-world.html) article and do the [Intro To React](https://reactjs.org/tutorial/tutorial.html) tutorial, which will provide a good foundation. For redx, see [React Redux Tutorial for Beginners](https://www.valentinog.com/blog/react-redux-tutorial-beginners/).


## Running the web application
* Open `wine-app` directory in a terminal and run `yarn start` to run the development server. The app then be browsed at localhost:3000

The `WineContainer` is responsible for holding the data from the redux store and issuing actions to update it, as well as potential errors etc. Container components then renders other 'view'-components. Read more about [container components](https://reactpatterns.com/#container-component).

The container component three sections that are important. It is connected to redux using a library called `react-redux` and the `connect`-method, which defines which parts of the state is interesting for this specific component:

```jsx
const mapStateToProps = state => {
  return {
    searchedWine: state.searchedWine
  };
};

export default connect(mapStateToProps)(WineContainer);
```
This will make the `searchedWine` property available in the props of the component, which is seen used in the `render`-method:

```jsx
render() {
  return (
    <div style={containerStyle}>
      <WineInfo wine={this.props.searchedWine} />
      <hr />
    </div>
  );
}
```

The component issues an action in the `componentDidMount`-lifecycle method, which is a builtin function in all react components, it is called everytime the component is added to the DOM. Read more about [react lifecycle methods](https://reactjs.org/docs/react-component.html#componentdidmount). Have a look at `reducers/wines.js` to see how the reducer populates the state when the action is dispatched.

Install [redux devtools](https://chrome.google.com/webstore/detail/redux-devtools/lmhkpmbekcpmknklioeibfkpmmfibljd?hl=en) in google chrome to see the state and dispatched actions.

Open the app and load the app, you should see the state and dispatched actions. We will use this to vizualize how rexux works. It is also very usefull when the app grows larger, and more actions are involved.


## Fetching data from the wine api
* The app displays a single page with information about a wine. We want to connect it to an api serving wine data. The api might be unstable so we want to give the user a feel for what is happening while the data is fetched. 

Open a new terminal and go to the /wine-api directory and run `dotnet watch run`, then try to fetch from the api by browsing `localhost:5000/api/wine/83502`. Test it a couple of times, yo should notice that it is unstable, sometimes beinga bit slow or simply failing. When consuming the api in our web app we will try to visualize when the api slows down and catch potensial exceptions.

We want our app to call this api rendering a pending message while the call is ongoing and possible errors if it fails. To achieve this we will use a simple library called [redux-thun](https://github.com/reduxjs/redux-thunk). This makes it possible to dispatch a function instead of a pure javascript object as we have seen previously. This can be used to in example first diaptch on action then wait a period before dispatching another. To solve our problem we will dispatch one action setting pending message, then calling the api and finaly dispatching either an action setting the searched wine, or the error from the api.

* Have a look at the `searchWine`-method in `WineContainer`, it dispatches a function from [wines.js](/wine-app/src/reducers/wines.js). This method set a pending flag, before setting some hardcoded values.
* Change this method to call the wines api using the vinmonopoletId from the method parameter. If it fails set a property `errorMessage` and render this instead of the WineInfo component.

> Use [axios](https://github.com/axios/axios) to issue the API-call:
```jsx
axios.get('/user?ID=12345')
  .then(function (response) {
    console.log(response);
  })
  .catch(function (error) {
    console.log(error);
  });
```

* EXTRA: When searching for a new wine, add the previouse searched wines to a 'history' prop, and render these at the bottom of the page.

