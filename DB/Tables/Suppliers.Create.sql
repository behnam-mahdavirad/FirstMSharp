-- Suppliers Table ========================
CREATE TABLE Suppliers (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    CompanyName nvarchar(200)  NULL,
    Address nvarchar(200)  NULL
);

