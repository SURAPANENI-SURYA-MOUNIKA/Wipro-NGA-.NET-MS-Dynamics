create database StoredProcedureDB;
use StoredProcedureDB
--

CREATE TABLE Employees
(
    EmpId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Salary INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
);


--from here
-- Create stored procedure to add a new employee
CREATE PROCEDURE usp_AddEmployee
    @Name VARCHAR(50),     -- Input parameter for employee name
    @Salary INT,           -- Input parameter for salary
    @EMPID INT OUTPUT      -- Output parameter to return EmpId
AS
BEGIN
  -- TRY block starts (used to catch errors)
  BEGIN TRY
       -- Start transaction
        BEGIN TRANSACTION
        -- Insert employee data into Employees table

        INSERT INTO Employees (Name, Salary)
        VALUES (@Name, @Salary);
        -- Get the last inserted identity value (EmpId)

        SET @EMPID = SCOPE_IDENTITY();
        -- Commit transaction if no error

        COMMIT TRANSACTION
    END TRY
    -- CATCH block starts if any error occurs

    BEGIN CATCH
        -- Rollback transaction if error occurs

        ROLLBACK TRANSACTION
        -- Throw the error to the caller

        THROW;
    END CATCH
END;
--to here


--from here to
-- Declare a variable to store output EmpId
DECLARE @Id INT;
-- Execute stored procedure
EXEC usp_AddEmployee 
    @Name = 'Amit', -- Passing Name value
    @Salary = 50000, -- Passing Salary value
    @EMPID = @Id OUTPUT; ---- Receiving EmpId output
    --here

-- Display the newly generated EmpId
SELECT @Id AS NewEmployeeId;

SELECT * FROM Employees;
