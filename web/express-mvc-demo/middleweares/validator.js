const { check } = require('express-validator')

exports.candidateValidator = [
    check('lastname')
        .notEmpty().withMessage('Le champ n\'est pas rempli')
        .isLength({ min: 2}).withMessage('Le champ requière 2 lettres minimum')
        .matches(/^[a-zA-ZÀ-ÿ]+([ -][a-zA-Z]+)*$/).withMessage('N\'accepte que les lettre'),
    check('firstname')
        .notEmpty().withMessage('Le champ n\'est pas rempli')
        .isLength({ min: 2}).withMessage('Le champ requière 2 lettres minimum')
        .matches(/^[a-zA-ZÀ-ÿ]+([ -][a-zA-Z]+)*$/).withMessage('N\'accepte que les lettre'),
    check('slogan').isLength({ min: 5, max: 40 })
]
