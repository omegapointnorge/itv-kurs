import axios from "axios";

export const UPDATE_SEARCHED_WINE = "wines/UPDATE_SEARCHED_WINE";
export const FETCHING_WINE = "wines/FETCHING_WINE";
export const FETCHING_WINE_FAILED = "wines/FETCHING_WINE_FAILED";

const initialState = {};

export default (state = initialState, action) => {
  switch (action.type) {
    case UPDATE_SEARCHED_WINE:
      return {
        ...state,
        searchedWine: action.payload.wine,
        isFetching: false,
        errorMessage: null
      };
    case FETCHING_WINE:
      return {
        ...state,
        isFetching: true
      };
    case FETCHING_WINE_FAILED:
      return {
        ...state,
        isFetching: false,
        errorMessage: action.payload.errorMessage
      };
    default:
      return initialState;
  }
};

export const updateSearchedWine = vinmonopoletId => dispatch => {
  dispatch({ type: FETCHING_WINE });
  axios
    .get(`http://localhost:5000/api/wine/${vinmonopoletId}`)
    .then(function(response) {
      console.log(response);
      dispatch({
        type: UPDATE_SEARCHED_WINE,
        payload: {
          wine: response.data
        }
      });
    })
    .catch(function(error) {
      console.log(error);
      dispatch({
        type: FETCHING_WINE_FAILED,
        payload: {
          errorMessage: error.message
        }
      });
    });
};
