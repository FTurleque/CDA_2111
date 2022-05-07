const config = require('../config/config.js')
const mysql = require('mysql2')
const Sequelize = require('sequelize')

module.exports = db = {}

// create db if it doesn't already exist
const { host, port, user, password, database } = config.database
const pool =  mysql.createPool({ host, port, user, password })
pool.query(`CREATE DATABASE IF NOT EXISTS \`${database}\`;`)

// connect to db
const sequelize = new Sequelize(database, user, password, { dialect: 'mysql',
pool: {
    max: config.pool.max,
    min: config.pool.min,
    acquire: config.pool.acquire,
    idle: config.pool.idle
  }}
)

db.sequelize = sequelize

// init the Employee model and add it to the exported db object
db.Employee = require('../models/employee');
 
// sync all models with database
sequelize.sync()