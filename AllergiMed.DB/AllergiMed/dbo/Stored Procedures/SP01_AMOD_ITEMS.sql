-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP01_AMOD_ITEMS
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM dbo.AM920_ITEM_LOOKUP WHERE ITEM_ID  LIKE 'AMOD[ ][1-9]%' 
	OR ITEM_ID  LIKE 'AMINJ[ ][1-9]%' ORDER BY ITEM_ID
END
