const config = require('../config/config.json');
const mysql = require('mysql2/promise');

module.exports = db = {};

initialize();

async function initialize() {
    // create db if it doesn't already exist
    //const { host, port, user, password, database } = config.development.database;
    //const connection = await mysql.createConnection({ host, port, user, password });
    // const database = "sequelize_db_movies"
    // const connection = await mysql.createConnection(
    //     { host: '127.0.0.1', port: '3306', user: 'root', password: 'root' }
    // );
    // await connection.query(`CREATE DATABASE IF NOT EXISTS \`${database}\`;`);

    // connection.end()

    // const port = '3306'
    const { host, port, user, password, database } = config.development;
    // const database = 'sequelize_db_movies'
    // const host = '127.0.0.1'
    // const user = 'root'
    // const password = 'root'
    console.log(`username: ${user}, password: ${password}, database: ${database}, host: ${host}`)
    //const connection = await mysql.createConnection({ host, port, user, password });
    const connection = await mysql.createConnection(
        { host, port, user, password }
    );
    await connection.query(`CREATE DATABASE IF NOT EXISTS \`${database}\`;`);

    connection.end()
}
