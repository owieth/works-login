const express = require('express');
const mySql = require('mysql');
const app = express();
const cors = require('cors');

let connection = mySql.createPool({
    connectionLimit: 50,
    host: 'localhost',
    user: 'root',
    password: '',
    database: 'moviedb'
});

app.use(cors());
app.get('/', function(req, res) {
    connection.getConnection(function(error, tempCont) {
        if(error){
            tempCont.release();
            console.log(error);
        } else {
            console.log('Connected!');
            tempCont.query('SELECT * FROM filme', function(err, values) {
                tempCont.release();
                if(!!err){
                    console.log('Error in Query for all Movies');
                } else {
                    res.json(values);
                }
            });
        }
    });
});

app.get('/detail/:id', function(req, res) {
    connection.getConnection(function(error, tempCont) {
        if(error){
            tempCont.release();
            console.log(error);
        } else {
            console.log('Connected!');
            tempCont.query(`SELECT * FROM filme WHERE id = ${req.params.id}`, function(err, values) {
                tempCont.release();
                if(!!err){
                    console.log('Error in Query for one specific Movie');
                } else {
                    res.send(values[0]);
                }
            });
        }
    });
});

app.get('/update/:id', function (req, res) {
   connection.getConnection(function (error, tempCont) {
       if(error) {
           tempCont.release();
           console.log(error);
       } else {
           console.log('Connected!');
           let title = document.getElementsByClassName('updatetitle')[0].value;
           let image = document.getElementsByClassName('updateimage')[0].value;
           let id = req.params.id;
           tempCont.query('UPDATE filme SET name = ' + connection.escape(title)
               + ' AND image = ' + connection.escape(image) + 'WHERE id = ' + connection.escape(id) + '',
               function(err, result) {
               tempCont.release();
                   if(!!err){
                       console.log('Error while updating Movie');
                   } else {
                       console.log(res);
                   }
               });
       }
   })
});

app.get('/neu', function (req, res) {

});

app.listen(1337);

