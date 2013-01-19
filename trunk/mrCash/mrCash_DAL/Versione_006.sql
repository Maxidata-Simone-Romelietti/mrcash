use mrcash
go

CREATE Function F_Giornalieri()

Returns @tbl TABLE (IDVendita int primary key NOT NULL, Totale money NULL)

As
Begin

Insert Into @tbl(idvendita, Totale)
select idvendita ,  sum(prezzovendita)   from oggetti where idvendita is not null group by idvendita

Return
End
GO


Create view V_Giornalieri as
select * from dbo.F_Giornalieri()
GO
