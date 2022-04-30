const express = require('express');
const router = express.Router();
const { randomBytes } = require('crypto');

/* GET home page. */
router.get('/', function(req, res, next) {
  if (req.session.csrf === undefined) {
    req.session.csrf = randomBytes(100).toString('base64');
  }

  res.render('index', { title: 'Express', token: req.session.csrf });
});

router.post('/', function(req, res, next) {
  if (!req.body.csrf) {
    return res.send(`<p style="font-size: 4rem; color: red;">
                     <strong>CSRF Token not included.</strong>
                     </p>`);
  }

  if (req.body.csrf !== req.session.csrf) {
    return res.send(`<p style="font-size: 4rem; color: red;">
                     <strong>CSRF tokens do not match.</strong>
                     </p>`);
  }

  return res.send(`<p style="font-size: 4rem;">
                   <strong>Successful request!</strong>
                   </p>`);
});

module.exports = router;
