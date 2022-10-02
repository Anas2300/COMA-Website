-- *************************************************************
-- DATABASE desing for Capstone project
-- *************************************************************


CREATE DATABASE onMusicians;

-- select the database
USE onMusicians;

-- create the tables
CREATE TABLE person
(
  member_id   INT  PRIMARY KEY,
  first_name   VARCHAR(50) NOT NULL,
  last_name   VARCHAR(50),
  association_date DATE,
  email VARCHAR(50) NOT NULL,
  request INT DEFAULT 0,
  balance_due INT DEFAULT 0
);

CREATE TABLE status
(
  status_id   INT    PRIMARY KEY AUTO_INCREMENT,
  status   VARCHAR(50)
);


CREATE TABLE person_music_association
(
  person_music_association_id   INT PRIMARY KEY AUTO_INCREMENT,
  member_id  INT NOT NULL,
  member_name VARCHAR(50) NOT NULL,
  music_association_name VARCHAR(50) NOT NULL
);

CREATE TABLE music_association
(
  music_association_id   INT PRIMARY KEY AUTO_INCREMENT,
  music_association_name VARCHAR(50) NOT NULL,
  music_association_genre VARCHAR(50)
);


CREATE TABLE person_instrument
(
  member_instrument_id    INT  PRIMARY KEY AUTO_INCREMENT,
  member_id   INT NOT NULL,
  instrument  VARCHAR(50) NOT NULL
);

CREATE TABLE instrument
(
  instrument_id    INT  PRIMARY KEY AUTO_INCREMENT,
  instrument_name  VARCHAR(50) NOT NULL
);

CREATE TABLE phone
(
  phone_number    INT  PRIMARY KEY,
  phone_type  VARCHAR(50),
  member_id INT NOT NULL
);

CREATE TABLE phone_type
(
  phone_type_id    INT  PRIMARY KEY AUTO_INCREMENT,
  phone_type  VARCHAR(50) NOT NULL
);

-- insert rows into the tables
INSERT INTO person VALUES
(0001,'Jimmy','Page','1970-04-08','jimmy@led.com',0,0), 
(0002,'Freddie','Mercury','1977-04-08','fmercury@queen.com',0,0);

INSERT INTO status VALUES
(1,'adminin'), 
(2,'member'),
(3,'user');

INSERT INTO person_music_association VALUES
(1,'Led Zepellin','rock'), 
(2,'Queen','rock');

INSERT INTO music_association VALUES
(1,0001,'Jimmy','Led Zepellin'), 
(2,0002,'Freddie','Queen');

INSERT INTO instrument VALUES
(1,'guitar'), 
(2,'vocal');

INSERT INTO person_instrument VALUES
(1,0001,'guitar'), 
(2,0002,'vocal');

INSERT INTO phone_type VALUES
(1,'mobile'), 
(2,'Work');

INSERT INTO phone VALUES
(1231231234,'mobile',0001),
(9879879876,'work',0001), 
(123456789,'mobile',0002), 
(33415727,'mobile',0002);



