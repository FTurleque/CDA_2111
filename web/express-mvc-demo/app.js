const express = require('express')
const bodyParser = require('body-parser')
const cookieSession = require('cookie-session')

// Création de l'instance d'express
const app = express()

app.use((bodyParser.urlencoded()))

// app.use((bodyParser.json()))

app.use((req, res, next) => {
    let method = req.method
    let path = req.originalUrl
    console.log(`${method} ${path}`)
    next()
})

app.use(cookieSession({
    name: 'session',
    secret: 'MAKE_THIS_SECRET_SECURE',
    maxAge: 3*60*60*1000,
    sameSite: 'lax',
    path: '/',
    http: true
}))

app.use('/public', express.static(__dirname + '/public'))

require('./middleweares/liquid')(app)

const router = require('./routes')
app.use('/', router)


app.listen(80, () => {
    console.log('Server prêt (http://localhost)')
})