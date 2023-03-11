DROP TABLE countries;

DROP TABLE continents;

CREATE TABLE continents
(
	Id SERIAL PRIMARY KEY NOT NULL,
	name char(50),
	description char(50)
);

CREATE TABLE countries
(
	Id SERIAL PRIMARY KEY NOT NULL,
	Name char(50),
	Continent_id int,
	Lenguage char(50),
	Population int
);

INSERT INTO continents (Name)
VALUES ('America');

INSERT INTO continents (Name)
VALUES ('Europe');

INSERT INTO continents (Name)
VALUES ('Asia');

INSERT INTO continents (Name)
VALUES ('Africa');

INSERT INTO continents (Name)
VALUES ('Oceania');

ALTER TABLE countries ADD CONSTRAINT "fk_continent_countries"
    FOREIGN KEY (Continent_id) REFERENCES continents (Id);
