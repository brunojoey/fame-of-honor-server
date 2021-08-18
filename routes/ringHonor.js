const router = require('express').Router();
const ringHonorController = require("../controllers/ringHonorController");

// Matches with /api/ringHonor
router.route("/").get(ringHonorController.findAll);

// Matches with /api/ringHonor/:id
router.route("/:id").get(ringHonorController.findById);

module.exports = router;