---
separator: ^---$
title: 'Webpack'
theme: 'beige'
customTheme: 'theme'
---

### Our code

---

### Install

- Install webpack
- Install webpack-cli
- Install webpack-dev-server

```html
npm install -D webpack webpack-cli webpack-dev-server
```

---

### package.json

```js
{
  "scripts": {
    "start": "webpack-dev-server --open",
    "build": "webpack --config",
  },
  "devDependencies": {
    "webpack": "^4.35.2",
    "webpack-cli": "^3.3.5",
    "webpack-dev-server": "^3.7.2",
  },
  "dependencies": {
    "lodash": "^4.17.15"
  }
}

```

---

#### webpack.config.js

```js
module.exports = {
  output: {
    filename: '[name].bundle.js',
    path: path.resolve(__dirname, 'dist')
  },
  module: {
    rules: []
  },
  plugins: []
  /// ...more properties
};
```

Note:

- Webpack uses webpack-config.js file as default configuration.
- In the example above have said that js.files should be given the name of
  name.bundle.js and output it to folder named dist in current directory
- Show the file.
- We have created common, dev and prod in order to share some config
  and must therefore set which config files to use in our scripts.
- Run a build

---

### Loaders

We use a loader per file type we want to include in bundle

```javascript
module: {
  rules: [
    {
      // a loader config goes here
    }
  ];
}
```

---

... and the setup is as easy as using a regex to find
the files to include and specifying the loader.

```javascript
module: {
  rules: [
    {
      test: /\.html$/,
      use: [
        {
          loader: 'html-loader',
          options: { minimize: true }
        }
      ]
    }
  ];
}
```

---

### List of loaders

- HTML
  - npm install html-loader
- CSS
  - npm install style-loader css-loader
- File
  - npm install file-loader
- Data
  - npm install csv-loader xml-loader

---

### HtmlWebpackPlugin

```html
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>Webpack Tutorial</title>
  </head>
  <body>
    <script type="text/javascript" src="main.bundle.js"></script>
  </body>
</html>
```

Note:

- A web page needs to have something to present to users when they visit the page. This entry point file is called index.html.
- We already have used a loader for outputing our index.html file, but we also need to insert the sripts we want to be run when the page loads.
- We do not want to have to manually type in the scripts tags in our index.html as they may change and we then need to update it. We want to
  have this dynamically inserted during build.
- We use a tool called HtmlWebpackPlugin for this.
- This also needs to be installed as a dev dependency.

---

### Entry points

In order to set up which scripts that is to be added to index.html we
use the entry parameters.

```js
webpack.config.js

  entry: {
    index: './src/index.js',
    anotherEntryPoint: './src/another-entry-point.js'
  },
```

Note:
Show
Set entry points of application. Defaults to index.js
Possibly show that we can change the entry point to something else
and have multiple entry points.

e.g. scripts running at once when index.html is served.

---

### Scripts inserted into index.html

```html
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
  </head>
  <body>
    <script type="text/javascript" src="index.bundle.js"></script>
    <script type="text/javascript" src="anotherEntryPoint.bundle.js"></script>
  </body>
</html>
```

---

### Plugins vs loaders

```js
  module: {
    rules: [
      {
        test: /\.html$/,
        use: [
          {
            loader: 'html-loader',
            options: { minimize: true }
          }
        ]
      },
    ]
  },
  plugins: [
    new HtmlWebpackPlugin({
      template: './src/index.html',
      filename: './index.html'
    }),
    new CleanWebpackPlugin()
  ]

```

Note:
Loaders work at individual file level and typically executes some sort of function for example minification.

We have used loaders to include css and files in our webpack build.

Plugins hooks into the webpack process and adds another step.
Let's think of webpack build as a sequence of steps where some steps comes out of the box. Plugins gives us the
option of adding more steps to this sequence.

Examples of steps we have used:

Create a index.html file with our entry point scrips loaded.
Clean up our dist folder before each build.

---

### Code splitting

- We have a dependency to lodash in both our bundles.
- As a result, lodash is bundled in both of them.
- Ideally, lodash should only be bundled once to avoid duplication.

---

### Source maps

Convert compiled code back to original source code.

---

### Additionals

<ul>
  <li>Babel
    <ul>
        <li>Convert ECMAScript 2015+ code into a backwards compatible version of JavaScript</li>
    </ul>
  </li>
  <li>Minify css</li>
  <li>Hot module replacement
    <ul>
      <li>During development only refresh the affected bundles</li>
    </ul>
  </li>
  <li>Tree shaking
    <ul>
      <li>Remove dead code from bundle</li>
    </ul>
  </li>
  <li>Lazy loading
    <ul>
      <li>Load needed code when first required.</li>
    </ul>
  </li>
</ul>
