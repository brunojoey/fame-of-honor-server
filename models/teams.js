const db = require("../database");

const Team = function(team) {
  this.team_name = team.team_name;
  this.logo = team.logo;
};

Team.findAll = result => {
  db.query("SELECT * FROM team", (err, res) => {
    if (err) {
      console.log("error: " , err);
      result(null, err);
      return;
    }
    console.log("teams: ", res);
    result(null, res);
  });
};

Team.findById = (result, teamId) => {
  db.query(`SELECT * FROM team WHERE id = ${teamId}`, (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(null, err);
      return;
    }
    if (res.length) {
      console.log("Found team: ", res[0]);
      result(null, res[0]);
      return;
    }

    result({ kind: "not_found" }, null);
  });
};

module.exports = Team;