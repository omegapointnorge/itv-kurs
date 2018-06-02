# React + Redux api interaction
This exercise will give a short example of how a react app can be connected to a web api using axios and redux libraries.

If you are not at all familiar with react and concepts like jsx, props, component state, and component composition, it is recommended to first read the [Quick Start](https://reactjs.org/docs/hello-world.html) article and do the [Intro To React](https://reactjs.org/tutorial/tutorial.html) tutorial, which will provide a good foundation.


## Build wine list application
* Open `wine-app` directory in a terminal and run `yarn start` to run the development server. The app then be browsed at localhost:3000
* The app displays just a single page with a header. We want to connect it to an api serving wine data. The api might be unstable so we want to give the user a feel for what is happening while the data is fetched. 

### WineList component
Start by creating a new react component called `WineContainer` which will hold the data fetched from the API, as well as potential errors etc. 

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

```javascript
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


Next create a `WineInfo` component and move the rendering of the wine info to this new component. The container component should only be responsible for holding the state and render other components. This pattern is used a lot when creating application using react, and will be usefull when we introduce redux later. [Read more](https://reactpatterns.com/#container-component).

The WineContainer components `render`-method should look something like this:

```javascript
render() {
  return (
    <div style={this.containerStyle}>
      <WineInfo wine={this.state.searchedWine} />
      <hr />
    </div>
  );
}
```

