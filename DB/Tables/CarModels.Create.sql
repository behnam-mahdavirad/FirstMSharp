-- CarModels Table ========================
CREATE TABLE CarModels (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Manufacturer uniqueidentifier  NOT NULL,
    Name nvarchar(200)  NOT NULL
);

