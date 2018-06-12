export const UPDATE_SEARCHED_WINE = "wines/UPDATE_SEARCHED_WINE";
export const FETCHING_WINE = "wines/FETCHING_WINE";

const initialState = {};

export default (state = initialState, action) => {
  switch (action.type) {
    case UPDATE_SEARCHED_WINE:
      return {
        ...state,
        searchedWine: action.payload.wine,
        isFetching: false
      };
    case FETCHING_WINE:
      return {
        ...state,
        isFetching: true
      };
    default:
      return initialState;
  }
};

export const updateSearchedWine = vinmonopoletId => dispatch => {
  dispatch({ type: FETCHING_WINE });

  setTimeout(() => {
    dispatch({
      type: UPDATE_SEARCHED_WINE,
      payload: {
        wine: {
          id: vinmonopoletId,
          name: "Louis Max Hautes-Côtes de Beaune 2015",
          vintage: "2015",
          country: "Frankrike"
        }
      }
    });
  }, 2000);
};
