﻿CREATE TABLE [dbo].[TraderList]
(
	[trader_id] INT NOT NULL PRIMARY KEY, 
    [username] VARCHAR(100) NOT NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [deleted] BINARY(1) NOT NULL, 
    [classSchedule] NCHAR(10) NULL
)