﻿ALTER TABLE Cars ADD CONSTRAINT 
[FK_Car.Id->Vehicle] FOREIGN KEY (Id) 
REFERENCES Vehicles (ID)
 ON DELETE CASCADE;


GO