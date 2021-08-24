import express from "express";
const router = express.Router();

import { findByPosition } from "../controllers/playersController.js";

router.route("/:player_position").get(findByPosition);

export default router;