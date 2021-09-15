import express from "express";
import cors from "cors";
// import path from 'path';
import connection from "./database/connection.js";

import teamRoutes from "./routes/teams.js";
import positionRoutes from "./routes/positions.js";

const PORT = process.env.PORT || 3000;
const app = express();

// const moduleURL = new URL(import.meta.url);
// const __dirname = path.dirname(moduleURL.pathname);

// parse requests of content-type - application/json & application/x-www-form-urlencoded
app.use(express.json());
app.use(express.urlencoded({ extended: true }));

connection; // Calls the Database

app.use("/api/teams", teamRoutes);
app.use("/api/positions", positionRoutes);

app.use(cors({
  origin: ["https://the-fame-of-honor.herokuapp.com", "http://localhost:8080"],
  allowedHeaders: "'Access-Control-Allow-Origin': '*'"
}));

app.listen(PORT, function() {
  console.log(`🌎  ==> server listening on Port: ${PORT}`)
});