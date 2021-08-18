const db = require("../database");

const RingHonor = function(ringHonor) {
  this.history = ringHonor.history;
  this.team_name = ringHonor.team_name;
};

RingHonor.findAll = result => {
  db.query("SELECT * FROM ringHonor", (err, res) => {
    if (err) {
      console.log("error: " , err);
      result(null, err);
      return;
    }
    console.log("Ring of Honors: ", res);
    result(null, res);
  });
};

RingHonor.findById = (result, ringHonorId) => {
  db.query(`SELECT * FROM ringHonor WHERE id = ${ringHonorId}`, (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(null, err);
      return;
    }
    if (res.length) {
      console.log("Found Ring of Honor: ", res[0]);
      result(null, res[0]);
      return;
    }

    result({ kind: "not_found" }, null);
  });
};


module.exports = RingHonor;