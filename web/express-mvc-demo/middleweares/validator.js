const { body, validationResult } = require('express-validator')

module.exports = {
    stringValidator(req, res) {
        body('lastname').isAlpha()
        // body('firstname')
        // body('slogan')
        
    }
}

