CREATE DATABASE dbCustomerRegister
GO

USE dbCustomerRegister
GO

CREATE TABLE Customer (
    CustomerId INT PRIMARY KEY IDENTITY(1,1),
    CusName VARCHAR(255),
    CusPhoneNumber VARCHAR(20),
    CusAddress VARCHAR(255),
    CusEmail VARCHAR(255)
);
GO

INSERT INTO Customer (CusName, CusPhoneNumber, CusAddress, CusEmail)
VALUES
    ('John Doe', '1234567890', '123 Main Street, City', 'john.doe@example.com'),
    ('Jane Smith', '9876543210', '456 Elm Street, Town', 'jane.smith@example.com'),
    ('Michael Johnson', '5551234567', '789 Oak Street, Village', 'michael.johnson@example.com');
GO

