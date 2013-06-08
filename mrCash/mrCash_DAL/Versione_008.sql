use mrcash
go

ALTER view [dbo].[V_Giornalieri] as
select V.IDVendita
     , V.Data
     , Totale = ISNULL(O.Totale,0)
from Vendite V

LEFT JOIN (
select idvendita 
     , Totale = sum(prezzovendita)   
  from oggetti 
 where idvendita is not null 
 group by idvendita
) O
On O.IDVendita = V.IDVendita   
GO
