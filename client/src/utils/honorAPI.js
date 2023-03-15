import httpConfig from "./httpConfig.js";

const getTeams = () => {
  return httpConfig.get("/teams");
};

const getTeam = (id) => {
  return httpConfig.get(`/teams/${id}`);
};

const getTeamInductees = (id) => {
  return httpConfig.get(`/teams/${id}/inductees`);
};

const getPlayersByPosition = (player_position) => {
  return httpConfig.get(`/positions/${player_position}`);
};

const honorAPI = { getTeams, getTeam, getTeamInductees, getPlayersByPosition };

export default honorAPI;