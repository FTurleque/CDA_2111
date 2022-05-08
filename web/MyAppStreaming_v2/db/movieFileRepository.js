const db = require('../models/index')

const Movie = db.Movie

module.exports = {
    /**
     * Retourne de l'intégralitée des films.
     */
    async getAll() {
        const movies = await Movie.findAll()
        return movies
    },

    /**
     * Retourne un film.
     * @param {Int} id Identifiant du film.
     */
    async getById(id) {
        const movie = Movie.findByPk(id)
        return movie
    },

    /**
     * Création d'un film.
     * @param {String} email 
     * @param {String} password 
     */
    async create(email, password) {       
        await Movie.create({ email, password }) 
    },

    /**
     * Modifie un film.
     * @param {Number} id 
     * @param {String} email 
     * @param {String} password 
     */
    async update(id, email, password) {
        await Movie.update({ email, password}, { where: {id: id} })
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
