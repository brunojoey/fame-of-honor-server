import { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router-dom";
import honorAPI from "../utils/honorAPI";

const Position = () => {
  const [position, setPosition] = useState([]);
  let params = useParams();
  console.log("params", params)
  const { player_position } = params;

  useEffect(() => {
    async function fetchData() {
      const { data } = await honorAPI.getPlayersByPosition(player_position);
      console.log("data", data);
      setPosition(data);
    };
    fetchData();
  });

  return (
    <div>
      <h1>{player_position}'s</h1>
      <div className="position-list">
        {position.map((player) => {
          return (
            <div className="position-card" key={player.id}>
              <h3>{player.full_name}</h3>
              <p>Player Position: {player.player_position}</p>
              <p>Inducted By: {player.team_name}</p>
              {player.year_inducted ? <p>Year Inducted: {player.year_inducted}</p> : <></>}
              <p>Years Active: {player.years_active}</p>
              {player.notes ? <p>Notes: {player.notes}</p> : <></>}
            </div>
          )
        })}
      </div>
    </div>
  )
};

export default Position;