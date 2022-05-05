require("dotenv").config()
const express = require('express')
const bodyParser = require('body-parser')
const cors = require('cors')
const apiRouter = require('./routers/apiRouter')

const db = require('./db/db.js');

const  sequelize = db.sequelize

const app = express()
  
const PORT= process.env.APP_PORT
  
app.use(bodyParser.json())
app.use(cors())

app.use('/apiRouter',apiRouter)

sequelize.authenticate()
.then(() => {
  console.log('Connection has been established successfully.');
})
.catch(err => {
  console.error('Unable to connect to the database:', err);
})
  
app.listen(PORT, ()=>{
    console.log(`server is listening  on ${PORT}`)
})
  
module.exports = app