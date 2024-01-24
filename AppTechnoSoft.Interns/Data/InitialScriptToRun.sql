IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Batches] (
    [Id] int NOT NULL IDENTITY,
    [Start] datetime2 NOT NULL,
    [End] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Batches] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Colleges] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Location] nvarchar(max) NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Colleges] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [FinAccounts] (
    [Id] int NOT NULL IDENTITY,
    [FeeAmount] real NOT NULL,
    [Discount] real NOT NULL,
    [PaidAmount] real NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_FinAccounts] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Roles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Tags] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NULL,
    [ColorCode] nvarchar(max) NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Tags] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [TechPrograms] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Affliation] nvarchar(max) NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_TechPrograms] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Users] (
    [Id] nvarchar(450) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Widgets] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [HtmlContent] nvarchar(max) NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Widgets] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Teams] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [ProjectTitle] nvarchar(max) NULL,
    [ProjectDetails] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [BatchId] int NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Teams] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Teams_Batches_BatchId] FOREIGN KEY ([BatchId]) REFERENCES [Batches] ([Id])
);
GO

CREATE TABLE [RoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_RoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_RoleClaims_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_UserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserClaims_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_UserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_UserLogins_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserRole] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_UserRole] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_UserRole_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserRole_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_UserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_UserTokens_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [TagWidget] (
    [TagsId] int NOT NULL,
    [WidgetsId] int NOT NULL,
    CONSTRAINT [PK_TagWidget] PRIMARY KEY ([TagsId], [WidgetsId]),
    CONSTRAINT [FK_TagWidget_Tags_TagsId] FOREIGN KEY ([TagsId]) REFERENCES [Tags] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TagWidget_Widgets_WidgetsId] FOREIGN KEY ([WidgetsId]) REFERENCES [Widgets] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Students] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Phone] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [WebExperience] int NOT NULL,
    [DbExperience] int NOT NULL,
    [FormSubmitted] datetime2 NULL,
    [Status] int NOT NULL,
    [ProfileImagePath] nvarchar(max) NULL,
    [CollegeId] int NOT NULL,
    [TechProgramId] int NOT NULL,
    [FinAccountId] int NULL,
    [TeamId] int NULL,
    [ApplicationUserId] nvarchar(450) NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Students_Colleges_CollegeId] FOREIGN KEY ([CollegeId]) REFERENCES [Colleges] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Students_FinAccounts_FinAccountId] FOREIGN KEY ([FinAccountId]) REFERENCES [FinAccounts] ([Id]),
    CONSTRAINT [FK_Students_Teams_TeamId] FOREIGN KEY ([TeamId]) REFERENCES [Teams] ([Id]),
    CONSTRAINT [FK_Students_TechPrograms_TechProgramId] FOREIGN KEY ([TechProgramId]) REFERENCES [TechPrograms] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Students_Users_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [Users] ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Created', N'CreatedBy', N'LastUpdated', N'LastUpdatedBy', N'Location', N'Name') AND [object_id] = OBJECT_ID(N'[Colleges]'))
    SET IDENTITY_INSERT [Colleges] ON;
INSERT INTO [Colleges] ([Id], [Created], [CreatedBy], [LastUpdated], [LastUpdatedBy], [Location], [Name])
VALUES (1, '2024-01-23T21:26:33.4545562+05:45', NULL, NULL, NULL, N'Bhadrapur, Jhapa', N'Mechi Multiple Campus'),
(2, '2024-01-23T21:26:33.4545580+05:45', NULL, NULL, NULL, N'Dhankuta', N'Dhankuta Multiple Campus'),
(3, '2024-01-23T21:26:33.4545581+05:45', NULL, NULL, NULL, N'Dharan', N'Central Campus of Technology'),
(4, '2024-01-23T21:26:33.4545582+05:45', NULL, NULL, NULL, N'Biratnagar', N'Mahendra Morang Adarsha Multiple Campus'),
(5, '2024-01-23T21:26:33.4545583+05:45', NULL, NULL, NULL, N'Rajbiraj', N'Mahendra Bindeshwori Multiple Campus'),
(6, '2024-01-23T21:26:33.4545584+05:45', NULL, NULL, NULL, N'Siraha', N'Surya Narayan Satya Na. Mo. Yadav Campus'),
(7, '2024-01-23T21:26:33.4545585+05:45', NULL, NULL, NULL, N'Janakpur', N'Ramsorup Ramsagar Multiple Campus'),
(8, '2024-01-23T21:26:33.4545586+05:45', NULL, NULL, NULL, N'Birgunj', N'Thakur Ram Multiple Campus'),
(9, '2024-01-23T21:26:33.4545587+05:45', NULL, NULL, NULL, N'Bharatpur', N'Birendra Multiple Campus'),
(10, '2024-01-23T21:26:33.4545587+05:45', NULL, NULL, NULL, N'Pokhara', N'Prithivi Narayan Multiple Campus'),
(11, '2024-01-23T21:26:33.4545588+05:45', NULL, NULL, NULL, N'Mahendranagar', N'SidhaNath Science Campus'),
(12, '2024-01-23T21:26:33.4545589+05:45', NULL, NULL, NULL, N'Nepalgunj', N'Mahendra Multiple Campus'),
(13, '2024-01-23T21:26:33.4545590+05:45', NULL, NULL, NULL, N'Butwal', N'Butwal Multiple Campus'),
(14, '2024-01-23T21:26:33.4545590+05:45', NULL, NULL, NULL, N'Palpa', N'Tribhuvan Multiple Campus'),
(15, '2024-01-23T21:26:33.4545591+05:45', NULL, NULL, NULL, N'Ghantaghar', N'Tri-Chandra Multiple Campus'),
(16, '2024-01-23T21:26:33.4545592+05:45', NULL, NULL, NULL, N'Lainchour', N'Amrit Science Campus'),
(17, '2024-01-23T21:26:33.4545593+05:45', NULL, NULL, NULL, N'Patan', N'Patan Multiple Campus'),
(18, '2024-01-23T21:26:33.4545593+05:45', NULL, NULL, NULL, N'Bhaktapur', N'Bhaktapur Multiple Campus'),
(19, '2024-01-23T21:26:33.4545594+05:45', NULL, NULL, NULL, N'Bagbazar', N'Padma Kanya Multiple Campus'),
(20, '2024-01-23T21:26:33.4545595+05:45', NULL, NULL, NULL, N'Ghorahi, Dang', N'Mahendra Multiple Campus'),
(21, '2024-01-23T21:26:33.4545596+05:45', NULL, NULL, NULL, N'Baglung', N'Dhaulagiri Campus'),
(22, '2024-01-23T21:26:33.4545597+05:45', NULL, NULL, NULL, N'Gorkha', N'Gorkha Campus'),
(23, '2024-01-23T21:26:33.4545598+05:45', NULL, NULL, NULL, N'Bhairahawa', N'Bhairahawa Multiple Campus'),
(24, '2024-01-23T21:26:33.4545599+05:45', NULL, NULL, NULL, N'Biratnagar', N'Degree Campus');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Created', N'CreatedBy', N'LastUpdated', N'LastUpdatedBy', N'Location', N'Name') AND [object_id] = OBJECT_ID(N'[Colleges]'))
    SET IDENTITY_INSERT [Colleges] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'ce0d64ac-354d-4ade-8ed8-991be51234eb', N'ce0d64ac-354d-4ade-8ed8-991be51234eb', N'Admin', N'ADMIN'),
(N'ce2e0bd6-7aac-42ff-8cee-5d6e95d556dc', N'ce2e0bd6-7aac-42ff-8cee-5d6e95d556dc', N'SuperAdmin', N'SUPERADMIN'),
(N'f5230dfc-941b-4e51-9ae2-c99e09c3a8c9', N'f5230dfc-941b-4e51-9ae2-c99e09c3a8c9', N'Trainee', N'TRAINEE');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Affliation', N'Created', N'CreatedBy', N'LastUpdated', N'LastUpdatedBy', N'Name') AND [object_id] = OBJECT_ID(N'[TechPrograms]'))
    SET IDENTITY_INSERT [TechPrograms] ON;
INSERT INTO [TechPrograms] ([Id], [Affliation], [Created], [CreatedBy], [LastUpdated], [LastUpdatedBy], [Name])
VALUES (1, N'TU', '2024-01-23T21:26:33.4545789+05:45', NULL, NULL, NULL, N'BCA'),
(2, N'PU', '2024-01-23T21:26:33.4545792+05:45', NULL, NULL, NULL, N'BCA'),
(3, N'TU', '2024-01-23T21:26:33.4545793+05:45', NULL, NULL, NULL, N'BIT'),
(4, N'PU', '2024-01-23T21:26:33.4545794+05:45', NULL, NULL, NULL, N'BIT'),
(5, N'TU', '2024-01-23T21:26:33.4545795+05:45', NULL, NULL, NULL, N'BIM'),
(6, N'TU', '2024-01-23T21:26:33.4545796+05:45', NULL, NULL, NULL, N'BScIT'),
(7, N'PU', '2024-01-23T21:26:33.4545796+05:45', NULL, NULL, NULL, N'BScIT');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Affliation', N'Created', N'CreatedBy', N'LastUpdated', N'LastUpdatedBy', N'Name') AND [object_id] = OBJECT_ID(N'[TechPrograms]'))
    SET IDENTITY_INSERT [TechPrograms] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'02610d47-09c5-44db-9272-ee96e85c41e7', 0, N'896e5218-dcc0-4031-9603-9405e2ba7afa', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAEEDgGdAmsEJtlmkEvBs5o39iCuab4wnzBhCwotfffet9hwfU9P5rGvn4Cs+B9IB+FQ==', NULL, CAST(0 AS bit), N'6a0f399c-1e85-49f9-9afc-728f142dbc1d', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Created', N'CreatedBy', N'Description', N'HtmlContent', N'LastUpdated', N'LastUpdatedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Widgets]'))
    SET IDENTITY_INSERT [Widgets] ON;
INSERT INTO [Widgets] ([Id], [Created], [CreatedBy], [Description], [HtmlContent], [LastUpdated], [LastUpdatedBy], [Title])
VALUES (1, '2024-01-23T21:26:33.4545827+05:45', N'Seed', N'An display item in home page', N'Welcome to AppTechnoSoft! An initiative for students and freshers.', NULL, NULL, N'CarouselItem'),
(2, '2024-01-23T21:26:33.4545829+05:45', N'Seed', N'An display item in home page', N'Bridging the gap between academia and industry!', NULL, NULL, N'CarouselItem'),
(3, '2024-01-23T21:26:33.4545830+05:45', N'Seed', N'An display item in home page', N'We guide you on software R&D and SDLC to kickstart your career!', NULL, NULL, N'CarouselItem'),
(4, '2024-01-23T21:26:33.4545832+05:45', N'Seed', N'An display item in home page', N'Replacement Opportunities!', NULL, NULL, N'CarouselItem'),
(5, '2024-01-23T21:26:33.4545834+05:45', N'Seed', N'An display item in home page', N'From basics to professional touches!', NULL, NULL, N'CarouselItem'),
(6, '2024-01-23T21:26:33.4545835+05:45', N'Seed', N'GIT and GitHub Essentials', N'todo', NULL, NULL, N'Module'),
(7, '2024-01-23T21:26:33.4545837+05:45', N'Seed', N'Training + Internship Combo', N'todo', NULL, NULL, N'HomeIntro');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Created', N'CreatedBy', N'Description', N'HtmlContent', N'LastUpdated', N'LastUpdatedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Widgets]'))
    SET IDENTITY_INSERT [Widgets] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'ce2e0bd6-7aac-42ff-8cee-5d6e95d556dc', N'02610d47-09c5-44db-9272-ee96e85c41e7');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

CREATE INDEX [IX_RoleClaims_RoleId] ON [RoleClaims] ([RoleId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [Roles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_Students_ApplicationUserId] ON [Students] ([ApplicationUserId]);
GO

CREATE INDEX [IX_Students_CollegeId] ON [Students] ([CollegeId]);
GO

CREATE INDEX [IX_Students_FinAccountId] ON [Students] ([FinAccountId]);
GO

CREATE INDEX [IX_Students_TeamId] ON [Students] ([TeamId]);
GO

CREATE INDEX [IX_Students_TechProgramId] ON [Students] ([TechProgramId]);
GO

CREATE INDEX [IX_TagWidget_WidgetsId] ON [TagWidget] ([WidgetsId]);
GO

CREATE INDEX [IX_Teams_BatchId] ON [Teams] ([BatchId]);
GO

CREATE INDEX [IX_UserClaims_UserId] ON [UserClaims] ([UserId]);
GO

CREATE INDEX [IX_UserLogins_UserId] ON [UserLogins] ([UserId]);
GO

CREATE INDEX [IX_UserRole_RoleId] ON [UserRole] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [Users] ([NormalizedEmail]);
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [Users] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240123154133_Initial', N'8.0.0');
GO

COMMIT;
GO

