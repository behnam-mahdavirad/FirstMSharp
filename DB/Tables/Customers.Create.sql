-- Customers Table ========================
CREATE TABLE Customers (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Country uniqueidentifier  NULL,
    CompanyName nvarchar(200)  NULL,
    ContractStartDate datetime2  NULL,
    Logo_FileName nvarchar(1500)  NULL,
    Contract_FileName nvarchar(1500)  NULL
);

