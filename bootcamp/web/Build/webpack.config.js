const path = require('path');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const { CleanWebpackPlugin } = require('clean-webpack-plugin');

module.exports = {
  /**
   * The entry points of our application.
   *
   * These are the scripts that will be loaded into our index.html during build.
   * Subsequently, the code in these script will be executed when a user visits our page.
   */
  entry: {
    index: './src/index.js',
    anotherEntryPoint: './src/another-entry-point.js'
  },
  output: {
    filename: '[name].bundle.js',
    path: path.resolve(__dirname, 'dist')
  },
  /**
   * In our app lodash is a dependency for both out entry points (index & anotherEntryPoint).
   *
   * By default, lodash will be loaded in both our bundle.js files.
   * The code below will optimize this process and create a separate vendor-bundle.js
   * which is loaded in index.html.
   */
  optimization: {
    splitChunks: {
      chunks: 'all'
    }
  },
  module: {
    rules: [
      /**
       * Minify html
       * 
       * Outputs our index.html as string
       */
      {
        test: /\.html$/,
        use: [
          {
            loader: 'html-loader',
            options: { minimize: true }
          }
        ]
      },
       /**
       * Minify CSS
       * 
       * Relevant CSS is inlined in respective bundle.js file
       * 
       * css-loader: import css file as a module. 
       * style-loader Add css to javascript file.
       */
      {
        test: /\.css$/,
        use: ['style-loader', 'css-loader']
      },
      /**
       * Load images and output them to output folder
       * with the specified naming convention
       */
      {
        test: /\.(png|svg|jpg|gif)$/,
        use: ['file-loader']
      }
    ]
  },
  plugins: [
    /**
     * Use HtmlWebpackPlugin to create a index.html file during build.
     *
     * 'template': is an optional parameter used to tell webpack to base the
     *             new generated index.html file on this file.
     *
     * 'filename': the name of the file to be created
     *
     * Note: This plugin automatically creates scripts tags for our entry points
     */
    new HtmlWebpackPlugin({
      template: './src/index.html',
      filename: './index.html'
    }),
    /**
     * Webpack does not clean the dist folder by default.
     *
     * We use CleanWebpackPlugin() to empty the dist folder before
     * each build to avoid cluttering our dist folder with old files.
     */
    new CleanWebpackPlugin()
  ],
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
  },
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
  devtool: 'inline-source-map'
};
