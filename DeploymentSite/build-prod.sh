NODE_ENV=production ./node_modules/.bin/browserify -t [ babelify --presets [ react es2015 ] ] main.jsx  | ./node_modules/uglifyify/node_modules/.bin/uglifyjs  -c > bundle.js