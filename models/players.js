import connection from "../database/connection.js";

const Players = function(players) {
  this.full_name = players.full_name;
  this.player_position = players.player_position;
  this.team_name = players.team_name;
  this.notes = players.notes;
  this.years_active = players.years_active;
  this.year_inducted = players.year_inducted;
};

Players.findAll = result => {
  connection.query("SELECT * FROM players", (err, res) => {
    if (err) {
      console.log("error: " , err);
      result(null, err);
      return;
    }
    console.log("Players: ", res);
    result(null, res);
  });
};

Players.findById = (playerId, result) => {
  connection.query(`SELECT * FROM players WHERE id = ${playerId}`, (err, res) => {
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

Players.findByPosition = (player_position, result) => {
  connection.query(`SELECT * FROM players WHERE players.player_position LIKE '%${player_position}%' `, (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(null, err);
      return;
    }
    if (res.length) {
      console.log("Found Position: ", res);
      result(null, res);
      return;
    }

    result({ kind: "not_found" }, null);
  });
};


export default Players;