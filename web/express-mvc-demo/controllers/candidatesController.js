/*
    index    lister les candidats (acceuil du contrôlleur)
    getById    afficher les détails d'un candidat
    add    ajouter un nouveau candidat
    update    modifier une candidat
    delete    supprimer un candidat
*/
const { validationResult } = require('express-validator')
const repo = require('../db/candidatesRepository')

module.exports = {
    async index(req, res) {
        try {
            let results = await repo.getAll()
            res.render('index', { model: results, title: 'Liste des candidats'})
        } catch (error) {
            res.status(500).end()
        }
    },

    async getById(req, res) {
        try {
            let result = await repo.getById(req.params.id)
            result.csrf = req.session.csrf
            res.render('candidate', { model: result, title: 'Fiche candidat' })
        } catch (error) {
            console.log(error)
            res.status(500).end()
        }
    },

    async add(req, res) {
        const result = req.body
        result.csrf = req.session.csrf
        res.render('candidate_add', { model: result })
    },

    async add_post(req, res) {
        const validatorErrors = validationResult(req)
        if(!validatorErrors.isEmpty()){
            console.log(validatorErrors.array())
            res.render('candidate_add', { errors: validatorErrors.array(), model: req.body })
        } else {
            let model = req.body
            await repo.create(model)
            res.redirect('/candidates')
        }
    },

    async update(req, res) {
        let result = await repo.getById(req.params.id)
        result.csrf = req.session.csrf
        res.render('candidate_edit', { model : result })
    },

    async update_post(req, res) {
        const validatorErrors = validationResult(req)
        if(!validatorErrors.isEmpty()) {
            console.log(validatorErrors.array())
            res.render('candidate_edit ', { errors: validatorErrors.array(), model: req.body })
        } else {
            let model = req.body
            await repo.update(model)
            res.redirect('/candidates')
        }
    },

    async remove(req, res) {
        let result = await repo.getById(req.params.id)
        result.csrf = req.session.csrf
        res.render('candidate_delete', { model: result })
    },

    async remove_post(req, res) {
        await repo.delete(req.params.id)
        res.redirect('/candidates')
    }
}