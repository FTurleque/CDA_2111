const db = require('../db')
const repository = require('../db/candidatesRepository')

exports.index = async (req, res) => { 
    try {
        let result = await repository.getAll()
        res.json(result)
    } catch (error) {
        console.error(err)
        res.status(500).end()
    }
}

exports.getById = async (req, res) => {
    try {
        const { id } = req.params
        let result = await repository.getById(id)
        if(result === undefined) {
            res.status(404).json({error: '404'})
        }

        res.json(result)
    } catch (err) {
        console.error(err)
        res.status(500).end()
    }
}

exports.add = async (req, res) => {
    const model = req.body
    let result = await repository.create(model)
    res.status(201).json(result)
}


exports.remove = async (req, res) => {
    let { id } = req.params
    let result = await repository.delete(id)
    res.status(202).end()
}

exports.modify = async (req, res) => {
    const { id } = req.params
    const model = req.body
    let result = await repository.update(id, model)
    console.log(result)
    res.status(201).json(result)
}