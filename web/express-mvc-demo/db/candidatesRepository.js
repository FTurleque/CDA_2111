const db = require('./index')

exports.getAll = () => {
    return new Promise((resolve, reject) => {
        const sql = 'SELECT id, lastname, firstname, slogan FROM candidates'
        db.all(sql, [], (err, rows) => {
            if(err) {
                console.error('Erreur SQL: ' + err)
                reject(err)
            } else {
                // console.log(rows)
                resolve(rows)
            }
        })
    })
}

exports.getById = (id) => {
    return new Promise((resolve, reject) => {
        const sql = 'SELECT id, lastname, firstname, slogan FROM candidates WHERE id=?'
        db.get(sql, [id], (err, row) => {
            if(err) {
                console.error('Erreur SQL: ' + err)
                reject(err)
            } else {
                console.log(row)
                resolve(row)
            }
        })
    })
}

exports.create = (model) => {
    return new Promise((resolve, reject) => {
        const sql = `INSERT INTO candidates (lastname, firstname, slogan) VALUES (?, ?, ?)`
        const params = [model.lastname ,model.firstname, model.slogan]
        db.run(sql, params, (err, result) => {
            if(err) {
                console.error('Erreur SQL: ' + err)
                reject(false)
            } else {
                resolve(true)
            }
        })
    })
}

exports.update = (id, model) => {
    return new Promise((resolve, reject) => {
        const sql = `UPDATE candidates SET lastname=?, firstname=?, slogan=? WHERE id=?`
        const params = [model.lastname ,model.firstname, model.slogan, id]
        db.run(sql, params, (err, row) => {
            if(err) {
                console.error('Erreur SQL: ' + err)
                reject(err)
            } else {
                resolve(row)
            }
        })
    })
}

exports.delete = (id) => {
    return new Promise((resolve, reject) => {
        db.run('DELETE FROM cadidates WHERE id=?', [id], (err, result) => {
            if(err) {
                console.error('Erreur SQL: ' + err)
                reject(false)
            } else {
                resolve(true)
            }
        })
    })
}