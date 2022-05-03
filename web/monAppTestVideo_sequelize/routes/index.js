const express = require('express')
const router = express.Router()

const homeController = require('../controllers/homeController')
const apiController = require('../controllers/apiController')

// Route pour la partie homeController
router.get('/', homeController.index)
router.get('/about', homeController.about)

// Route pour l'api

router.all('*', (req, res) => {
    res.status(400).send('Error 404 : Page not found !')
})

module.exports = router