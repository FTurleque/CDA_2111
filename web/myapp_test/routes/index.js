var express = require('express');
var router = express.Router();
var { randomBytes } = require('crypto')

/* GET home page. */
router.get('/', function(req, res, next) {
  if(req.session.csrf === undefined) {
    req.session.csrf = randomBytes(100).toString('base64')
  }
  console.log(req.session)
  res.render('index', { title: 'Express', token: req.session.csrf });
});

router.post('/', (req, res, next) => {
  if(!req.body.csrf) {
    return res.send(`<p style="font-size: 4rem; color: red;">
                      <strong>CSRF tokens not inclued.</strong>
                      </p>`)
  }
  if(req.body.csrf !== req.session.csrf) {
    return res.send(`<p style="font-size: 4rem; color: red;">
                      <strong>CSRF tokens do not matche.</strong>
                      </p>`)
  }

  return res.send(`<p style="font-size: 4rem;">
                    <strong>Succesful request !</strong>
                    </p>`)
})

module.exports = router;
