-- Creating the main database with name "BiblioFAP"
CREATE DATABASE BiblioFAP;

-- Creating the default user named "admin"
CREATE USER admin WITH LOGIN PASSWORD 'admin';

-- Granting all privileges to our user
GRANT ALL PRIVILEGES ON DATABASE BiblioFAP TO admin;

-- Conecting into database "BiblioFAP" with user "admin"
\c BiblioFAP admin;

