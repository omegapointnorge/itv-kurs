const merge = require('webpack-merge');
const common = require('./webpack.common.js');

module.exports = merge(common, {
  /**
   * Tell webpack that this is a production build.
   *
   * webpack does some optimizations under the hood
   * automatically when this mode is set.
   */
  mode: 'production',
  /**
   * We still want source maps in production as they are
   * useful for debugging purposes.
   *
   * However, we do not want them inlined in our bundles
   * as they will increase bundle size.
   *
   * This will create source maps in separate files.
   */
  devtool: 'source-map'
});
