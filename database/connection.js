// Creates the Connection to the Database
import mysql from "mysql";
import util from "util";
import config from "./config.js";

const connection = mysql.createPool({
  host: config.host,
  user: config.user,
  password: config.password,
  database: config.database
});

connection.connect(err => {
  if (err) {
    throw err;
  } else {
    console.log("MySQL Connected")
  }
});

connection.query = util.promisify(connection.query);

export default connection;