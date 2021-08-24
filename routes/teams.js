import express from "express";
const router = express.Router();

import { findAll, findById, findByTeam } from "../controllers/teamsController.js";

// Matches with /api/teams
router.route("/").get(findAll);

// Matches with /api/teams/:id
router.route("/:teamId").get(findById);

// Matches with /api/teams/:id/inductees
router.route("/:teamId/inductees").get(findByTeam);

export default router;