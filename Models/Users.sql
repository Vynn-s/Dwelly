CREATE TABLE [dbo].[users] (
    [user_id]        INT          IDENTITY (1, 1) NOT NULL,
    [user_username]  VARCHAR (50) NOT NULL,
    [user_password]  VARCHAR (50) NOT NULL,
    [user_birthday]  DATE         NOT NULL,
    [user_firstname] VARCHAR (50) NOT NULL,
    [user_lastname]  VARCHAR (50) NOT NULL,
    [user_email]     VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC),
    UNIQUE NONCLUSTERED ([user_email] ASC)
);

SET IDENTITY_INSERT [dbo].[users] ON
INSERT INTO [dbo].[users] ([user_id], [user_username], [user_password], [user_birthday], [user_firstname], [user_lastname], [user_email]) VALUES (1, N'Vynn', N'jAndoy123', N'2004-09-27', N'Jervin', N'Andoy', N'jAndoy@mcm.edu.ph')
INSERT INTO [dbo].[users] ([user_id], [user_username], [user_password], [user_birthday], [user_firstname], [user_lastname], [user_email]) VALUES (2, N'Shion', N'jrSabuero123', N'2004-09-01', N'Joshua', N'Sabuero', N'jrSabuero@mcm.edu.ph')
INSERT INTO [dbo].[users] ([user_id], [user_username], [user_password], [user_birthday], [user_firstname], [user_lastname], [user_email]) VALUES (3, N'Nilincoln', N'niSollano123', N'2004-09-10', N'Nepthali', N'Sollano', N'niSollano@mcm.edu.ph')
SET IDENTITY_INSERT [dbo].[users] OFF

