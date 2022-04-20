const express = require('express')

// On recupère le router depuis express
const router = express.Router()

const homeController = require('../controllers/homeController')
const apiController = require('../controllers/apiController')

router.get('/', homeController.index)

router.get('/about', homeController.about)

router.get('/hello/:name', homeController.sayHello)

router.get('/api', apiController.index)

router.post('/api', apiController.add)

router.get('/api/:id', apiController.getById)

router.put('/api/:id', apiController.modify)

router.delete('/api/:id', apiController.remove)

router.all('*', (req, res) => {
    res.status(404).send('Erreur 404: page non trouvée')
})

module.exports = router