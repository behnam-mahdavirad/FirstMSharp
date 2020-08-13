ALTER TABLE CarModels ADD Constraint
                [FK_CarModel.Manufacturer]
                FOREIGN KEY (Manufacturer)
                REFERENCES Manufacturers (ID)
                ON DELETE NO ACTION;
GO