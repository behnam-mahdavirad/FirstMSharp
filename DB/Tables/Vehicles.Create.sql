-- Vehicles Table ========================
CREATE TABLE Vehicles (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Make nvarchar(200)  NOT NULL,
    Model nvarchar(200)  NOT NULL,
    RegistrationNumber int  NOT NULL
);

