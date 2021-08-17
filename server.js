const express = require("express");
const cors = require("cors");

const PORT = process.env.PORT || 3000;
const app = express();

var corsOptions = {
  origin: "http://localhost:3001"
};

app.use(cors(corsOptions));

// parse requests of content-type - application/json & application/x-www-form-urlencoded
app.use(express.json());
app.use(express.urlencoded({ extended: true }));

app.listen(PORT, function() {
  console.log(`🌎  ==> server listening on Port: ${PORT}`)
});