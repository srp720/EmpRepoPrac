CREATE PROCEDURE sp_employeefilter
	@StartJoinDate DATETIME = NULL,
	@EndJoinDate DATETIME = NULL,
	@StartXp DECIMAL(6,2) = NULL,
	@EndXp DECIMAL(6,2) = NULL,
	@StartEmpId INT = NULL,
	@EndEmpId INT = NULL,
	@Department NVARCHAR(50) = NULL,
	@StartSalary INT = NULL,
	@EndSalary INT = NULL,
	@EmpName NVARCHAR(50) = NULL

AS
BEGIN
	SELECT 
		E.EmpId,
		E.EmpName, 
		E.EmpJoinDate, 
		E.EmpExpierience,
		E.EmpSalary,
		D.DeptName 
	FROM Employee E JOIN Department D 
		ON E.EmpDepartmentId=D.DeptId 
	WHERE 
		((@StartJoinDate IS NULL OR EmpJoinDate >= @StartJoinDate) AND (@EndJoinDate IS NULL OR EmpJoinDate <= @EndJoinDate))
		AND ((@StartXp IS NULL OR EmpExpierience >= @StartXp) AND (@EndXp IS NULL OR EmpExpierience <= @EndXp))
		AND ((@StartEmpId IS NULL OR EmpId >= @StartEmpId) AND (@EndEmpId IS NULL OR EmpId <= @EndEmpId))
		AND ((@StartSalary IS NULL OR EmpSalary >= @StartSalary) AND (@EndSalary IS NULL OR EmpSalary <= @EndSalary))
		AND (@EmpName IS NULL OR EmpName LIKE '%'+@EmpName+'%')
END
GO