const db = require('../models/index')

const MovieFile = db.MovieFile

module.exports = {
    /**
     * Retourne de l'intégralitée des films.
     */
    async getAll() {
        const movies = await MovieFile.findAll()
        return movies
    },

    /**
     * Retourne un film.
     * @param {Int} id Identifiant du film.
     */
    async getById(id) {
        const movie = MovieFile.findByPk(id)
        return movie
    },

    /**
     * Création d'un film.
     * @param {Object} model Corp de la requête d'un film
     */
    async create(model) {    
        const {title, year, language, format, urlFile} = model
        await MovieFile.create({ title, year, language, format, urlFile }) 
    },

    /**
     * Modifie un film.
     * @param {Object} model Corp de la requête d'un film
     */
    async update(model) {
        const {title, year, language, format, urlFile, id} = model
        await MovieFile.update({ title, year, language, format, urlFile }, { where: {id: id} })
    },

    /**
     * Supprime un film.
     * @param {Int} id Identifiant du film.
     */
    async delete(id) {
        const movie = await this.getById(id)
        await movie.destroy()
    }
}
