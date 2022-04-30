exports.cookieSessionVerification = (req, res, next) => {
    if (!req.body.csrf) {
      return res.send(`<p style="font-size: 4rem; color: red;">
                       <strong>CSRF Token not included.</strong>
                       </p>`)
    }
  
    if (req.body.csrf !== req.session.csrf) {
      return res.send(`<p style="font-size: 4rem; color: red;">
                       <strong>CSRF tokens do not match.</strong>
                       </p>`)
    }
  
    next()
}
