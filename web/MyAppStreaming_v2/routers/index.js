const express = require('express')
const router = express.Router()

const homeController = require('../controllers/homeController.js')
const userController = require('../controllers/userController')
const movieFileController = require('../controllers/movieFileController')

// Route pour la partie homeController
router.get('/home', homeController.index)
router.get('/about', homeController.about)

/* Routeur utilisateur */
router.get('/users/edit/:id', userController.modify)
router.post('/users/edit/:id', userController.modify_post)

router.get('/users/delete/:id', userController.remove)
router.post('/users/delete/:id', userController.remove_post)

router.get('/users/add', userController.add)
router.post('/users/add', userController.add_post)

router.get('/users/:id', userController.getOneUser)
router.get('/users', userController.getAllUsers)

/* Routeur film */
router.get('/movies/edit/:id', movieFileController.modify)
router.post('/movies/edit/:id', movieFileController.modify_post)

router.get('/movies/delete/:id', movieFileController.remove)
router.post('/movies/delete/:id', movieFileController.remove_post)

router.get('/movies/add', movieFileController.add)
router.post('/movies/add', movieFileController.add_post)

router.get('/movies/:id', movieFileController.getOneMovieFile)
router.get('/movies', movieFileController.getAllMoviesFile)

router.all('*', (req, res) => {
    res.status(400).send('Error 404 : Page not found !')
})

module.exports = router