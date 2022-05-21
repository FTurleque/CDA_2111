const express = require('express')
const { Sequelize, DataTypes } = require('sequelize')
const app = express()

// Défénition des paramètre de connéctions
const sequelize = new Sequelize('postges_database', 'root', 'root', {
    host: 'localhost',
    dialect: 'mysql'
})

// Définition du model
const postgresModel = sequelize.define('postgres', {
    id: {
        type: DataTypes.INTEGER, 
        primaryKey: true,
        allowNull: false
    },
    nombre: {
        type: DataTypes.STRING
    },
    calorias: {
        type: DataTypes.INTEGER
    }
})

// Connection
try {
    sequelize.authenticate()
    console.log('Database conected')
} catch (error) {
    console.log('Error : ' + err)
}

postgresModel.findAll({attributes:['nombre', 'calorias']}).then(postgres => {
    const result = JSON.stringify(postgres)
    console.log(result)
}).catch(err => {
    console.log(err)
})

app.listen(3000, () => {
    console.log('Server OK https://localhost:3000')
})