
exports.index = (req, res) => {
    res.redirect('candidates')
}

exports.about = (req, res) => {
    res.send('A Propos')
}

exports.sayHello = (req, res) => {
    let name = req.params.name
    res.send(`Bonjour ${name}`)
}