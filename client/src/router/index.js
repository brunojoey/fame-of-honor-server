import { createRouter, createWebHistory } from "vue-router";

import Home from "../views/Home.vue"
import Teams from "../views/Teams.vue"
import Team from "../views/Team.vue"
import Players from "../views/Players.vue"
import Player from "../views/Player.vue"
import Disclaimer from "../views/Disclaimer.vue";

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home
  },
  {
    path: "/teams",
    name: "Teams",
    component: Teams
  },
  {
    path: "/teams/:id",
    name: "Team",
    component: Team
  },
  {
    path: "/players",
    name: "Players",
    component: Players
  },
  {
    path: "/players/:id",
    name: "Player",
    component: Player
  },
  {
    path: "/disclaimer",
    name: "Disclaimer",
    component: Disclaimer
  }
];

const router = createRouter({
  history: createWebHistory(process.env.baseURL), 
  routes
});

export default router