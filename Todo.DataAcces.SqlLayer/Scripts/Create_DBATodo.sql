USE master
GO
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'TodoTaskDB'
)
CREATE DATABASE TodoTaskDB
ON PRIMARY(
    name='TodoTaskDB_Primary',
	filename='C:\CursoSqlServer2017\Todo\Data\MDF\TodoTaskDB.mdf',
	size=4MB,
	maxsize=10MB,
	filegrowth=1MB),
FILEGROUP TodoTaskDB_FG1
  ( NAME = 'TodoTaskDB_FG1_Dat1',
    FILENAME =
       'C:\CursoSqlServer2017\Todo\Data\NDF\TodoTaskDB_FG1_1.ndf',
    SIZE = 1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB),
  ( NAME = 'TodoTaskDB_FG1_Dat2',
    FILENAME =
       'C:\CursoSqlServer2017\Todo\Data\NDF\TodoTaskDB_FG1_2.ndf',
    SIZE = 1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB)
LOG ON(
	name=TodoTaskDB_log,
	filename='C:\CursoSqlServer2017\Todo\Data\LDF\TodoTaskDB_log.ldf',
	size=2MB, 
	maxsize=2MB,
	filegrowth=0MB
	)
	COLLATE modern_spanish_ci_as
GO