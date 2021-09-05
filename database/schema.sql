DROP DATABASE IF EXISTS heroku_5d8ce2984bd7118;
CREATE DATABASE heroku_5d8ce2984bd7118;

USE heroku_5d8ce2984bd7118;

CREATE TABLE team (
  id INT(100) AUTO_INCREMENT,
  team_name VARCHAR(50) UNIQUE,
  history VARCHAR(500) NOT NULL,
  logo VARCHAR(100) NOT NULL,
  color VARCHAR(25) NOT NULL,
  border_color VARCHAR(25) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE players (
  id INT(100) AUTO_INCREMENT,
  full_name VARCHAR(100),
  player_position VARCHAR(100) NULL,
  team_name VARCHAR(50),
  notes VARCHAR(255) NULL,
  years_active VARCHAR(50),
  year_inducted YEAR NULL,
  PRIMARY KEY (id)
);

SELECT * FROM team;
SELECT * FROM players;