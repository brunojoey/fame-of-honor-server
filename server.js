import express from "express";
import cors from "cors";
import connection from "./database/connection.js";

import teamRoutes from "./routes/teams.js";
import positionRoutes from "./routes/positions.js";

const PORT = process.env.PORT || 3000;
const app = express();

// parse requests of content-type - application/json & application/x-www-form-urlencoded
app.use(express.json());
app.use(express.urlencoded({ extended: true }));

connection; // Calls the Database

// app.use(cors({
//   origin: ["https://the-fame-of-honor.herokuapp.com", "http://localhost:8080"],
// }));

app.use(function(req, res, next) {
  res.header("Access-Control-Allow-Origin", "https://the-fame-of-honor.herokuapp.com"); 
  res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
  next();
});

app.use("/api/teams", teamRoutes);
app.use("/api/positions", positionRoutes);


app.listen(PORT, function() {
  console.log(`🌎  ==> server listening on Port: ${PORT}`)
});