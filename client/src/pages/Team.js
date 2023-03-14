import { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router-dom";
import honorAPI from "../utils/honorAPI";

const Team = () => {
  const [team, setTeam] = useState({});
  const [teamInductees, setTeamInductees] = useState([])
  let params = useParams();
  const { id } = params;

  useEffect(() => {
    async function fetchTeamData() {
      const { data } = await honorAPI.getTeam(id);
      console.log("cd data", data)
      setTeam(data);
    }

    async function fetchInducteeData() {
      const { data } = await honorAPI.getTeamInductees(id);
      console.log("data inductee", data)
      setTeamInductees(data);
    }
    fetchTeamData();
    fetchInducteeData();
  })

  return (
    <div className="team">
      <h1 style={{color: team.color}}>{team.team_name}</h1>
      <div className="team-info">
        <img src={team.logo} alt={team.team_name + " logo"} width="300px"/>
        <p>{team.history}</p>
      </div>
      <h2 style={{color: team.color}}>Team Inductees</h2>
      <div className="inductee-list">
        {teamInductees.map((inductee) => {
          return (
          <div className="inductee-card" style={{backgroundColor: team.color, borderColor: team.border_color}} key={inductee.full_name}>
            <h3>{inductee.full_name}</h3>
            <p>Player Position: {inductee.player_position}</p>
            {inductee.year_inducted ? <p>Year Inducted: {inductee.year_inducted}</p> : <></>}
            <p>Years Active: {inductee.years_active}</p>
            {inductee.notes ? <p>Notes: {inductee.notes}</p> : <></>}
          </div>
          )
        })}
      </div>
    </div>
  )
};

export default Team;