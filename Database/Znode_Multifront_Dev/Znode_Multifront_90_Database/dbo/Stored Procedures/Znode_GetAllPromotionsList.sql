CREATE PROCEDURE [dbo].[Znode_GetAllPromotionsList]
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN Try
        SELECT zp.PromotionId, zp.PromoCode,zp.Name,zp.Description,zp.PromotionTypeId,zp.Discount,zp.StartDate,
            zp.EndDate,zp.OrderMinimum,zp.QuantityMinimum,zp.IsCouponRequired,zp.DisplayOrder,zp.IsUnique,zp.PortalId, zpp.ProfileId,zp.PromotionProductQuantity,zp.ReferralPublishProductId,zp.PromotionMessage,zp.IsAllowedWithOtherCoupons,zpt.ClassName,zpt.ClassType,zpt.IsActive,zpt.Name,zpt.Description,zpt.PromotionTypeId 
        FROM ZnodePromotion As zp
        INNER JOIN ZnodePromotionType As zpt ON zp.PromotionTypeId = zpt.PromotionTypeId
        LEFT JOIN ZnodePromotionProfileMapper As zpp ON zp.PromotionId = zpp.PromotionId;
    END TRY
    BEGIN CATCH
        DECLARE @Status BIT ;
        SET @Status = 0;
        DECLARE @Error_procedure VARCHAR(1000) = ERROR_PROCEDURE(), 
                @ErrorMessage NVARCHAR(MAX)= ERROR_MESSAGE(),
                @ErrorLine VARCHAR(100)= ERROR_LINE(), 
                @ErrorCall NVARCHAR(MAX)= 'EXEC Znode_GetAllPromotionsList';
                           
        SELECT 0 AS ID,CAST(0 AS BIT) AS Status;                    
            
        EXEC Znode_InsertProcedureErrorLog
        @ProcedureName = 'Znode_GetAllPromotionsList',
        @ErrorInProcedure = @Error_procedure,
        @ErrorMessage = @ErrorMessage,
        @ErrorLine = @ErrorLine,
        @ErrorCall = @ErrorCall;
    END CATCH;
END