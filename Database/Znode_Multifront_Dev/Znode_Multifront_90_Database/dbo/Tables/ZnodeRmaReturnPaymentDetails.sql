﻿CREATE TABLE [dbo].[ZnodeRmaReturnPaymentDetails] (
    [RmaReturnPaymentDetailsId] INT            IDENTITY (1, 1) NOT NULL,
    [RmaReturnDetailsId]        INT            NOT NULL,
    [PaymentTypeId]             INT            NULL,
    [OmsPaymentStateId]         INT            NULL,
    [PaymentSettingId]          INT            NULL,
    [PaymentExternalId]         NVARCHAR (100) NULL,
    [PaymentDisplayName]        NVARCHAR (100) NULL,
    [PaymentTransactionToken]   NVARCHAR (300) NULL,
    [TransactionId]             NVARCHAR (400) NULL,
    [CreditCardNumber]          VARCHAR (4)    NULL,
    [CardType]                  VARCHAR (50)   NULL,
    [CreditCardExpMonth]        INT            NULL,
    [CreditCardExpYear]         INT            NULL,
    [PurchaseOrderNumber]       VARCHAR (500)  NULL,
    [CreatedBy]                 INT            NOT NULL,
    [CreatedDate]               DATETIME       NOT NULL,
    [ModifiedBy]                INT            NOT NULL,
    [ModifiedDate]              DATETIME       NOT NULL,
    CONSTRAINT [PK_ZnodeRmaReturnPaymentDetails] PRIMARY KEY CLUSTERED ([RmaReturnPaymentDetailsId] ASC),
    CONSTRAINT [FK_ZnodeRmaReturnPaymentDetails_znodeOmsPaymentState] FOREIGN KEY ([OmsPaymentStateId]) REFERENCES [dbo].[ZnodeOmsPaymentState] ([OmsPaymentStateId]),
    CONSTRAINT [FK_ZnodeRmaReturnPaymentDetails_ZnodePaymentSetting] FOREIGN KEY ([PaymentSettingId]) REFERENCES [dbo].[ZnodePaymentSetting] ([PaymentSettingId]),
    CONSTRAINT [FK_ZnodeRmaReturnPaymentDetails_ZnodePaymentType] FOREIGN KEY ([PaymentTypeId]) REFERENCES [dbo].[ZnodePaymentType] ([PaymentTypeId]),
    CONSTRAINT [FK_ZnodeRmaReturnPaymentDetails_ZnodeRmaReturnDetails] FOREIGN KEY ([RmaReturnDetailsId]) REFERENCES [dbo].[ZnodeRmaReturnDetails] ([RmaReturnDetailsId])
);

