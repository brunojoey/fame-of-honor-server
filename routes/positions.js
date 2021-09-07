import express from "express";
const router = express.Router();

import { findByPosition } from "../controllers/playersController.js";

// Matches with /api/positions/:player_position
router.route("/:player_position").get(findByPosition);

export default router;