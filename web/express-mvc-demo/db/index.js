const path = require('path')
const sqlite3 = require('sqlite3')

const dbpath = path.join(__dirname, 'data', 'votes.db')

const db = new sqlite3.Database(dbpath, (err) => {
    if(err) {
        return console.error('Erreur SQL: ' + err)
    }
    console.log('Base de donnée connectée')
})

module.exports = db