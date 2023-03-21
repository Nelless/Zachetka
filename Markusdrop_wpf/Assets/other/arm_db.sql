USE [arm_db]
GO
/****** Object:  Table [dbo].[company_areas]    Script Date: 21.03.2023 14:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[company_areas](
	[id_area] [int] NOT NULL,
	[area_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_company-areas] PRIMARY KEY CLUSTERED 
(
	[id_area] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[company_task]    Script Date: 21.03.2023 14:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[company_task](
	[id_task] [int] NOT NULL,
	[task_name] [varchar](100) NULL,
	[task_startdate] [datetime] NULL,
	[task_enddate] [datetime] NULL,
 CONSTRAINT [PK_company_task] PRIMARY KEY CLUSTERED 
(
	[id_task] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee_task]    Script Date: 21.03.2023 14:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_task](
	[id_employee_task] [int] NOT NULL,
	[employee_id] [int] NULL,
	[task_id] [int] NULL,
 CONSTRAINT [PK_employee_task] PRIMARY KEY CLUSTERED 
(
	[id_employee_task] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_auth]    Script Date: 21.03.2023 14:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_auth](
	[id_user_auth] [int] NOT NULL,
	[id_user] [int] NULL,
	[id_user_role_fk] [int] NULL,
	[login] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_users_1] PRIMARY KEY CLUSTERED 
(
	[id_user_auth] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_role]    Script Date: 21.03.2023 14:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_role](
	[id_user_role] [int] NOT NULL,
	[user_role_name] [varchar](50) NULL,
 CONSTRAINT [PK_user_role] PRIMARY KEY CLUSTERED 
(
	[id_user_role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 21.03.2023 14:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id_users] [int] NOT NULL,
	[first_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[patronimyc] [varchar](50) NULL,
	[phone] [varchar](11) NULL,
	[passport_code] [varchar](4) NULL,
	[passport_number] [varchar](6) NULL,
	[INN] [varchar](12) NULL,
	[SNILS] [varchar](12) NULL,
	[email] [nvarchar](256) NULL,
	[area_id_fk] [int] NULL,
 CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
(
	[id_users] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[employee_task]  WITH CHECK ADD  CONSTRAINT [FK_employee_task_company_task] FOREIGN KEY([task_id])
REFERENCES [dbo].[company_task] ([id_task])
GO
ALTER TABLE [dbo].[employee_task] CHECK CONSTRAINT [FK_employee_task_company_task]
GO
ALTER TABLE [dbo].[employee_task]  WITH CHECK ADD  CONSTRAINT [FK_employee_task_employees] FOREIGN KEY([employee_id])
REFERENCES [dbo].[users] ([id_users])
GO
ALTER TABLE [dbo].[employee_task] CHECK CONSTRAINT [FK_employee_task_employees]
GO
ALTER TABLE [dbo].[user_auth]  WITH CHECK ADD  CONSTRAINT [FK_user_auth_user_role] FOREIGN KEY([id_user_role_fk])
REFERENCES [dbo].[user_role] ([id_user_role])
GO
ALTER TABLE [dbo].[user_auth] CHECK CONSTRAINT [FK_user_auth_user_role]
GO
ALTER TABLE [dbo].[user_auth]  WITH CHECK ADD  CONSTRAINT [FK_user_auth_users] FOREIGN KEY([id_user])
REFERENCES [dbo].[users] ([id_users])
GO
ALTER TABLE [dbo].[user_auth] CHECK CONSTRAINT [FK_user_auth_users]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_employees_company_areas] FOREIGN KEY([area_id_fk])
REFERENCES [dbo].[company_areas] ([id_area])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_employees_company_areas]
GO
