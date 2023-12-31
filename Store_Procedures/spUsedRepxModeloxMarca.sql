CREATE PROCEDURE [dbo].[spUsedRepxModeloxMarca]
as
begin
SELECT TOP 1 count(*) AS Usos, Rep.Nombre, Veh.Modelo, Veh.Marca FROM Repuestos rep
INNER JOIN Desperfectos_Repuestos DxR ON rep.Id = DxR.IdRepuesto
INNER JOIN Desperfectos desp ON desp.Id = DxR.IdDesperfecto
INNER JOIN Presupuestos Pres ON desp.IdPresupuesto = Pres.Id
INNER JOIN Vehiculos Veh ON Pres.IdVehiculo = Veh.Id
GROUP BY Veh.Modelo, rep.Nombre, Veh.Marca
ORDER BY Usos DESC

END
