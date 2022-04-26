const express = require('express')

// On recupère le router depuis express
const router = express.Router()

const homeController = require('../controllers/homeController')
const apiController = require('../controllers/apiController')
const candidatesController = require('../controllers/candidatesController')
const repo = require('../db/candidatesRepository')

// const validator = require('../middleweares/validator')
const { check, validationResult } = require('express-validator')


/* Home controller */
router.get('/', homeController.index)
router.get('/about', homeController.about)
router.get('/hello/:name', homeController.sayHello)

/* Api controller */
router.get('/api/:id', apiController.getById)
router.put('/api/:id', apiController.modify)
router.delete('/api/:id', apiController.remove)
router.get('/api', apiController.index)
router.post('/api', apiController.add)

/* Candidates controller */
router.get('/candidates/edit/:id', candidatesController.update)
router.post('/candidates/edit/:id', candidatesController.update_post)

router.get('/candidates/delete/:id', candidatesController.remove)
router.post('/candidates/delete/:id', candidatesController.remove_post)

router.get('/candidates/add', candidatesController.add)
// router.post('/candidates/add', candidatesController.add_post)
router.post('/candidates/add', [
    check('lastname', 'Contient des charactère interdit').matches(/\d/).withMessage('must contain a number'),
    check('firstname', 'Contient des charactère interdit').isAlpha()
    ], (req, res) => {
        const errors = validationResult(req)
        if(!errors.isEmpty()) {
            console.log(req.body)
            const values = req.body
            const validator = errors.array()
            console.log(values)
            console.log(validator)
        } else {
            let model = req.body
            repo.create(model)
            res.redirect('/candidates')
        }
})


router.get('/candidates/:id', candidatesController.getById)
router.get('/candidates', candidatesController.index)

// router.post('/candidates/add', apiController.add)
// router.delete('/candidates/delete/:id', apiController.remove)

router.all('*', (req, res) => {
    res.status(404).send('Erreur 404: page non trouvée')
})

module.exports = router