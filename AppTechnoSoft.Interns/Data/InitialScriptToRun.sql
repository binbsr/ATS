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
VALUES (1, '2024-01-07T16:01:35.2795412+05:45', NULL, NULL, NULL, N'Bhadrapur, Jhapa', N'Mechi Multiple Campus'),
(2, '2024-01-07T16:01:35.2795443+05:45', NULL, NULL, NULL, N'Dhankuta', N'Dhankuta Multiple Campus'),
(3, '2024-01-07T16:01:35.2795445+05:45', NULL, NULL, NULL, N'Dharan', N'Central Campus of Technology'),
(4, '2024-01-07T16:01:35.2795447+05:45', NULL, NULL, NULL, N'Biratnagar', N'Mahendra Morang Adarsha Multiple Campus'),
(5, '2024-01-07T16:01:35.2795449+05:45', NULL, NULL, NULL, N'Rajbiraj', N'Mahendra Bindeshwori Multiple Campus'),
(6, '2024-01-07T16:01:35.2795451+05:45', NULL, NULL, NULL, N'Siraha', N'Surya Narayan Satya Na. Mo. Yadav Campus'),
(7, '2024-01-07T16:01:35.2795452+05:45', NULL, NULL, NULL, N'Janakpur', N'Ramsorup Ramsagar Multiple Campus'),
(8, '2024-01-07T16:01:35.2795454+05:45', NULL, NULL, NULL, N'Birgunj', N'Thakur Ram Multiple Campus'),
(9, '2024-01-07T16:01:35.2795456+05:45', NULL, NULL, NULL, N'Bharatpur', N'Birendra Multiple Campus'),
(10, '2024-01-07T16:01:35.2795457+05:45', NULL, NULL, NULL, N'Pokhara', N'Prithivi Narayan Multiple Campus'),
(11, '2024-01-07T16:01:35.2795459+05:45', NULL, NULL, NULL, N'Mahendranagar', N'SidhaNath Science Campus'),
(12, '2024-01-07T16:01:35.2795460+05:45', NULL, NULL, NULL, N'Nepalgunj', N'Mahendra Multiple Campus'),
(13, '2024-01-07T16:01:35.2795462+05:45', NULL, NULL, NULL, N'Butwal', N'Butwal Multiple Campus'),
(14, '2024-01-07T16:01:35.2795463+05:45', NULL, NULL, NULL, N'Palpa', N'Tribhuvan Multiple Campus'),
(15, '2024-01-07T16:01:35.2795465+05:45', NULL, NULL, NULL, N'Ghantaghar', N'Tri-Chandra Multiple Campus'),
(16, '2024-01-07T16:01:35.2795466+05:45', NULL, NULL, NULL, N'Lainchour', N'Amrit Science Campus'),
(17, '2024-01-07T16:01:35.2795468+05:45', NULL, NULL, NULL, N'Patan', N'Patan Multiple Campus'),
(18, '2024-01-07T16:01:35.2795469+05:45', NULL, NULL, NULL, N'Bhaktapur', N'Bhaktapur Multiple Campus'),
(19, '2024-01-07T16:01:35.2795471+05:45', NULL, NULL, NULL, N'Bagbazar', N'Padma Kanya Multiple Campus'),
(20, '2024-01-07T16:01:35.2795472+05:45', NULL, NULL, NULL, N'Ghorahi, Dang', N'Mahendra Multiple Campus'),
(21, '2024-01-07T16:01:35.2795474+05:45', NULL, NULL, NULL, N'Baglung', N'Dhaulagiri Campus'),
(22, '2024-01-07T16:01:35.2795475+05:45', NULL, NULL, NULL, N'Gorkha', N'Gorkha Campus'),
(23, '2024-01-07T16:01:35.2795476+05:45', NULL, NULL, NULL, N'Bhairahawa', N'Bhairahawa Multiple Campus'),
(24, '2024-01-07T16:01:35.2795478+05:45', NULL, NULL, NULL, N'Biratnagar', N'Degree Campus');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Created', N'CreatedBy', N'LastUpdated', N'LastUpdatedBy', N'Location', N'Name') AND [object_id] = OBJECT_ID(N'[Colleges]'))
    SET IDENTITY_INSERT [Colleges] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ColorCode', N'Created', N'CreatedBy', N'Description', N'LastUpdated', N'LastUpdatedBy', N'Name') AND [object_id] = OBJECT_ID(N'[Tags]'))
    SET IDENTITY_INSERT [Tags] ON;
INSERT INTO [Tags] ([Id], [ColorCode], [Created], [CreatedBy], [Description], [LastUpdated], [LastUpdatedBy], [Name])
VALUES (1, N'', '2024-01-07T16:01:35.2796030+05:45', NULL, N'Specific module/sub-module for a training course', NULL, NULL, N'Module'),
(2, N'', '2024-01-07T16:01:35.2796035+05:45', NULL, N'Single display item for home page', NULL, NULL, N'CarouselItem');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ColorCode', N'Created', N'CreatedBy', N'Description', N'LastUpdated', N'LastUpdatedBy', N'Name') AND [object_id] = OBJECT_ID(N'[Tags]'))
    SET IDENTITY_INSERT [Tags] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Affliation', N'Created', N'CreatedBy', N'LastUpdated', N'LastUpdatedBy', N'Name') AND [object_id] = OBJECT_ID(N'[TechPrograms]'))
    SET IDENTITY_INSERT [TechPrograms] ON;
INSERT INTO [TechPrograms] ([Id], [Affliation], [Created], [CreatedBy], [LastUpdated], [LastUpdatedBy], [Name])
VALUES (1, N'TU', '2024-01-07T16:01:35.2795956+05:45', NULL, NULL, NULL, N'BCA'),
(2, N'PU', '2024-01-07T16:01:35.2795962+05:45', NULL, NULL, NULL, N'BCA'),
(3, N'TU', '2024-01-07T16:01:35.2795964+05:45', NULL, NULL, NULL, N'BIT'),
(4, N'PU', '2024-01-07T16:01:35.2795965+05:45', NULL, NULL, NULL, N'BIT'),
(5, N'TU', '2024-01-07T16:01:35.2795967+05:45', NULL, NULL, NULL, N'BIM'),
(6, N'TU', '2024-01-07T16:01:35.2795969+05:45', NULL, NULL, NULL, N'BScIT'),
(7, N'PU', '2024-01-07T16:01:35.2795971+05:45', NULL, NULL, NULL, N'BScIT');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Affliation', N'Created', N'CreatedBy', N'LastUpdated', N'LastUpdatedBy', N'Name') AND [object_id] = OBJECT_ID(N'[TechPrograms]'))
    SET IDENTITY_INSERT [TechPrograms] OFF;
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
VALUES (N'20240107101635_Initial', N'8.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Batches] ADD [Name] nvarchar(max) NOT NULL DEFAULT N'';
GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929021+05:45'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929050+05:45'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929051+05:45'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929053+05:45'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929054+05:45'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929055+05:45'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929056+05:45'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929057+05:45'
WHERE [Id] = 8;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929058+05:45'
WHERE [Id] = 9;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929059+05:45'
WHERE [Id] = 10;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929060+05:45'
WHERE [Id] = 11;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929061+05:45'
WHERE [Id] = 12;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929062+05:45'
WHERE [Id] = 13;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929063+05:45'
WHERE [Id] = 14;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929064+05:45'
WHERE [Id] = 15;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929065+05:45'
WHERE [Id] = 16;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929066+05:45'
WHERE [Id] = 17;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929067+05:45'
WHERE [Id] = 18;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929068+05:45'
WHERE [Id] = 19;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929069+05:45'
WHERE [Id] = 20;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929098+05:45'
WHERE [Id] = 21;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929099+05:45'
WHERE [Id] = 22;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929100+05:45'
WHERE [Id] = 23;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = '2024-01-07T22:12:29.7929101+05:45'
WHERE [Id] = 24;
SELECT @@ROWCOUNT;

GO

UPDATE [Tags] SET [Created] = '2024-01-07T22:12:29.7929475+05:45'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Tags] SET [Created] = '2024-01-07T22:12:29.7929479+05:45'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = '2024-01-07T22:12:29.7929431+05:45'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = '2024-01-07T22:12:29.7929435+05:45'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = '2024-01-07T22:12:29.7929436+05:45'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = '2024-01-07T22:12:29.7929437+05:45'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = '2024-01-07T22:12:29.7929438+05:45'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = '2024-01-07T22:12:29.7929439+05:45'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = '2024-01-07T22:12:29.7929440+05:45'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240107162730_addNameColumn', N'8.0.0');
GO

COMMIT;
GO

