# React + Redux api interaction
This exercise will give a short example of how a react app can be connected to a web api using axios and redux libraries.

If you are not at all familiar with react and concepts like jsx, props, component state, and component composition, it is recommended to first read the [Quick Start](https://reactjs.org/docs/hello-world.html) article and do the [Intro To React](https://reactjs.org/tutorial/tutorial.html) tutorial, which will provide a good foundation. For redx, see [React Redux Tutorial for Beginners](https://www.valentinog.com/blog/react-redux-tutorial-beginners/).


## Running the application
* Open `wine-app` directory in a terminal and run `yarn start` to run the development server. The app then be browsed at localhost:3000
* The app displays a single page with information about a wine. We want to connect it to an api serving wine data. The api might be unstable so we want to give the user a feel for what is happening while the data is fetched. 

## Fetching data from the wine api
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

The component issues an action in the `componentDidMount`-lifecycle method, which is a builtin function in all react components, it is called everytime the component is added to the DOM. Read more about [react lifecycle methods](https://reactjs.org/docs/react-component.html#componentdidmount).








