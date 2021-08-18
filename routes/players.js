const router = require('express').Router();
const playersController = require("../controllers/playersController");

// Matches with /api/players
router.route("/").get(playersController.findAll);

// Matches with /api/players/:id
router.route("/:id").get(playersController.findById);

module.exports = router;