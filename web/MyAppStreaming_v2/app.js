const express = require('express')
const db = require('./models/index')
const port = process.env.PORT | '8080'

// Initialisation de la base de donnée
db.sequelize.sync()

// Import des router pour la redirection des routes.
const router = require('./routers')

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

// Importation du moteur de vue
require('./middlewares/liquid')(app)

// Utilisation du router à partir de la racine du site.
app.use('/', router)

app.listen(port, () => {
    console.log(`Server ready on the port : http://localhost:${port}/home`)
})