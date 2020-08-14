ALTER TABLE Products ADD Constraint
                [FK_Product.Category->ProductCategory]
                FOREIGN KEY (Category)
                REFERENCES ProductCategories (ID)
                ON DELETE NO ACTION;
GO
ALTER TABLE Products ADD Constraint
                [FK_Product.Suuplier->Supplier]
                FOREIGN KEY (Suuplier)
                REFERENCES Suppliers (ID)
                ON DELETE NO ACTION;
GO