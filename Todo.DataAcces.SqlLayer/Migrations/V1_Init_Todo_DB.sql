USE TodoTaskDB 
IF OBJECT_ID('dbo.Task', 'U') IS NOT NULL
DROP TABLE dbo.Task
GO
-- Creamos la Tabla
CREATE TABLE dbo.Tasks
(
   Id  				INT NOT NULL  IDENTITY(1,1) PRIMARY KEY, -- Clave Primaria
   Guid             UNIQUEIDENTIFIER, 
   Title     		[NVARCHAR](50)  NOT NULL,
   Comment  		[NVARCHAR](100)  NOT NULL,
   DateCreate       [DATETIME] NOT NULL,
   DateFinal        [DATETIME] NOT NULL,
   DateUpdate       [DATETIME] NOT NULL
);
GO
