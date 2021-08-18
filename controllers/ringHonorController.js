const ringHonor = require("../models/ringHonor");

module.exports = {
  findAll: function (req, res) {
    ringHonor.findAll((err, data) => {
      if (err) {
        res.status(500).send({
          message: err.message || "An error occured while retrieving Ring of Honors."
        });
      }
      else res.send(data);
    });
  }
};

module.exports = {
  findById: function(req,res) {
    ringHonor.findById((err, data) => {
      if (err) {
        if (err.kind === "not_found") {
          res.status(404).send({ message: `No Ring of Honor with id ${req.params.ringHonorId}.` })
        } else {
          res.status(500).send({ message: "Trouble retrieving Ring of Honor with the ID of " + req.params.ringHonorId });
        }
      } else res.send(data);
    });
  }
};