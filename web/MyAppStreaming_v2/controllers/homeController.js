exports.index = (req, res) => {
    console.log('In the controller')
    res.send('Welcome home')
}

exports.about = (req, res) => {
    console.log('In the controller')
    res.send('About')
}