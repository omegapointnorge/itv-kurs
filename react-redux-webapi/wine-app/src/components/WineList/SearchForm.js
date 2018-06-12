import React, { Component } from "react";

class SearchForm extends Component {
  constructor(props) {
    super(props);
    this.state = { searchString: "" };
  }

  render() {
    return (
      <div>
        <input
          type="text"
          onChange={e => this.setState({ searchString: e.target.value })}
        />
        <button
          onClick={() => this.props.buttonClicked(this.state.searchString)}
        >
          Search
        </button>
      </div>
    );
  }
}

export default SearchForm;
