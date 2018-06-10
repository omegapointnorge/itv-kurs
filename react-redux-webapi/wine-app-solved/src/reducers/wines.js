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
