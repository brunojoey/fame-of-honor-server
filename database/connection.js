// Creates the Connection to the Database
import mysql from "mysql";
import util from "util"

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

export default connection;