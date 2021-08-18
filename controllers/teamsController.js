const teams = require("../models/teams");

module.exports = {
  findAll: function (req, res) {
    teams.findAll((err, data) => {
      if (err) {
        res.status(500).send({
          message: err.message || "An error occured while retrieving Teams."
        });
      }
      else res.send(data);
    });
  }
};

module.exports = {
  findById: function(req,res) {
    teams.findById((err, data) => {
      if (err) {
        if (err.kind === "not_found") {
          res.status(404).send({ message: `No Team with id ${req.params.teamId}.` })
        } else {
          res.status(500).send({ message: "Trouble retrieving Team with the ID of " + req.params.teamId });
        }
      } else res.send(data);
    });
  }
};