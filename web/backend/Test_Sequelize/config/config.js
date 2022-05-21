module.exports = {
    "database":{
         "host": "localhost",
         "port": 3306,
         "user": "root",
         "password": "root",
         "database": "sequelize-db-testOne"
    },
    "pool": {
     "max": 5,
     "min": 0,
     "acquire": 30000,
     "idle": 10000
    }
}