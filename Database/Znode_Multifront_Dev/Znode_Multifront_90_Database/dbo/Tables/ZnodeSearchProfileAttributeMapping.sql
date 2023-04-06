﻿CREATE TABLE [dbo].[ZnodeSearchProfileAttributeMapping] (
    [SearchProfileAttributeMappingId] INT            IDENTITY (1, 1) NOT NULL,
    [SearchProfileId]                 INT            NOT NULL,
    [AttributeCode]                   NVARCHAR (300) NOT NULL,
    [IsFacets]                        BIT            NOT NULL,
    [IsUseInSearch]                   BIT            NOT NULL,
    [BoostValue]                      INT            NULL,
    [CreatedBy]                       INT            NOT NULL,
    [CreatedDate]                     DATETIME       NOT NULL,
    [ModifiedBy]                      INT            NOT NULL,
    [ModifiedDate]                    DATETIME       NOT NULL,
    [IsNgramEnabled] BIT NULL, 
    CONSTRAINT [PK_ZnodeSearchProfileAttributeMapping] PRIMARY KEY CLUSTERED ([SearchProfileAttributeMappingId] ASC),
    CONSTRAINT [FK_ZnodeSearchProfileAttributeMapping_ZnodeSearchProfile] FOREIGN KEY ([SearchProfileId]) REFERENCES [dbo].[ZnodeSearchProfile] ([SearchProfileId])
);

