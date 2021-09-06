import express from "express";
import cors from "cors";
import path from 'path';
import connection from "./database/connection.js";

import teamRoutes from "./routes/teams.js";
import positionRoutes from "./routes/positions.js";

const PORT = process.env.PORT || 3000;
const app = express();

const moduleURL = new URL(import.meta.url);
const __dirname = path.dirname(moduleURL.pathname);

// parse requests of content-type - application/json & application/x-www-form-urlencoded
app.use(express.json());
app.use(express.urlencoded({ extended: true }));

connection; // Calls the Database

let corsOptions = {
  origin: "http://localhost:8080"
};

app.use(cors(corsOptions));

app.use("/api/teams", teamRoutes);
app.use("/api/positions", positionRoutes);

app.use(express.static(path.join(__dirname, "./dist")));

app.get('/*', (req, res) => {
    res.sendFile(path.join(__dirname, './dist', ))
});

app.listen(PORT, function() {
  console.log(`🌎  ==> server listening on Port: ${PORT}`)
});