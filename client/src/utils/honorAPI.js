import httpConfig from "./httpConfig.js";

const getTeams = () => {
  return httpConfig.get("/teams");
};

const getTeam = (teamId) => {
  return httpConfig.get("/teams/:teamId");
};

const getTeamInductees = (teamId) => {
  return httpConfig.get("/teams/:teamId/inductees");
};

const getPlayersByPosition = (player_position) => {
  return httpConfig.get("/positions/:player_position");
};

const honorAPI = { getTeams, getTeam, getTeamInductees, getPlayersByPosition };

export default honorAPI;