const db = require('../models/index')

const User = db.User

module.exports = {
    /**
     * Retourne de l'intégralitée des utilisateurs.
     */
    async getAll() {
        const users = await User.findAll()
        return users
    },

    /**
     * Retourne un utilisateur.
     * @param {Int} id Identifiant du utilisateur.
     * @returns {Promise} L'utilisateur sous forme d'objet ou undefined s'il n'existe pas.
     */
    async getById(id) {
        const user = User.findByPk(id)
        return user
        // const sql = `SELECT * FROM Users WHERE id=?`
        // return repo.getOne(sql, id)
    },

    /**
     * Création d'un utilisateur.
     * @param {String} email 
     * @param {String} password 
     */
    async create(email, password) {       
        await User.create({ email, password }) 
    },

    /**
     * Modifie un utilisateur
     * @param {Number} id 
     * @param {String} email 
     * @param {String} password 
     */
    async update(id, email, password) {
        await User.update({ email, password}, { where: {id: id} })
    },

    /**
     * Supprime un utilisateur.
     * @param {Int} id Identifiant du film.
     */
    async delete(id) {
        const user = await this.getById(id)
        await user.destroy()
    }
}
