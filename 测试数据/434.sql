CREATE TABLE [dbo].[订单表] (
    [订单编号] NVARCHAR (50) NOT NULL,
    [书号]   NVARCHAR (50) NOT NULL,
    [销售数量] INT           DEFAULT ((1)) NOT NULL,
    [销售时间] NVARCHAR (50) NULL,
    [单价]   INT           NULL,
    [用户名]  NVARCHAR (50) NOT NULL,
    [账户类型] NVARCHAR (50) NULL,
    FOREIGN KEY ([书号]) REFERENCES [dbo].[图书表] ([书号]),
    CONSTRAINT [PK_订单表] PRIMARY KEY CLUSTERED ([订单编号] ASC)
);

