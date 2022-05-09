"use strict";
const { Model } = require("sequelize");
module.exports = (sequelize, DataTypes) => {
  class MovieInfo extends Model {
    /**
     * Helper method for defining associations.
     * This method is not a part of Sequelize lifecycle.
     * The `models/index` file will call this method automatically.
     */
    static associate(models) {
      // define association here
    }
  }
  MovieInfo.init(
    {
      title: {
        type: DataTypes.STRING,
        allowNull: false,
      },
      release_date: {
        type: DataTypes.DATE,
        allowNull: false,
      },
      language: {
        type: DataTypes.STRING,
        allowNull: true,
      },
      format: {
        type: DataTypes.STRING,
        allowNull: true,
      },
      urlFile: {
        type: DataTypes.STRING,
        allowNull: false,
      },
    },
    {
      sequelize,
      modelName: "MovieInfo",
    }
  );
  return MovieInfo;
};
