// Creates the Connection to the Database
import mysql from "mysql";
import util from "util"

const connection = mysql.createConnection({
  host: "us-cdbr-east-04.cleardb.com",
  user: "ba46ffa2322ebf",
  password: "d9478934",
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