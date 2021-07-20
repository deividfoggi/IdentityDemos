var express = require('express');
var app = express();
var morgan = require('morgan');
var path = require('path');

var port = 3007;
app.use(morgan('dev'));

app.use(express.static('web'));

app.get('*', function(req, res){
    res.sendFile(path.join(__dirname + '/index.html'));
});

app.listen(port);
console.log(`Listening on port ${port}...`);
console.log('Press CTRL+C to stop the web servers...');