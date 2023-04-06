﻿CREATE TABLE [dbo].[ZnodeRmaReturnLineItems] (
    [RmaReturnLineItemsId]            INT             IDENTITY (1, 1) NOT NULL,
    [RmaReturnDetailsId]              INT             NOT NULL,
    [OmsOrderLineItemsId]             INT             NOT NULL,
    [RmaReasonForReturnId]            INT             NULL,
    [OrderLineItemRelationshipTypeId] INT             NOT NULL,
    [RmaReasonForReturn]              VARCHAR (500)   NOT NULL,
    [Sku]                             NVARCHAR (100)  NOT NULL,
    [ProductName]                     NVARCHAR (500)  NOT NULL,
    [Description]                     VARCHAR (MAX)   NULL,
    [ExpectedReturnQuantity]          NUMERIC (28, 6) NOT NULL,
    [ReturnedQuantity]                NUMERIC (28, 6) NULL,
    [Price]                           NUMERIC (28, 6) NOT NULL,
    [Weight]                          NUMERIC (28, 6) NULL,
    [DiscountAmount]                  NUMERIC (28, 6) NULL,
    [ShipSeparately]                  BIT             NOT NULL,
    [ReturnDate]                      DATETIME        NULL,
    [ShippingCost]                    NUMERIC (28, 6) NULL,
    [RmaReturnStateId]                INT             NOT NULL,
    [IsActive]                        BIT             NOT NULL,
    [IsShippingReturn]                BIT             NOT NULL,
    [RefundAmount]                    NUMERIC (28, 6) NULL,
    [ReturnTypeCode]                  VARCHAR (100)   NULL,
    [Custom1]                         VARCHAR (MAX)   NULL,
    [Custom2]                         VARCHAR (MAX)   NULL,
    [Custom3]                         VARCHAR (MAX)   NULL,
    [Custom4]                         VARCHAR (MAX)   NULL,
    [Custom5]                         VARCHAR (MAX)   NULL,
    [CreatedBy]                       INT             NOT NULL,
    [CreatedDate]                     DATETIME        NOT NULL,
    [ModifiedBy]                      INT             NOT NULL,
    [ModifiedDate]                    DATETIME        NOT NULL,
	[OmsReturnOrderLineItemsId]       INT NULL,
    
    CONSTRAINT [PK_ZnodeRmaReturnLineItems] PRIMARY KEY CLUSTERED ([RmaReturnLineItemsId] ASC),
    CONSTRAINT [FK_ZnodeRmaReturnLineItems_ZnodeOmsOrderLineItemRelationshipType] FOREIGN KEY ([OrderLineItemRelationshipTypeId]) REFERENCES [dbo].[ZnodeOmsOrderLineItemRelationshipType] ([OrderLineItemRelationshipTypeId]),
    CONSTRAINT [FK_ZnodeRmaReturnLineItems_ZnodeOmsOrderLineItems] FOREIGN KEY ([OmsOrderLineItemsId]) REFERENCES [dbo].[ZnodeOmsOrderLineItems] ([OmsOrderLineItemsId]),
    CONSTRAINT [FK_ZnodeRmaReturnLineItems_ZnodeRmaReasonForReturn] FOREIGN KEY ([RmaReasonForReturnId]) REFERENCES [dbo].[ZnodeRmaReasonForReturn] ([RmaReasonForReturnId]),
    CONSTRAINT [FK_ZnodeRmaReturnLineItems_ZnodeRmaReturnDetails] FOREIGN KEY ([RmaReturnDetailsId]) REFERENCES [dbo].[ZnodeRmaReturnDetails] ([RmaReturnDetailsId]),
    CONSTRAINT [FK_ZnodeRmaReturnLineItems_ZnodeRmaReturnState] FOREIGN KEY ([RmaReturnStateId]) REFERENCES [dbo].[ZnodeRmaReturnState] ([RmaReturnStateId]),
	CONSTRAINT [FK_ZnodeRmaReturnLineItems_ZnodeOmsOrderLineItems_OmsReturnOrderLineItemsId] FOREIGN KEY([OmsReturnOrderLineItemsId]) REFERENCES [dbo].[ZnodeOmsOrderLineItems] ([OmsOrderLineItemsId])
);

