// Creates the Connection to the Database
const mysql = require("mysql");
const util = require("util");

const connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "",
  database: "ringHonorDB"
});

connection.connect(err => {
  if (err) {
    throw err;
  } else {
    console.log("MySQL Connected")
  }
});

connection.query = util.promisify(connection.query);

module.exports = connection;