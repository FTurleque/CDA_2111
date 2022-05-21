**Installation global d'express-generator pour auto-générer une app**  
- npm i -g express-generator

**Création du projet express auto-généré**
- express --view=hbs sequelize_cli

**Installation de sequelize cli**
- npm i --save-dev sequelize-cli
- npm i --save-dev sequelize

**Installation de MySQL**
- npm i mysql2

**Initialisation du projet sequelize**
- npx sequelize-cli init

**Création de la base de donnée**
- npx sequelize-cli db:create

**Création du model**
- npx sequelize-cli model:generate --name User --attributes firstName:string,lastName:string,email:string

**Execution de la migration vers la base de donnée**
- npx sequelize-cli db:migrate

**Création d'un seeder**
- npx sequelize-cli seed:generate --name demo-user
- npx sequelize-cli db:seed:all