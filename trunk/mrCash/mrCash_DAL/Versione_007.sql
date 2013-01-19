use mrcash
go

Create view V_AcquistiGiornalieri as
   SELECT Data   = CAST(DATEDIFF(dd, 0,A.Data) AS DATETIME)
        , Totale = ISNULL(SUM(O.PrezzoAcquisto),0)
     FROM Acquisti A
LEFT JOIN Oggetti O
       ON O.IDAcquisto = A.IDAcquisto       
 GROUP BY DATEDIFF(dd, 0,A.Data)  
 GO
