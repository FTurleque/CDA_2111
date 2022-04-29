const express = require('express')
const cookie = require('../middleweares/cookieSession')

// On recupère le router depuis express
const router = express.Router()

const homeController = require('../controllers/homeController')
const apiController = require('../controllers/apiController')
const candidatesController = require('../controllers/candidatesController')

const validator = require('../middleweares/validator')


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
router.post('/candidates/edit/:id', cookie.cookieSession, validator.candidateValidator, candidatesController.update_post)

router.get('/candidates/delete/:id', candidatesController.remove)
router.post('/candidates/delete/:id', cookie.cookieSession, candidatesController.remove_post)

router.get('/candidates/add', candidatesController.add)
router.post('/candidates/add', cookie.cookieSession, validator.candidateValidator, candidatesController.add_post)

router.get('/candidates/:id', candidatesController.getById)
router.get('/candidates', candidatesController.index)

// router.post('/candidates/add', apiController.add)
// router.delete('/candidates/delete/:id', apiController.remove)

router.all('*', (req, res) => {
    res.status(404).send('Erreur 404: page non trouvée')
})

module.exports = router