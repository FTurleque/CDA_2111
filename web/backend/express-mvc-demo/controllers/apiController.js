// const db = require('../db')
const repository = require('../db/candidatesRepository')

exports.index = async (req, res) => { 
    try {
        console.log(req.method)

        let result = await repository.getAll()
        res.json(result)
    } catch (error) {
        console.error(err)
        res.status(500).end()
    }
}

exports.getById = async (req, res) => {
    try {
        console.log(req.method)
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
    console.log(req.body)
    const model = req.body
    let result = await repository.create(model)
    // res.status(201).json(result)
    res.status(201).json(result)
}


exports.remove = async (req, res) => {
    console.log(req.body)
    let result = await repository.delete(req.params.id)
    res.status(202).json(result)
}

exports.modify = async (req, res) => {
    console.log(req.body)
    const model = req.body
    model.id = req.params.id
    let result = await repository.update(model)
    console.log(result)
    res.status(202).json(result)
}