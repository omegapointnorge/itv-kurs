1.  Prerequisities  
    Install webpack
    Install webpack-cli
    Install webpack-dev-server

    Setup inline-source-maps
    Setup dev-server.

2)  Explain package.json

    Explain that default webpack uses webpack.config.js
    We have created common, dev and prod in order to share some config
    and must therefore set which config files to use in our scripts.

3)  Entry points
    Set entry points of application. Defaults to index.js
    Possibly show that we can change the entry point to something else
    and have multiple entry points.

    e.g. scripts running at once when index.html is served.

4)  Loaders
    They are used to import different types of files to our bundle.

    In our config, each loader are set up under

    module: {
    rules:[
    {
    // a loader config goes here
    },
    ]
    }

    and the setup is as easy as using a regex to find the files to included and setting up the loader to user.

        module: {
            rules: [
            {
                test: /\.css$/,
                use: [
                'style-loader',
                'css-loader'
                ]
            }
            ]
        }

    List of loaders:

    HTML:
    npm install html-loader

    CSS:
    npm install style-loader css-loader

    File:
    npm install file-loader

    Data:
    npm install csv-loader xml-loader

5)  Index html

    A web page needs to have something to present to users when they visit the page.
    This entry point file is called index.html and we need to create one during our build.

    We use a tool called HtmlWebpackPlugin for this.

    npm install clean-webpack-plugin

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>Webpack Tutorial</title>
  </head>
  <body>
    <script type="text/javascript" src="index.bundle.js"></script>
    <script type="text/javascript" src="anotherEntryPoint.bundle.js"></script>
  </body>
</html>

5. Plugins vs loaders

   Loaders work at individual file level and typically executes some sort of function for example minification.

   We have used loaders to include css and files in our webpack build.

   Plugins hooks into the webpack process and adds another step.
   Let's think of webpack build as a sequence of steps where some steps comes out of the box. Plugins gives us the
   option of adding more steps to this sequence.

   Examples of steps we have used:

   Create a index.html file with our entry point scrips loaded.
   Clean up our dist folder before each build.

# Additionals

1. Create a separate css files per module
2. Minify css

3. Hot module replacement
   During development only refresh the affected bundles

4. Tree shaking
   Remove dead code from bundle

5. Lazy loading
   Load needed code when first required.
