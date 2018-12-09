USE [DB_A36E4B_TransportationDev]
GO

/****** Object: SqlProcedure [dbo].[Mob_GetVehicleModel] Script Date: 11/21/2018 1:11:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Mob_GetVehicleModel] 
@Lang nvarchar(50)
as
select Id,   NameAr , NameEn   from vehicleModels
