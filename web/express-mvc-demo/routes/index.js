const express = require('express')

// On recupère le router depuis express
const router = express.Router()

const homeController = require('../controllers/homeController')
const apiController = require('../controllers/apiController')
const candidatesController = require('../controllers/candidatesController')

router.get('/', homeController.index)

router.get('/about', homeController.about)

router.get('/hello/:name', homeController.sayHello)

router.get('/api', apiController.index)

router.post('/api', apiController.add)

router.get('/api/:id', apiController.getById)

router.put('/api/:id', apiController.modify)

router.delete('/api/:id', apiController.remove)

router.get('/candidates/:id', candidatesController.getById)
router.put('/candidates/:id', candidatesController.update)
router.delete('/candidates/:id', candidatesController.remove)

router.get('/candidates', candidatesController.index)
router.post('/candidates', candidatesController.add)

router.all('*', (req, res) => {
    res.status(404).send('Erreur 404: page non trouvée')
})

module.exports = router