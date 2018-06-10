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

export const updateSearchedWine = () => {
  return {
    type: UPDATE_SEARCHED_WINE,
    payload: {
      wine: {
        name: "Louis Max Hautes-Côtes de Beaune 2015",
        vintage: "2015",
        country: "Frankrike"
      }
    }
  };
};
