import connection from "../database/connection.js";

const RingHonor = function(ringHonor) {
  this.history = ringHonor.history;
  this.team_name = ringHonor.team_name;
};

RingHonor.findAll = result => {
  connection.query("SELECT * FROM ringHonor", (err, res) => {
    if (err) {
      console.log("error: " , err);
      result(null, err);
      return;
    }
    console.log("Ring of Honors: ", res);
    result(null, res);
  });
};

RingHonor.findById = (ringHonorId, result) => {
  connection.query(`SELECT * FROM ringHonor WHERE id = ${ringHonorId}`, (err, res) => {
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


export default RingHonor;