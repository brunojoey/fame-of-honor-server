import express from "express";
const router = express.Router();

import { findAll, findById } from "../controllers/playersController.js";

// Matches with /api/players
router.route("/").get(findAll);

// Matches with /api/players/:id
router.route("/:playerId").get(findById);

export default router;