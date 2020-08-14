-- Products Table ========================
CREATE TABLE Products (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    ProductName nvarchar(200)  NOT NULL,
    Category uniqueidentifier  NOT NULL,
    Supplier uniqueidentifier  NOT NULL
);

