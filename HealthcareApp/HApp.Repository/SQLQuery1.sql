CREATE TABLE EMR
(
EMRID	uniqueidentifier primary key,
Ehistory	text
)

CREATE TABLE Patient
(
PID	uniqueidentifier primary key,
Pname	nvarchar(20),
Pprikey	nvarchar(20),
Ppubkey	nvarchar(20),
SessionKey nvarchar(20),
EID uniqueidentifier FOREIGN KEY REFERENCES EMR(EMRID)
)

CREATE TABLE Doctor
(
DID	uniqueidentifier primary key,
Dname	nvarchar(20),
Dprikey	nvarchar(20),
Dpubkey	nvarchar(20),
)

CREATE TABLE Query
(
EID uniqueidentifier FOREIGN KEY REFERENCES EMR(EMRID),
DID uniqueidentifier FOREIGN KEY REFERENCES Doctor(DID),
SessionKey nvarchar(20)
)

CREATE TABLE Code
(
Cprikey	nvarchar(20),
Cpubkey	nvarchar(20),
SessionKey nvarchar(20)
)

CREATE TABLE Session
(
PID uniqueidentifier FOREIGN KEY REFERENCES Patient(PID),
DID uniqueidentifier FOREIGN KEY REFERENCES Doctor(DID),
Date datetime primary key
)
