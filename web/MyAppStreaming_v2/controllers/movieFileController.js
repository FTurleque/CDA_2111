const movieFileRepo = require('../db/movieFileRepository')

module.exports = {
    /**
     * GET /movies.
     * Afficher la liste des films.
     * @param {Request} req 
     * @param {Response} res 
     */
    async getAllMoviesFile(req, res) {
        try {
            let results = await movieFileRepo.getAll()
            res.render('movies', { model: results, title: 'film'})
        } catch (err) {
            console.log(err)
            res.status(500).end()
        }
    },

    /**
     * GET /movies/:id.
     * Afficher un film si sont id est existant.
     * @param {Request} req 
     * @param {Response} res 
     */
    async getOneMovieFile(req, res) {
        try {
            let result = await movieFileRepo.getById(req.params.id)
            // if(result === undefined)
            //     res.status(404).json({error: '404'})

            res.render('movie', { model: result, title: 'Film' })
        } catch (err) {
            console.log(err)
            res.status(500).end()
        }
    },

    /**
     * GET /movies/add.
     * Formulaire d'ajout d'un film
     * @param {Request} req 
     * @param {Response} res 
     */
    async add(req, res) {
        const result = req.body
        res.render('movie_add', { model: result })
    },

    /**
     * POST /movies/add.
     * Ajouter d'un film.
     * @param {Request} req 
     * @param {Response} res 
     */
    async add_post(req, res) {
        const model = req.body
        await movieFileRepo.create(model)
        res.redirect('/movies')
    },

    /**
     * GET /movies/edit/:id.
     * Formulaire pour modifier les info d'un film.
     * @param {Request} req 
     * @param {Response} res 
     */
    async modify(req, res) {
        const result = await movieFileRepo.getById(req.params.id)
        res.render('movie_edit', { model : result })
    },

    /**
     * POST /movies/edit/:id.
     * Modifier les infos d'un film.
     * @param {Request} req 
     * @param {Response} res 
     */
    async modify_post(req, res) {
        const model = req.body
        await movieFileRepo.update(model)
        res.redirect('/movies')
    },

    /**
     * GET /movies/delete/:id.
     * Formulaire de suppression.
     * @param {Request} req 
     * @param {Response} res 
     */
    async remove(req, res) {
        const result = await movieFileRepo.getById(req.params.id)
        res.render('movie_delete', { model: result })
    },

    /**
     * POST /movies/delete/:id.
     * Suppression d'un film.
     * @param {Request} req 
     * @param {Response} res 
     */
    async remove_post(req, res) {
        const id = req.params.id
        await movieFileRepo.delete(id)
        res.redirect('/movies')
    }
}