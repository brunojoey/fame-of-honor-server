import express from "express";
const router = express.Router();

import { findAll, findById } from "../controllers/teamsController.js";

// Matches with /api/teams
router.route("/").get(findAll);

// Matches with /api/teams/:id
router.route("/:teamId").get(findById);

export default router;