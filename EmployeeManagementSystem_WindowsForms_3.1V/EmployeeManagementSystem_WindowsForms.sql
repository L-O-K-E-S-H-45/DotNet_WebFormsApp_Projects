
select * from Employees;

-- Insert
create procedure usp_InsertEmployee(
@EmployeeId numeric,
@EmployeeName nvarchar(50),
@Address nvarchar(50),
@Salary numeric(18, 0),
@Role nvarchar(50)
)
as
begin
	begin try
		begin transaction
			insert into Employees(EmployeeId, EmployeeName, Address, Salary, Role)
			values (@EmployeeId, @EmployeeName, @Address, @Salary, @Role)
		commit transaction
	end try
	begin catch
		print ('Error in Insert Empployee');
		THROW;
	end catch
end;

exec usp_InsertEmployee 3, 'Karan', 'Mysore', 28400, 'Employee';

select * from Employees;

-- Update
alter procedure usp_UpdateEmployee(
@EmployeeId numeric,
@EmployeeName nvarchar(50),
@Address nvarchar(50),
@Salary numeric(18, 0),
@Role nvarchar(50)
)
as
begin
	begin try
			update Employees set EmployeeName = @EmployeeName , Address = @Address, Salary = @Salary, Role = @Role
			where EmployeeId = @EmployeeId;
	end try
	begin catch
		print ('Error in Update Empployee');
		THROW;
	end catch
end;

exec usp_UpdateEmployee 3, 'Arjun', 'Kolar', 20500, 'Clerk';

select * from Employees;

-- Delete
create procedure usp_DeleteEmployee(
@EmployeeId int
)
as
begin
	begin try
		begin transaction
			delete from Employees
			where EmployeeId = @EmployeeId
		commit transaction
	end try
	begin catch
		print ('Error in Delete Empployee');
		THROW;
	end catch
end

exec usp_DeleteEmployee 3;

select * from Employees;

-- Fetch
create proc usp_FetchEmployees
as
begin
	begin try
		begin transaction
			select * from Employees
		commit transaction
	end try
	begin catch
		print ('Error in Fetch Empployees');
		THROW;
	end catch
end

exec  usp_FetchEmployees;






