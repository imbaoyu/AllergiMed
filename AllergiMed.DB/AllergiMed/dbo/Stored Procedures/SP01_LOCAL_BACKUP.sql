-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP01_LOCAL_BACKUP
AS


	BACKUP DATABASE [AM-BOSS] TO  DISK = N'C:\AM-DATABASE\AM-BOSS-SQL-BACKUP.BAK' WITH NOFORMAT, INIT,  NAME = N'AM-BOSS-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
