drop table Employees

create table Employees (
	EmployeeId int primary key, 
	EmployeeName nvarchar(30) not null, 
	Email nvarchar(30), 
	Salary numeric(18, 0), 
	Gender nvarchar(10), 
	constraint chk_gender Check(Gender in ('Male', 'Female', 'Others')),
	Role nvarchar(20),
	constraint chk_role Check (Role in ('Backend Developer', 'Frontend Developer', 'FullStack Developer', 'Manager', 'H.R', 'CEO')));

Select * from Employees;



truncate table Employees

---------------------------
alter table Employees
add constraint chk_gender Check(Gender in ('Male', 'Female', 'Others')),
constraint chk_role Check (Role in ('Backend Developer', 'Frontend Developer', 'FullStack Developer', 'Manager', 'H.R', 'CEO'));

------- Insert
alter procedure usp_InsertEmployee(
@EmployeeId int,
@EmployeeName nvarchar(30),
@Email nvarchar(30),
@Salary numeric(18, 0),
@Gender nvarchar(10),
@Role nvarchar(20)
)
as
begin
	begin try
			insert into Employees(EmployeeId, EmployeeName, Email, Salary, Gender, Role)
			values (@EmployeeId, @EmployeeName, @Email, @Salary, @Gender, @Role)
	end try
	begin catch
			PRINT  'Error in Insert Employee';
			--print ERROR_Message();
			Throw;
	end catch
end;

exec usp_InsertEmployee 3,  'Allen', 'allen123@gmail.com', 20500, 'Female', 'Employee'
exec usp_InsertEmployee 1,  'Allen', 'allen123@gmail.com', 20500, 'Female', 'Frontend Developer'
exec usp_InsertEmployee 7,  'Scott', 'scott456@gmail.com', 46000, 'Male', 'Manager'

Select * from Employees;
drop procedure Employees

-- --------- Fetch
alter proc usp_FetchEmployees(
@EmployeeId int = null,
@EmployeeName nvarchar(30) = null,
@Email nvarchar(30) = null,
@Salary numeric(18, 0) = null,
@Gender nvarchar(10) = null,
@Role nvarchar(20) = null
)
as
begin
	begin try
		select * from Employees
		where ((@EmployeeId is null or EmployeeId =  @EmployeeId) and (@EmployeeName is null or EmployeeName = @EmployeeName) and 
		(@Email is null or Email = @Email) and (@Salary is null or Salary = @Salary) and (@Gender is null or Gender = @Gender) and 
		(@Role is null or Role = @Role))
	end try
	begin catch
		THROW;
	end catch
end;

exec  usp_FetchEmployees @EmployeeName = 'Allen'
exec  usp_FetchEmployees 1
exec  usp_FetchEmployees
exec  usp_FetchEmployees @Salary = 23100
exec  usp_FetchEmployees @Salary = 34000, @EmployeeId = 2

select * from Employees




-- Fetch by name
alter proc usp_FetchByEmployeeName(
@EmployeeName nvarchar(30)
)
as
begin 
	select * from Employees where EmployeeName = @EmployeeName;
end;

exec usp_FetchByEmployeeName 'Scott1'
exec usp_FetchByEmployeeName 'Scott'


select * from Employees




---- Fetch all Employees
create proc usp_FetchAllEmployees
as
begin
	select * from Employees;
end;

exec usp_FetchAllEmployees;

--------- Update
alter procedure usp_UpdateEmployee(
@EmployeeId int,
@EmployeeName nvarchar(30),
@Email nvarchar(30),
@Salary numeric(18, 0),
@Gender nvarchar(10),
@Role nvarchar(20)
)
as
begin
	begin try
		update Employees set EmployeeName = @EmployeeName, Email = @Email, Salary = @Salary, Gender =  @Gender, Role = @Role
		where EmployeeId = @EmployeeId
		--if (@@ROWCOUNT = 0)
		--begin
		--	declare @ErrorMessage nvarchar(100);
		--	set @ErrorMessage = FORMATMESSAGE(N'No rows were updated b/z Employee not fouund for id: %d', @EmployeeId);
		--	Throw 50001, @ErrorMessage, 1;
		--end
	end try
	begin catch
		--Print 'Error in Upadate Employee';
		--Throw;
	end catch
end;

drop proc usp_UpdateEmployee;

exec usp_UpdateEmployee 3, 'Allen', 'allen123@gmail.com', 42600, 'Male', 'dfbs'
exec usp_UpdateEmployee 1, 'Allen', 'allen123@gmail.com', 42600, 'Male', 'manager'

update Employees set Role = 'sjh' where EmployeeId = 1;

select * from Employees;

-------- Delete
alter procedure usp_DeleteEmployee(
@EmployeeId int
)
as
begin
	begin try
		delete from Employees
		where EmployeeId = @EmployeeId

		--if (XACT_STATE() = 0) 
		--IF (@@ROWCOUNT = 0)
		--begin
		--		declare @ErrorMessage nvarchar(100);
		--		set @ErrorMessage = FORMATMESSAGE(N'No rows were deleted b/z Employee not found for id: %d',@EmployeeId);
		--		--print FORMATMESSAGE(N'No rows were deleted b/z Employee not found for id: %d',@EmployeeId);
		--		--RAISERROR('Age must be between 18 and 65.', 16, 1);
		--		--RETURN;

		--		Throw 50001, @ErrorMessage, 1;
		--	end
	end try
	begin catch
		--Print ERROR_MESSAGE();
		--Print 'Error in Delete  Employee';
		--Throw;
	end catch
end;

exec usp_DeleteEmployee 7
exec usp_DeleteEmployee 1

select * from Employees;

