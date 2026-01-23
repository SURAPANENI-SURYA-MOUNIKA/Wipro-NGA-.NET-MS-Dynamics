create database EmployeeDB;
use EmployeeDB;


-- Create Employee table
CREATE TABLE Employees
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-generated Employee ID
    EmployeeName VARCHAR(100),                -- Employee Name
    Salary DECIMAL(10,2)                      -- Employee Salary
);


--US-1 Add New Employee & Return Employee ID
--Skill Focus: Insert Stored Procedure, Output Parameter
-- Stored procedure to insert a new employee
create Procedure sp_AddEmployee
(
    @EmployeeName VARCHAR(100),  -- Input: employee name
    @Salary DECIMAL(10,2),       -- Input: salary
    @NewEmployeeID INT OUTPUT    -- Output: newly created Employee ID
)
As
begin
    -- Insert employee data into Employees table
    Insert into Employees (EmployeeName, Salary)
    values (@EmployeeName, @Salary);

    -- Get the newly generated EmployeeID
  set  @NewEmployeeID = SCOPE_IDENTITY();
end;
select *from Employees;

-- Declare variable to hold output Employee ID
DECLARE @EmpID INT;
-- Execute stored procedure
EXEC sp_AddEmployee 
     @EmployeeName = 'Mounika',
     @Salary = 50000,
     @NewEmployeeID = @EmpID OUTPUT;
-- Display generated Employee ID
SELECT @EmpID AS NewEmployeeID;

select *from Employees;



--US-2: Validate Salary Before Insert
--IF-ELSE, Validation

-- Stored procedure with salary validation
CREATE PROCEDURE sp_AddEmployee_ValidateSalary
(
    @EmployeeName VARCHAR(100),
    @Salary DECIMAL(10,2)
)
AS
BEGIN
    -- Check if salary is valid
    IF (@Salary <= 0)
    BEGIN
        -- Stop execution if salary is invalid
        PRINT 'Salary must be greater than zero';
        RETURN;
    END

    -- Insert employee if salary is valid
    INSERT INTO Employees (EmployeeName, Salary)
    VALUES (@EmployeeName, @Salary);

    PRINT 'Employee inserted successfully';
END;

-- Invalid salary test
EXEC sp_AddEmployee_ValidateSalary 'Test User', -100;

-- Valid salary test
EXEC sp_AddEmployee_ValidateSalary 'Valid User', 30000;



--US-3 :Update Salary SP

-- Stored procedure to update employee salary
CREATE PROCEDURE sp_UpdateEmployeeSalary
(
    @EmployeeID INT,
    @NewSalary DECIMAL(10,2)
)
AS
BEGIN
    -- Check if employee exists
    IF EXISTS (SELECT 1 FROM Employees WHERE EmployeeID = @EmployeeID)
    BEGIN
        -- Update salary
        UPDATE Employees
        SET Salary = @NewSalary
        WHERE EmployeeID = @EmployeeID;

        PRINT 'Salary updated successfully';
    END
    ELSE
    BEGIN
        PRINT 'Employee does not exist';
    END
END;

-- Update existing employee
EXEC sp_UpdateEmployeeSalary 1, 60000;

-- Try updating non-existing employee
EXEC sp_UpdateEmployeeSalary 999, 50000;



--US-4: Atomic Salary Update Using Transaction
--Transactions (COMMIT / ROLLBACK)
-- Stored procedure with transaction handling
CREATE PROCEDURE sp_UpdateSalary_Transaction
(
    @EmployeeID INT,
    @NewSalary DECIMAL(10,2)
)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Update salary
        UPDATE Employees
        SET Salary = @NewSalary
        WHERE EmployeeID = @EmployeeID;

        -- Check if update happened
        IF (@@ROWCOUNT = 0)
        BEGIN
            -- No rows updated, rollback
            ROLLBACK;
            PRINT 'Update failed, employee not found';
            RETURN;
        END

        -- Commit transaction if successful
        COMMIT;
        PRINT 'Salary updated successfully with transaction';
    END TRY
    BEGIN CATCH
        -- Rollback if error occurs
        ROLLBACK;
        PRINT 'Error occurred, transaction rolled back';
    END CATCH
END;


-- Successful update
EXEC sp_UpdateSalary_Transaction 1, 70000;

-- Failed update
EXEC sp_UpdateSalary_Transaction 999, 80000;


--US-5: Retrieve Employee by ID
--Parameterized SELECT
-- Stored procedure to fetch employee details
CREATE PROCEDURE sp_GetEmployeeByID
(
    @EmployeeID INT
)
AS
BEGIN
    -- Retrieve employee record
    SELECT EmployeeID, EmployeeName, Salary
    FROM Employees
    WHERE EmployeeID = @EmployeeID;
END;


-- Get employee details
EXEC sp_GetEmployeeByID 1;
