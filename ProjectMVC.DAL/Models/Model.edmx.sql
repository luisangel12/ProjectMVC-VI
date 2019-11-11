
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/09/2019 00:04:22
-- Generated from EDMX file: C:\Users\Luis Angel\source\repos\ProjectMVC-VI\ProjectMVC.DAL\Models\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProjectMVC];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__AspNetUse__Tenan__68487DD7]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUsers] DROP CONSTRAINT [FK__AspNetUse__Tenan__68487DD7];
GO
IF OBJECT_ID(N'[dbo].[FK__Members__UserId__693CA210]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Members] DROP CONSTRAINT [FK__Members__UserId__693CA210];
GO
IF OBJECT_ID(N'[dbo].[FK__UserProje__UserI__6EF57B66]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProjects] DROP CONSTRAINT [FK__UserProje__UserI__6EF57B66];
GO
IF OBJECT_ID(N'[dbo].[FK_Artifacts_Projects]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Artifacts] DROP CONSTRAINT [FK_Artifacts_Projects];
GO
IF OBJECT_ID(N'[dbo].[FK_ClassVehicle_Vehicles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClassVehicle] DROP CONSTRAINT [FK_ClassVehicle_Vehicles];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Cities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [FK_Customer_Cities];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_DocumentTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [FK_Customer_DocumentTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [FK_Customer_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Vehicles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [FK_Customer_Vehicles];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_Projects_Tenants]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Projects] DROP CONSTRAINT [FK_Projects_Tenants];
GO
IF OBJECT_ID(N'[dbo].[FK_Tasks_Activities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Tasks_Activities];
GO
IF OBJECT_ID(N'[dbo].[FK_Tasks_Priorities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Tasks_Priorities];
GO
IF OBJECT_ID(N'[dbo].[FK_Tasks_Projects]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Tasks_Projects];
GO
IF OBJECT_ID(N'[dbo].[FK_Tasks_States]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Tasks_States];
GO
IF OBJECT_ID(N'[dbo].[FK_TypeServices_Vehicles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TypeServices] DROP CONSTRAINT [FK_TypeServices_Vehicles];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProjects_Projects]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProjects] DROP CONSTRAINT [FK_UserProjects_Projects];
GO
IF OBJECT_ID(N'[dbo].[FK_VehicleFuels_TypeFuels]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VehicleFuels] DROP CONSTRAINT [FK_VehicleFuels_TypeFuels];
GO
IF OBJECT_ID(N'[dbo].[FK_VehicleGeneralInformation_AuthoritiesTransit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VehicleGeneralInformation] DROP CONSTRAINT [FK_VehicleGeneralInformation_AuthoritiesTransit];
GO
IF OBJECT_ID(N'[dbo].[FK_VehicleGeneralInformation_Brands]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VehicleGeneralInformation] DROP CONSTRAINT [FK_VehicleGeneralInformation_Brands];
GO
IF OBJECT_ID(N'[dbo].[FK_VehicleGeneralInformation_TypeFuels]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VehicleGeneralInformation] DROP CONSTRAINT [FK_VehicleGeneralInformation_TypeFuels];
GO
IF OBJECT_ID(N'[dbo].[FK_VehicleGeneralInformation_TypeTires]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VehicleGeneralInformation] DROP CONSTRAINT [FK_VehicleGeneralInformation_TypeTires];
GO
IF OBJECT_ID(N'[dbo].[FK_VehicleMaintenance_TypeMaintenance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VehicleMaintenance] DROP CONSTRAINT [FK_VehicleMaintenance_TypeMaintenance];
GO
IF OBJECT_ID(N'[dbo].[FK_Vehicles_VehicleFuels]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehicles] DROP CONSTRAINT [FK_Vehicles_VehicleFuels];
GO
IF OBJECT_ID(N'[dbo].[FK_Vehicles_VehicleGeneralInformation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehicles] DROP CONSTRAINT [FK_Vehicles_VehicleGeneralInformation];
GO
IF OBJECT_ID(N'[dbo].[FK_Vehicles_VehicleMaintenance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehicles] DROP CONSTRAINT [FK_Vehicles_VehicleMaintenance];
GO
IF OBJECT_ID(N'[dbo].[FK_Vehicles_VehiclePolicySOAT]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehicles] DROP CONSTRAINT [FK_Vehicles_VehiclePolicySOAT];
GO
IF OBJECT_ID(N'[dbo].[FK_VehicleTechnicalData_Vehicles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VehicleTechnicalData] DROP CONSTRAINT [FK_VehicleTechnicalData_Vehicles];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Activities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Activities];
GO
IF OBJECT_ID(N'[dbo].[Artifacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Artifacts];
GO
IF OBJECT_ID(N'[dbo].[AspNetRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserClaims];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserLogins];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[AuthoritiesTransit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AuthoritiesTransit];
GO
IF OBJECT_ID(N'[dbo].[Brands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Brands];
GO
IF OBJECT_ID(N'[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities];
GO
IF OBJECT_ID(N'[dbo].[ClassVehicle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClassVehicle];
GO
IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO
IF OBJECT_ID(N'[dbo].[DocumentTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DocumentTypes];
GO
IF OBJECT_ID(N'[dbo].[Matches]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Matches];
GO
IF OBJECT_ID(N'[dbo].[Members]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Members];
GO
IF OBJECT_ID(N'[dbo].[Priorities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Priorities];
GO
IF OBJECT_ID(N'[dbo].[Projects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Projects];
GO
IF OBJECT_ID(N'[dbo].[States]', 'U') IS NOT NULL
    DROP TABLE [dbo].[States];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Tasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tasks];
GO
IF OBJECT_ID(N'[dbo].[Teams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teams];
GO
IF OBJECT_ID(N'[dbo].[Tenants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tenants];
GO
IF OBJECT_ID(N'[dbo].[TypeFuels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeFuels];
GO
IF OBJECT_ID(N'[dbo].[TypeMaintenance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeMaintenance];
GO
IF OBJECT_ID(N'[dbo].[TypeServices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeServices];
GO
IF OBJECT_ID(N'[dbo].[TypeTires]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeTires];
GO
IF OBJECT_ID(N'[dbo].[UserProjects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserProjects];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[VehicleFuels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VehicleFuels];
GO
IF OBJECT_ID(N'[dbo].[VehicleGeneralInformation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VehicleGeneralInformation];
GO
IF OBJECT_ID(N'[dbo].[VehicleMaintenance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VehicleMaintenance];
GO
IF OBJECT_ID(N'[dbo].[VehiclePolicySOAT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VehiclePolicySOAT];
GO
IF OBJECT_ID(N'[dbo].[Vehicles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehicles];
GO
IF OBJECT_ID(N'[dbo].[VehicleTechnicalData]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VehicleTechnicalData];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Artifacts'
CREATE TABLE [dbo].[Artifacts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Key] varchar(50)  NULL,
    [ProjectId] int  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'AspNetRoles'
CREATE TABLE [dbo].[AspNetRoles] (
    [Id] nvarchar(128)  NOT NULL,
    [Name] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'AspNetUserClaims'
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'AspNetUserLogins'
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'AspNetUsers'
CREATE TABLE [dbo].[AspNetUsers] (
    [Id] nvarchar(128)  NOT NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL,
    [TenantId] int  NOT NULL
);
GO

-- Creating table 'Members'
CREATE TABLE [dbo].[Members] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NULL,
    [FirstName] varchar(50)  NULL,
    [LastName] varchar(50)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'Projects'
CREATE TABLE [dbo].[Projects] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] varchar(50)  NULL,
    [Details] varchar(100)  NULL,
    [ExpectedCompletionDate] datetime  NULL,
    [TenantId] int  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'Tenants'
CREATE TABLE [dbo].[Tenants] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL,
    [Plan] varchar(50)  NULL
);
GO

-- Creating table 'UserProjects'
CREATE TABLE [dbo].[UserProjects] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NULL,
    [UserId] nvarchar(128)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'Activities'
CREATE TABLE [dbo].[Activities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'Priorities'
CREATE TABLE [dbo].[Priorities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'States'
CREATE TABLE [dbo].[States] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Tasks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] varchar(50)  NULL,
    [Details] varchar(100)  NULL,
    [ExpirationDate] datetime  NULL,
    [IsCompleted] bit  NULL,
    [Effort] int  NULL,
    [RemainingWork] int  NULL,
    [StateId] int  NULL,
    [ActivityId] int  NULL,
    [PriorityId] int  NULL,
    [ProjectId] int  NULL
);
GO

-- Creating table 'AuthoritiesTransit'
CREATE TABLE [dbo].[AuthoritiesTransit] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'Brands'
CREATE TABLE [dbo].[Brands] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'ClassVehicle'
CREATE TABLE [dbo].[ClassVehicle] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'Customer'
CREATE TABLE [dbo].[Customer] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DocumentTypeId] int  NULL,
    [DocumentNumber] varchar(50)  NULL,
    [FirstName] varchar(50)  NULL,
    [SecondName] varchar(50)  NULL,
    [Surname] varchar(50)  NULL,
    [SecondSurname] varchar(50)  NULL,
    [Telephone] varchar(50)  NULL,
    [Address] varchar(100)  NULL,
    [CityId] int  NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'DocumentTypes'
CREATE TABLE [dbo].[DocumentTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'Matches'
CREATE TABLE [dbo].[Matches] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TeamGuestId] int  NULL,
    [TeamHostId] int  NULL,
    [HostGoals] int  NULL,
    [GuestGoals] int  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Teams'
CREATE TABLE [dbo].[Teams] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NOT NULL
);
GO

-- Creating table 'TypeFuels'
CREATE TABLE [dbo].[TypeFuels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'TypeMaintenance'
CREATE TABLE [dbo].[TypeMaintenance] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'TypeServices'
CREATE TABLE [dbo].[TypeServices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'TypeTires'
CREATE TABLE [dbo].[TypeTires] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Password] varchar(max)  NULL,
    [LockoutEnabled] bit  NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [UserName] varchar(50)  NULL,
    [Email] varchar(100)  NULL
);
GO

-- Creating table 'VehicleFuels'
CREATE TABLE [dbo].[VehicleFuels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeFuelId] int  NULL,
    [Amount] float  NULL,
    [LiterFuel] float  NULL,
    [FuelDate] datetime  NULL,
    [VehicleId] int  NULL
);
GO

-- Creating table 'VehicleGeneralInformation'
CREATE TABLE [dbo].[VehicleGeneralInformation] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BrandId] int  NULL,
    [Line] varchar(50)  NULL,
    [Model] int  NULL,
    [Color] varchar(50)  NULL,
    [SerialNumber] varchar(50)  NULL,
    [EngineNumber] varchar(50)  NULL,
    [ChassisNumber] varchar(50)  NULL,
    [VIN] varchar(50)  NULL,
    [Cylinder] int  NULL,
    [TypeBody] varchar(50)  NULL,
    [TypeFuelId] int  NULL,
    [InitialEnrollmentDate] datetime  NULL,
    [NroDoors] int  NULL,
    [TypeTireId] int  NULL,
    [AuthoritiesTransitId] int  NULL,
    [VehicleId] int  NULL
);
GO

-- Creating table 'VehicleMaintenance'
CREATE TABLE [dbo].[VehicleMaintenance] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(max)  NULL,
    [MaintenanceDate] datetime  NULL,
    [CurrentMileage] float  NULL,
    [NextMaintenanceDate] datetime  NULL,
    [TypeMaintenanceId] int  NULL,
    [Amount] float  NULL,
    [VehicleId] int  NULL
);
GO

-- Creating table 'VehiclePolicySOAT'
CREATE TABLE [dbo].[VehiclePolicySOAT] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PolicyNumber] varchar(50)  NULL,
    [ExpeditionDate] datetime  NULL,
    [DateStartValidity] datetime  NULL,
    [EndDateValidity] datetime  NULL,
    [SOATIssueEntity] varchar(50)  NULL,
    [State] bit  NULL,
    [VehicleId] int  NULL
);
GO

-- Creating table 'Vehicles'
CREATE TABLE [dbo].[Vehicles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LicensePlate] varchar(50)  NULL,
    [NroTransitLicense] varchar(50)  NULL,
    [StateVehicle] bit  NULL,
    [TypeServiceId] int  NULL,
    [ClassVehicleId] int  NULL,
    [Image] varchar(max)  NULL,
    [CustomerId] int  NULL
);
GO

-- Creating table 'VehicleTechnicalData'
CREATE TABLE [dbo].[VehicleTechnicalData] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CapacityLoad] float  NULL,
    [PassengerCapacity] int  NULL,
    [GVWR] float  NULL,
    [CapacityPassengersSitting] int  NULL,
    [NumberAxes] int  NULL,
    [VehicleId] int  NULL
);
GO

-- Creating table 'AspNetUserRoles'
CREATE TABLE [dbo].[AspNetUserRoles] (
    [AspNetRoles_Id] nvarchar(128)  NOT NULL,
    [AspNetUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Artifacts'
ALTER TABLE [dbo].[Artifacts]
ADD CONSTRAINT [PK_Artifacts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetRoles'
ALTER TABLE [dbo].[AspNetRoles]
ADD CONSTRAINT [PK_AspNetRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [PK_AspNetUserClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [PK_AspNetUserLogins]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [PK_AspNetUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Members'
ALTER TABLE [dbo].[Members]
ADD CONSTRAINT [PK_Members]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [PK_Projects]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tenants'
ALTER TABLE [dbo].[Tenants]
ADD CONSTRAINT [PK_Tenants]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserProjects'
ALTER TABLE [dbo].[UserProjects]
ADD CONSTRAINT [PK_UserProjects]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Activities'
ALTER TABLE [dbo].[Activities]
ADD CONSTRAINT [PK_Activities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Priorities'
ALTER TABLE [dbo].[Priorities]
ADD CONSTRAINT [PK_Priorities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'States'
ALTER TABLE [dbo].[States]
ADD CONSTRAINT [PK_States]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [PK_Tasks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AuthoritiesTransit'
ALTER TABLE [dbo].[AuthoritiesTransit]
ADD CONSTRAINT [PK_AuthoritiesTransit]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Brands'
ALTER TABLE [dbo].[Brands]
ADD CONSTRAINT [PK_Brands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClassVehicle'
ALTER TABLE [dbo].[ClassVehicle]
ADD CONSTRAINT [PK_ClassVehicle]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customer'
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT [PK_Customer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DocumentTypes'
ALTER TABLE [dbo].[DocumentTypes]
ADD CONSTRAINT [PK_DocumentTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [PK_Matches]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'Teams'
ALTER TABLE [dbo].[Teams]
ADD CONSTRAINT [PK_Teams]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeFuels'
ALTER TABLE [dbo].[TypeFuels]
ADD CONSTRAINT [PK_TypeFuels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeMaintenance'
ALTER TABLE [dbo].[TypeMaintenance]
ADD CONSTRAINT [PK_TypeMaintenance]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeServices'
ALTER TABLE [dbo].[TypeServices]
ADD CONSTRAINT [PK_TypeServices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeTires'
ALTER TABLE [dbo].[TypeTires]
ADD CONSTRAINT [PK_TypeTires]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VehicleFuels'
ALTER TABLE [dbo].[VehicleFuels]
ADD CONSTRAINT [PK_VehicleFuels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VehicleGeneralInformation'
ALTER TABLE [dbo].[VehicleGeneralInformation]
ADD CONSTRAINT [PK_VehicleGeneralInformation]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VehicleMaintenance'
ALTER TABLE [dbo].[VehicleMaintenance]
ADD CONSTRAINT [PK_VehicleMaintenance]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VehiclePolicySOAT'
ALTER TABLE [dbo].[VehiclePolicySOAT]
ADD CONSTRAINT [PK_VehiclePolicySOAT]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [PK_Vehicles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VehicleTechnicalData'
ALTER TABLE [dbo].[VehicleTechnicalData]
ADD CONSTRAINT [PK_VehicleTechnicalData]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [AspNetRoles_Id], [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [PK_AspNetUserRoles]
    PRIMARY KEY CLUSTERED ([AspNetRoles_Id], [AspNetUsers_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProjectId] in table 'Artifacts'
ALTER TABLE [dbo].[Artifacts]
ADD CONSTRAINT [FK_Artifacts_Projects]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Artifacts_Projects'
CREATE INDEX [IX_FK_Artifacts_Projects]
ON [dbo].[Artifacts]
    ([ProjectId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserClaims]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserLogins]
    ([UserId]);
GO

-- Creating foreign key on [TenantId] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [FK__AspNetUse__Tenan__3D5E1FD2]
    FOREIGN KEY ([TenantId])
    REFERENCES [dbo].[Tenants]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__AspNetUse__Tenan__3D5E1FD2'
CREATE INDEX [IX_FK__AspNetUse__Tenan__3D5E1FD2]
ON [dbo].[AspNetUsers]
    ([TenantId]);
GO

-- Creating foreign key on [UserId] in table 'Members'
ALTER TABLE [dbo].[Members]
ADD CONSTRAINT [FK__Members__UserId__3C69FB99]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Members__UserId__3C69FB99'
CREATE INDEX [IX_FK__Members__UserId__3C69FB99]
ON [dbo].[Members]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'UserProjects'
ALTER TABLE [dbo].[UserProjects]
ADD CONSTRAINT [FK__UserProje__UserI__3B75D760]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__UserProje__UserI__3B75D760'
CREATE INDEX [IX_FK__UserProje__UserI__3B75D760]
ON [dbo].[UserProjects]
    ([UserId]);
GO

-- Creating foreign key on [TenantId] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [FK_Projects_Tenants]
    FOREIGN KEY ([TenantId])
    REFERENCES [dbo].[Tenants]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Projects_Tenants'
CREATE INDEX [IX_FK_Projects_Tenants]
ON [dbo].[Projects]
    ([TenantId]);
GO

-- Creating foreign key on [ProjectId] in table 'UserProjects'
ALTER TABLE [dbo].[UserProjects]
ADD CONSTRAINT [FK_UserProjects_Projects]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProjects_Projects'
CREATE INDEX [IX_FK_UserProjects_Projects]
ON [dbo].[UserProjects]
    ([ProjectId]);
GO

-- Creating foreign key on [AspNetRoles_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetRoles]
    FOREIGN KEY ([AspNetRoles_Id])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUsers]
    FOREIGN KEY ([AspNetUsers_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AspNetUserRoles_AspNetUsers'
CREATE INDEX [IX_FK_AspNetUserRoles_AspNetUsers]
ON [dbo].[AspNetUserRoles]
    ([AspNetUsers_Id]);
GO

-- Creating foreign key on [ActivityId] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_Tasks_Activities]
    FOREIGN KEY ([ActivityId])
    REFERENCES [dbo].[Activities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Tasks_Activities'
CREATE INDEX [IX_FK_Tasks_Activities]
ON [dbo].[Tasks]
    ([ActivityId]);
GO

-- Creating foreign key on [PriorityId] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_Tasks_Priorities]
    FOREIGN KEY ([PriorityId])
    REFERENCES [dbo].[Priorities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Tasks_Priorities'
CREATE INDEX [IX_FK_Tasks_Priorities]
ON [dbo].[Tasks]
    ([PriorityId]);
GO

-- Creating foreign key on [ProjectId] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_Tasks_Projects]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Tasks_Projects'
CREATE INDEX [IX_FK_Tasks_Projects]
ON [dbo].[Tasks]
    ([ProjectId]);
GO

-- Creating foreign key on [StateId] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_Tasks_States]
    FOREIGN KEY ([StateId])
    REFERENCES [dbo].[States]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Tasks_States'
CREATE INDEX [IX_FK_Tasks_States]
ON [dbo].[Tasks]
    ([StateId]);
GO

-- Creating foreign key on [AuthoritiesTransitId] in table 'VehicleGeneralInformation'
ALTER TABLE [dbo].[VehicleGeneralInformation]
ADD CONSTRAINT [FK_VehicleGeneralInformation_AuthoritiesTransit]
    FOREIGN KEY ([AuthoritiesTransitId])
    REFERENCES [dbo].[AuthoritiesTransit]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleGeneralInformation_AuthoritiesTransit'
CREATE INDEX [IX_FK_VehicleGeneralInformation_AuthoritiesTransit]
ON [dbo].[VehicleGeneralInformation]
    ([AuthoritiesTransitId]);
GO

-- Creating foreign key on [BrandId] in table 'VehicleGeneralInformation'
ALTER TABLE [dbo].[VehicleGeneralInformation]
ADD CONSTRAINT [FK_VehicleGeneralInformation_Brands]
    FOREIGN KEY ([BrandId])
    REFERENCES [dbo].[Brands]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleGeneralInformation_Brands'
CREATE INDEX [IX_FK_VehicleGeneralInformation_Brands]
ON [dbo].[VehicleGeneralInformation]
    ([BrandId]);
GO

-- Creating foreign key on [CityId] in table 'Customer'
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT [FK_Customer_Cities]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_Cities'
CREATE INDEX [IX_FK_Customer_Cities]
ON [dbo].[Customer]
    ([CityId]);
GO

-- Creating foreign key on [Id] in table 'ClassVehicle'
ALTER TABLE [dbo].[ClassVehicle]
ADD CONSTRAINT [FK_ClassVehicle_Vehicles]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Vehicles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DocumentTypeId] in table 'Customer'
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT [FK_Customer_DocumentTypes]
    FOREIGN KEY ([DocumentTypeId])
    REFERENCES [dbo].[DocumentTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_DocumentTypes'
CREATE INDEX [IX_FK_Customer_DocumentTypes]
ON [dbo].[Customer]
    ([DocumentTypeId]);
GO

-- Creating foreign key on [UserId] in table 'Customer'
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT [FK_Customer_Users]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_Users'
CREATE INDEX [IX_FK_Customer_Users]
ON [dbo].[Customer]
    ([UserId]);
GO

-- Creating foreign key on [Id] in table 'Customer'
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT [FK_Customer_Vehicles]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Vehicles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [TypeFuelId] in table 'VehicleFuels'
ALTER TABLE [dbo].[VehicleFuels]
ADD CONSTRAINT [FK_VehicleFuels_TypeFuels]
    FOREIGN KEY ([TypeFuelId])
    REFERENCES [dbo].[TypeFuels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleFuels_TypeFuels'
CREATE INDEX [IX_FK_VehicleFuels_TypeFuels]
ON [dbo].[VehicleFuels]
    ([TypeFuelId]);
GO

-- Creating foreign key on [TypeFuelId] in table 'VehicleGeneralInformation'
ALTER TABLE [dbo].[VehicleGeneralInformation]
ADD CONSTRAINT [FK_VehicleGeneralInformation_TypeFuels]
    FOREIGN KEY ([TypeFuelId])
    REFERENCES [dbo].[TypeFuels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleGeneralInformation_TypeFuels'
CREATE INDEX [IX_FK_VehicleGeneralInformation_TypeFuels]
ON [dbo].[VehicleGeneralInformation]
    ([TypeFuelId]);
GO

-- Creating foreign key on [TypeMaintenanceId] in table 'VehicleMaintenance'
ALTER TABLE [dbo].[VehicleMaintenance]
ADD CONSTRAINT [FK_VehicleMaintenance_TypeMaintenance]
    FOREIGN KEY ([TypeMaintenanceId])
    REFERENCES [dbo].[TypeMaintenance]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleMaintenance_TypeMaintenance'
CREATE INDEX [IX_FK_VehicleMaintenance_TypeMaintenance]
ON [dbo].[VehicleMaintenance]
    ([TypeMaintenanceId]);
GO

-- Creating foreign key on [Id] in table 'TypeServices'
ALTER TABLE [dbo].[TypeServices]
ADD CONSTRAINT [FK_TypeServices_Vehicles]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Vehicles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [TypeTireId] in table 'VehicleGeneralInformation'
ALTER TABLE [dbo].[VehicleGeneralInformation]
ADD CONSTRAINT [FK_VehicleGeneralInformation_TypeTires]
    FOREIGN KEY ([TypeTireId])
    REFERENCES [dbo].[TypeTires]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleGeneralInformation_TypeTires'
CREATE INDEX [IX_FK_VehicleGeneralInformation_TypeTires]
ON [dbo].[VehicleGeneralInformation]
    ([TypeTireId]);
GO

-- Creating foreign key on [Id] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [FK_Vehicles_VehicleFuels]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[VehicleFuels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [FK_Vehicles_VehicleGeneralInformation]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[VehicleGeneralInformation]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [FK_Vehicles_VehicleMaintenance]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[VehicleMaintenance]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [FK_Vehicles_VehiclePolicySOAT]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[VehiclePolicySOAT]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'VehicleTechnicalData'
ALTER TABLE [dbo].[VehicleTechnicalData]
ADD CONSTRAINT [FK_VehicleTechnicalData_Vehicles]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Vehicles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------