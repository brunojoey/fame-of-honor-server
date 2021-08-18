const router = require('express').Router();
const teamsController = require("../controllers/teamsController");

// Matches with /api/teams
router.route("/").get(teamsController.findAll);

// Matches with /api/teams/:id
router.route("/:id").get(teamsController.findById);

module.exports = router;