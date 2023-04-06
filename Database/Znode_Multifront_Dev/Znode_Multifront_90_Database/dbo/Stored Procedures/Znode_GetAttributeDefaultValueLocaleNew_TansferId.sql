﻿CREATE  PROCEDURE [dbo].[Znode_GetAttributeDefaultValueLocaleNew_TansferId]
( 
    @PimAttributeId TransferId ReadOnly,
    @LocaleId       INT          = 1
)
AS 
/*
    Summary :- This Procedure is used to find the default value of attribute if not present for same locale then use the default value
    Unit Testing
    EXEC Znode_GetAttributeDefaultValueLocale
*/
     BEGIN
         BEGIN TRY
             SET NOCOUNT ON;
             DECLARE @DefaultLocaleId INT= dbo.Fn_GetDefaultLocaleId();
			 -- here collect the both locale data 
             SELECT   VIPDV.PimAttributeId,VIPDV.AttributeDefaultValueCode,VIPDV.IsEditable,VIPDVL.AttributeDefaultValue,VIPDVL.LocaleId,VIPDV.PimAttributeDefaultValueId,VIPDV.DisplayOrder
				,VIPDV.IsDefault
			 INTO #Cte_DefaultValueLocale
			 FROM [dbo].[ZnodePimAttributeDefaultValue] VIPDV
			 INNER JOIN [dbo].[ZnodePimAttributeDefaultValueLocale] VIPDVL ON (VIPDVL.PimAttributeDefaultValueId = VIPDV.PimAttributeDefaultValueId) 
             WHERE VIPDVL.LocaleId IN(@DefaultLocaleId, @LocaleId) 
             AND EXISTS
             (
                SELECT TOP 1 1
                FROM @PimAttributeId SP
                WHERE SP.id = VIPDV.PimAttributeId
             )

			 -- filter for first locale
             ;with Cte_DefaultValueFirstLocale
             AS (SELECT CTDVL.PimAttributeId,CTDVL.AttributeDefaultValueCode,CTDVL.IsEditable,CTDVL.AttributeDefaultValue,CTDVL.PimAttributeDefaultValueId,CTDVL.DisplayOrder,CTDVL.IsDefault
                 FROM #Cte_DefaultValueLocale CTDVL
                 WHERE LocaleId = @LocaleId	 
                ),

			 -- get data for second locale if not exists for firts locale 
             Cte_DefaultValueSecondLocale
             AS (SELECT CTDVFL.PimAttributeId,CTDVFL.AttributeDefaultValueCode,CTDVFL.IsEditable,CTDVFL.AttributeDefaultValue,CTDVFL.PimAttributeDefaultValueId,CTDVFL.DisplayOrder,CTDVFL.IsDefault
                 FROM Cte_DefaultValueFirstLocale CTDVFL
                 UNION ALL
                 SELECT CTDVL.PimAttributeId,CTDVL.AttributeDefaultValueCode,CTDVL.IsEditable,CTDVL.AttributeDefaultValue,CTDVL.PimAttributeDefaultValueId,CTDVL.DisplayOrder, CTDVL.IsDefault
                 FROM #Cte_DefaultValueLocale CTDVL
                 WHERE LocaleId = @DefaultLocaleId 
                 AND NOT EXISTS
                  (
                      SELECT TOP 1 1
                      FROM Cte_DefaultValueFirstLocale CTDVFL
                      WHERE CTDVFL.PimAttributeDefaultValueId = CTDVL.PimAttributeDefaultValueId
                  ))

                  SELECT PimAttributeId,AttributeDefaultValueCode,IsEditable,AttributeDefaultValue,DisplayOrder,PimAttributeDefaultValueId,IsDefault
                  FROM Cte_DefaultValueSecondLocale;
         END TRY
         BEGIN CATCH
             DECLARE @Status BIT ;
		     SET @Status = 0;
		     DECLARE @Error_procedure VARCHAR(1000)= ERROR_PROCEDURE(), @ErrorMessage NVARCHAR(MAX)= ERROR_MESSAGE(), @ErrorLine VARCHAR(100)= ERROR_LINE(), @ErrorCall NVARCHAR(MAX)= 'EXEC Znode_GetAttributeDefaultValueLocale ,@LocaleId='+CAST(@LocaleId AS VARCHAR(50))+',@Status='+CAST(@Status AS VARCHAR(10));
              			 
             SELECT 0 AS ID,CAST(0 AS BIT) AS Status;                    
		    
             EXEC Znode_InsertProcedureErrorLog
				@ProcedureName = 'Znode_GetAttributeDefaultValueLocale',
				@ErrorInProcedure = @Error_procedure,
				@ErrorMessage = @ErrorMessage,
				@ErrorLine = @ErrorLine,
				@ErrorCall = @ErrorCall;
         END CATCH;
     END;