CREATE TABLE Department(
DeptId INT IDENTITY(1,1) CONSTRAINT PK_DEPT PRIMARY KEY,
DeptName NVARCHAR(50) NOT NULL,
CreatedBy NVARCHAR(50) NOT NULL,
CreatedAt DATETIME NOT NULL,
UpdatedBy NVARCHAR(50) NOT NULL,
UpdatedAt DATETIME NOT NULL
)

CREATE TABLE Employee(
EmpId INT IDENTITY(1,1) CONSTRAINT PK_EMP PRIMARY KEY,
EmpName NVARCHAR(50) NOT NULL,
EmpJoinDate DATETIME NOT NULL,
EmpExpierience DATETIME NOT NULL,
EmpDepartmentId INT NOT NULL,
EmpBirthDate DATETIME NOT NULL,
EmpSalary INT NOT NULL,
EmpEmailId NVARCHAR(50) NOT NULL,
EmpMobNo VARCHAR(10) CONSTRAINT CHECK_MOB CHECK (EmpMobNo NOT LIKE '%[^0-9]%') NOT NULL,
EmpGender VARCHAR(10),
CreatedBy NVARCHAR(50) NOT NULL,
CreatedAt DATETIME NOT NULL,
UpdatedBy NVARCHAR(50) NOT NULL,
UpdatedAt DATETIME NOT NULL
)

ALTER TABLE Employee WITH CHECK ADD CONSTRAINT FK_Department FOREIGN KEY(EmpDepartmentId) REFERENCES Department(DeptId)