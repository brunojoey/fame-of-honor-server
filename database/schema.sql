DROP DATABASE IF EXISTS ringHonorDB;
CREATE DATABASE ringHonorDB;

USE ringHonorDB;

CREATE TABLE ringHonor (
  id INT(100) AUTO_INCREMENT,
  history VARCHAR(255) NOT NULL,
  team_name VARCHAR(50) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE team (
  id INT(100) AUTO_INCREMENT,
  team_name VARCHAR(50) NOT NULL,
  logo VARCHAR(100) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE players (
  id INT(1000) AUTO_INCREMENT,
  full_name VARCHAR(50) NOT NULL,
  player_position VARCHAR(50) NOT NULL,
  player_team VARCHAR(50) NOT NULL,
  notes VARCHAR(50) NULL,
  years_active VARCHAR(50) NOT NULL,
  year_inducted YEAR NULL,  --YEAR implicitly displays a width of 4 characters
  PRIMARY KEY (id)
);

ALTER TABLE team 
ADD FOREIGN KEY (team_name) REFERENCES ringHonor(team_name) ON DELETE SET NULL;

ALTER TABLE players
ADD FOREIGN KEY (player_team) REFERENCES team(team_name) ON DELETE SET NULL;

SELECT * FROM ringHonor;
SELECT * FROM team;
SELECT * FROM players;