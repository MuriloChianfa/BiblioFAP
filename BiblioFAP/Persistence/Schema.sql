-- Creating the main database with name "BiblioFAP"
CREATE DATABASE bibliofap;

-- Creating the default user named "admin"
CREATE USER admin WITH LOGIN PASSWORD 'admin';

-- Granting all privileges to our user
GRANT ALL PRIVILEGES ON DATABASE bibliofap TO admin;

-- Conecting into database "bibliofap" with user "admin"
\c bibliofap admin;

