const merge = require('webpack-merge');
const common = require('./webpack.common.js');

module.exports = merge(common, {
  /**
   * Tell webpack that this is a development build.
   */
  mode: 'development',
  /**
   * During build our code gets bundle and minified making it debug
   * when errors occur.
   *
   * Therefore, Javascript offers source maps which map compiled code
   * back to original source code. This makes sure that we can read
   * our code as we wrote when debugging issues in the browser
   *
   * To turn on source-maps we include the following:
   */
  devtool: 'inline-source-map',
  /**
   * Webpack offers a dev server set up with live reloading
   * 
   * npm install webpack-dev-server
   * 
   * 'contentBase': The folder to which files should be served from.
   * 
   * Note the we have setup a script in package.json to run live server
   * 
   *  "scripts": {
   *      ...
          "start": "webpack-dev-server --open"
          ...
        },
   */
  devServer: {
    contentBase: './dist'
  }
});
