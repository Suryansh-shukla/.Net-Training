Create Database appdb;
Go

Use appdb;
Go

CREATE TABLE Doctors (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Specialization NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(15)
);
GO

CREATE TABLE Patients (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Disease NVARCHAR(200),
    DoctorId INT,
    FOREIGN KEY (DoctorId) REFERENCES Doctors(Id)
);
GO