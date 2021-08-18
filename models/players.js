const db = require("../database");

const Players = function(players) {
  this.full_name = players.full_name;
  this.player_position = players.player_position;
  this.player_team = players.player_team;
  this.notes = players.notes;
  this.years_active = players.years_active;
  this.year_inducted = players.year_inducted;
};

Players.findAll = result => {
  db.query("SELECT * FROM players", (err, res) => {
    if (err) {
      console.log("error: " , err);
      result(null, err);
      return;
    }
    console.log("Players: ", res);
    result(null, res);
  });
};

Players.findById = (result, playerId) => {
  db.query(`SELECT * FROM players WHERE id = ${playerId}`, (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(null, err);
      return;
    }
    if (res.length) {
      console.log("Found Player: ", res[0]);
      result(null, res[0]);
      return;
    }

    result({ kind: "not_found" }, null);
  });
};


module.exports = Players;