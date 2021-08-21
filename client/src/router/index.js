import { createRouter, createWebHistory } from "vue-router";
import Home from "../views/Home";
import Disclaimer from "../views/Disclaimer";

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
    path: "/ring-honor",
    name: "Ring of Honor",
    component: RingHonors
  },
  {
    path: "/ring-honor/:id",
    name: "Ring of Honor",
    component: RingHonor
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
  history: createWebHistory(process.env.BASE_URL), 
  routes
});

export default router;