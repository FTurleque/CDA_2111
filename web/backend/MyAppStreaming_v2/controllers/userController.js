const userRepo = require('../db/userRepository')

module.exports = {
    /**
     * GET /users.
     * Afficher la liste des utilisateurs.
     * @param {Request} req 
     * @param {Response} res 
     */
    async getAllUsers(req, res) {
        try {
            let results = await userRepo.getAll()
            res.render('users', { model: results, title: 'utilisateur'})
        } catch (err) {
            console.log(err)
            res.status(500).end()
        }
    },

    /**
     * GET /users/:id.
     * Afficher un utilisateur si sont id est existant.
     * @param {Request} req 
     * @param {Response} res 
     */
    async getOneUser(req, res) {
        try {
            let result = await userRepo.getById(req.params.id)
            // if(result === undefined)
            //     res.status(404).json({error: '404'})

            res.render('user', { model: result, title: 'Utilisateur' })
        } catch (err) {
            console.log(err)
            res.status(500).end()
        }
    },

    /**
     * GET /users/add.
     * Formulaire d'ajout d'un utilisateur
     * @param {Request} req 
     * @param {Response} res 
     */
    async add(req, res) {
        console.log(req.body)
        const result = req.body
        res.render('user_add', { model: result })
    },

    /**
     * POST /users/add.
     * Ajouter d'un utilisateur.
     * @param {Request} req 
     * @param {Response} res 
     */
    async add_post(req, res) {
        const email = req.body.email
        const password = req.body.password
        await userRepo.create(email, password)
        res.redirect('/users')
    },

    /**
     * GET /users/edit/:id.
     * Formulaire pour modifier les info d'un utilisateur.
     * @param {Request} req 
     * @param {Response} res 
     */
    async modify(req, res) {
        const result = await userRepo.getById(req.params.id)
        res.render('user_edit', { model : result })
    },

    /**
     * POST /users/edit/:id.
     * Modifier les infos d'un utilisateur.
     * @param {Request} req 
     * @param {Response} res 
     */
    async modify_post(req, res) {
        const id = req.params.id
        const email = req.body.email
        const password = req.body.password
        await userRepo.update(id, email, password)
        res.redirect('/users')
    },

    /**
     * GET /users/delete/:id.
     * Formulaire de suppression.
     * @param {Request} req 
     * @param {Response} res 
     */
    async remove(req, res) {
        const result = await userRepo.getById(req.params.id)
        res.render('user_delete', { model: result })
    },

    /**
     * POST /users/delete/:id.
     * Suppression d'un utilisateur.
     * @param {Request} req 
     * @param {Response} res 
     */
    async remove_post(req, res) {
        const id = req.params.id
        await userRepo.delete(id)
        res.redirect('/users')
    }
}