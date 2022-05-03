**Initialisation de projet node**  
- npm init

**Instalation du module Express**  
- npm install express

**Installation de nodemon pour ne pas relancer le serveur** 
- npm install --save-dev nodemon

**Installation des outils pour la base de donnée**  
- npm install sequelize sequelize-cli mysql2 --save

**Initialisation de sequelize_cli**
- npx sequelize-cli init

**Création du model User dans la base de donnée**
- npx sequelize-cli model:generate --name User --attributes email:string,password:string

**Création du model de film en provenance de l'API**
- npx sequelize-cli model:generate --name Movie --attributes title:string,year:integer,language:string,format:string