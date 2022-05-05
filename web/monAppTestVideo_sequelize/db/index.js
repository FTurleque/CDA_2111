const config = require('../config/config.json');
const mysql = require('mysql2/promise');

exports.initialize = async () => {
    // create db if it doesn't already exist
    const { host, port, user, password, database } = config.development;
    const connection = await mysql.createConnection({ host, port, user, password });
    await connection.query(`CREATE DATABASE IF NOT EXISTS \`${database}\`;`);

    // connect to db
    // const sequelize = new Sequelize(database, user, password, { dialect: 'mysql' });

    // init models and add them to the exported db object
    // db.User = require('../users/user.model')(sequelize);

    // sync all models with database
    // await sequelize.sync({force: true});
}
