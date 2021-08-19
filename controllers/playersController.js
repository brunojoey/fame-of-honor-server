import players from "../models/players.js";

const findAll = (req, res) => {
  players.findAll((err, data) => {
    if (err) {
      res.status(500).send({
        message: err.message || "An error occured while retrieving players."
      });
    }
    else res.send(data);
  });
};

const findById = (req, res) => {
  players.findById(req.params.playerId, (err, data) => {
    if (err) {
      if (err.kind === "not_found") {
        res.status(404).send({ message: `No player with id ${req.params.playerId}.` })
      } else {
        res.status(500).send({ message: "Trouble retrieving player with the ID of " + req.params.playerId });
      }
    } else res.send(data);
  });
};

export { findAll, findById };