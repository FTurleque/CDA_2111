/*
    index    lister les candidats (acceuil du contrôlleur)
    getById    afficher les détails d'un candidat
    add    ajouter un nouveau candidat
    update    modifier une candidat
    delete    supprimer un candidat
*/
const { body, validationResult } = require('express-validator')
const repo = require('../db/candidatesRepository')
// const validator = require('../middleweares/validator')

module.exports = {
    async index(req, res) {
        try {
            let result = await repo.getAll()
            res.render('index', { model: result, title: 'Liste des candidats'})
        } catch (error) {
            res.status(500).end()
        }
    },

    async getById(req, res) {
        try {
            let result = await repo.getById(req.params.id)
            res.render('candidate', { model: result, title: 'Fiche candidat' })
        } catch (error) {
            console.log(error)
            res.status(500).end()
        }
    },

    async add(req, res) {
        res.render('candidate_add')
    },

    async add_post(req, res) {
        let model = req.body
        // console.log(model)
        body('lastname').isAlpha()
        console.log('Check lastname' + validationResult)
        // TODO : Contrôle de saisie

        await repo.create(model)
        res.redirect('/candidates')
    },

    async update(req, res) {
        let result = await repo.getById(req.params.id)
        res.render('candidate_edit', { model : result })
    },

    async update_post(req, res) {
        let model = req.body

        // TODO : Contrôle de saisie

        await repo.update(model)
        res.redirect('/candidates')
    },

    async remove(req, res) {
        let result = await repo.getById(req.params.id)
        res.render('candidate_delete', { model: result })
    },

    async remove_post(req, res) {
        await repo.delete(req.params.id)
        res.redirect('/candidates')
    }
}