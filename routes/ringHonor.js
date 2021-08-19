import express from "express";
const router = express.Router();

import { findAll, findById } from "../controllers/ringHonorController.js";

// Matches with /api/ringHonor
router.route("/").get(findAll);

// Matches with /api/ringHonor/:id
router.route("/:ringHonorId").get(findById);

export default router;