CREATE DATABASE Provivi;

USE [Provivi]

GO

CREATE SEQUENCE dbo.MathOperations_SEQ  
    START WITH 1  
    INCREMENT BY 1; 

GO

CREATE TABLE dbo.MathOperations (
    MathOperationsId int,
	Operation varchar(255),
    Result float,
	CreatedDatetime datetime,
	PRIMARY KEY (MathOperationsId),
);

GO



CREATE PROCEDURE dbo.InsertMathOperation
(
    @Operation varchar(50),
    @Result varchar(50)
)
AS
BEGIN

    INSERT INTO dbo.MathOperations (MathOperationsId, Operation, Result, CreatedDatetime) 
    VALUES (NEXT VALUE FOR MathOperations_SEQ, @Operation, @Result, GETDATE());

END