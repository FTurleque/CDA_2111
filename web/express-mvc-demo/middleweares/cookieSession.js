const { randomBytes } = require('crypto')
const { nextTick } = require('process')

exports.cookieSession = (req, res) => {
    if(req.session.csrf === undefined) {
        req.session.csrf = randomBytes(100).toString('base64')
    } else {
        next()
    }
}