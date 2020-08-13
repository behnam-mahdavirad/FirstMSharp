ALTER TABLE Customers ADD Constraint
                [FK_Customer.Country]
                FOREIGN KEY (Country)
                REFERENCES Countries (ID)
                ON DELETE NO ACTION;
GO