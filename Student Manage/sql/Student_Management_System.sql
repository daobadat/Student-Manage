CREATE DATABASE Student_Management_System;
USE Student_Management_System; 

CREATE TABLE User_Table
(
	User_ID INT IDENTITY(1,1),
	User_Name VARCHAR(150) UNIQUE,
	User_Pass VARCHAR(150),
	User_Pho VARCHAR(15),
	User_CNIC VARCHAR(15) UNIQUE,
	User_DOB VARCHAR(15),
	User_Gender VARCHAR(6),
	User_Email VARCHAR(30),
	User_Role VARCHAR(5),
	User_Add VARCHAR(150),
	CONSTRAINT User_Table_PK PRIMARY KEY (User_ID)
);

INSERT INTO User_Table VALUES
('user','12345','+11 111 1111111', '11111-1111111-1','09/18/2023','Male','user@gmail.com','User','United State'),
('datdepzai','1234567','+22 222 2222222', '33333-3333333-3','09/18/2023','Male','admin@gmail.com','Admin','Viet Nam'),
('admin','12345678','+22 222 2222222', '22222-2222222-2','09/18/2023','Male','admin@gmail.com','Admin','Viet Nam');


CREATE TABLE Class_Table
(
	Class_ID int IDENTITY(1,1),
	Class_Name VARCHAR(150) UNIQUE,
	Class_Total INT,
	Class_Male INT,
	Class_Female INT,
	CONSTRAINT Class_Table_PK PRIMARY KEY (Class_ID)
);

CREATE TABLE Student_Table
(
	Student_ID INT IDENTITY(1,1),
	Student_Name VARCHAR(150),
	Student_Reg VARCHAR(50) UNIQUE,
	Student_Gender VARCHAR(10),
	Class_ID INT,
	Student_Phone INT,
	Student_BD VARCHAR(50),
	Student_MSSV INT,
	Student_Email VARCHAR(50),
	CONSTRAINT Student_Table_PK PRIMARY KEY (Student_ID),
	CONSTRAINT Student_Table_FK FOREIGN KEY (Class_ID) REFERENCES Class_Table (Class_ID) ON DELETE CASCADE
);