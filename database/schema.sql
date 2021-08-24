DROP DATABASE IF EXISTS ringHonorDB;
CREATE DATABASE ringHonorDB;

USE ringHonorDB;

CREATE TABLE team (
  id INT(100) AUTO_INCREMENT,
  team_name VARCHAR(50) UNIQUE,
  history VARCHAR(500) NOT NULL,
  logo VARCHAR(100) NOT NULL,
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

/* ALTER TABLE players
ADD FOREIGN KEY (team_name) REFERENCES team(team_name); */

SELECT * FROM team;
SELECT * FROM players;