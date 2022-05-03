const express = require('express')
const router = require('./routes/index')
const port = process.env.PORT | '3000'
const db = require('./models')

// Import des routes de l'app
const indexRouter = require('./routes/index')
const userRouter = require('./routes/users')

const app = express()

app.use(express.urlencoded({ extended: false }))
app.use(express.json())

// Middleware utiliser par tous les chemins et affiche la requête et le chemin
app.use((req, res, next) => {
    let method = req.method
    let path = req.originalUrl
    console.log(`${method} ${path}`)
    next()
})

// Permet de ne pas interpréter le fichier coté node mais est interprété coté client
app.use(express.static(__dirname + '/public'))

db.sequelize.sync({force: true})

console.log(db)
// try {
//     db.sequelize.authenticate();
//     console.log(db)
//     console.log('Connection has been established successfully.');
// } catch (error) {
//     console.error('Unable to connect to the database:', error);
// }

app.use('/', indexRouter)
// app.use('/users', userRouter)

app.listen(port, () => {
    console.log(`Server ready on the port : http://localhost:${port}`)
})