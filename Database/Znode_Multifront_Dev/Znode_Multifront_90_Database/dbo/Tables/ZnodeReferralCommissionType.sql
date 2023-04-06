﻿CREATE TABLE [dbo].[ZnodeReferralCommissionType] (
    [ReferralCommissionTypeId] INT          IDENTITY (1, 1) NOT NULL,
    [Name]                     VARCHAR (50) NOT NULL,
    [CreatedBy]                INT          NOT NULL,
    [CreatedDate]              DATETIME     NOT NULL,
    [ModifiedBy]               INT          NOT NULL,
    [ModifiedDate]             DATETIME     NOT NULL,
    CONSTRAINT [PK_ZnodeReferralCommissionType] PRIMARY KEY CLUSTERED ([ReferralCommissionTypeId] ASC)
);

