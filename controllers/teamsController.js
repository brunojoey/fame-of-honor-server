import teams from "../models/teams.js";

const findAll = (req, res) => {
  teams.findAll((err, data) => {
    if (err) {
      res.status(500).send({
        message: err.message || "An error occured while retrieving Teams."
      });
    }
    else res.send(data);
  });
};

const findById = (req, res) => {
  teams.findById(req.params.teamId, (err, data) => {
    if (err) {
      if (err.kind === "not_found") {
        res.status(404).send({ message: `No Team with id ${req.params.teamId}.` })
      } else {
        res.status(500).send({ message: "Trouble retrieving Team with the ID of " + req.params.teamId });
      }
    } else res.send(data);
  });
};

const findByTeam = (req, res) => {
  teams.findByTeam(req.params.teamId, (err, data) => {
    if (err) {
      res.status(500).send({
        message: err.message || `An error occurred while retrieving ${req.params.teamId} teams' players.`
      });
    }
    else res.send(data);
  });
};

export { findAll, findById, findByTeam };