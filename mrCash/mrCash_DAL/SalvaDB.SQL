DECLARE @NomeFile NVARCHAR(200)
DECLARE @Cartella NVARCHAR(200)
DECLARE @Percorso NVARCHAR(400)

SET @Cartella = 'G:\BACKUP\'
SET @NomeFile = 'MrCash_' + CONVERT(NVARCHAR(8),getdate(),112) + '.SQL'

SET @Percorso = @Cartella + @NomeFile
BACKUP DATABASE mrCash TO Disk = @Percorso

PRINT @Percorso
