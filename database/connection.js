// Creates the Connection to the Database
import mysql from "mysql2";
import util from "util";
import config from "./config.js";

// const connection = mysql.createPool({
//   host: config.host,
//   user: config.user,
//   password: config.password,
//   database: config.database
// });

const connection = mysql.createConnection({
  host: "127.0.0.1",
  user: "root",
  password: "bh2017RS@#$",
  database: "ringHonorDB"
});

// connection.connect(function(err) {
//   if (err) throw err;
//   console.log("Connected!");
// });

connection.query = util.promisify(connection.query);

export default connection;