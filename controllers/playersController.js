import players from "../models/players.js";

const findByPosition = (req, res) => {
  players.findByPosition(req.params.player_position, (err, data) => {
    if (err) {
      if (err.kind === "not_found") {
        res.status(404).send({ message: `No Player With the Position ${req.params.player_position} Was Found`});
      } else {
        res.status(500).send({ message: "Trouble Retrieving Player with the Position "});
      }
    } else res.send(data);
  });
};

export { findByPosition };