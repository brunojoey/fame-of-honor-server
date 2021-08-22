import http from "../http-config";

class DataService {
  getAllTeams() {
    return http.get("/teams");
  }
  
  getOneTeam(id) {
    return http.get(`/teams/${id}`);
  }

  getAllPlayers() {
    return http.get("/players");
  }

  getOnePlayer(id) {
    return http.get(`/players/${id}`)
  }
}

export default new DataService();