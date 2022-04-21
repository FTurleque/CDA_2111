/*
    index    lister les candidats (acceuil du contrôlleur)
    getById    afficher les détails d'un candidat
    add    ajouter un nouveau candidat
    update    modifier une candidat
    delete    supprimer un candidat
*/

const repo = require('../db/candidatesRepository')

module.exports = {
    async index(req, res) {
        try {
            let result = await repo.getAll()
            res.render('index', { model: result})
        } catch (error) {
            res.status(500).end()
        }
    },

    async getById(req, res) {
        try {
            if(req.params.id === undefined) {
                throw new Error('Vous n\'avez par renseigner d\'id')
            }
            const { id } = req.params
            let result = await repo.getById(id)
            res.render('getById', { model: result})
        } catch (error) {
            res.status(500).end()
        }
    },

    add(req, res) {

    },

    update(req, res) {

    },

    remove(req, res) {

    }
}