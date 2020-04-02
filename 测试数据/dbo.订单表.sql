CREATE TABLE [dbo].[订单表] (
    [订单编号] NVARCHAR(50)          NOT NULL,
    [书号]   NVARCHAR(50) NOT NULL,
    [销售数量] INT          DEFAULT ((1)) NOT NULL,
    [销售时间] INT     NULL,
    [单价]   INT          NULL,
    [用户名]  NVARCHAR(50)   NOT NULL,
    [账户类型] NVARCHAR(50)   NULL,
    PRIMARY KEY CLUSTERED ([订单编号] ASC, [用户名] ASC),
    FOREIGN KEY ([书号]) REFERENCES [dbo].[图书表] ([书号]),
    FOREIGN KEY ([用户名]) REFERENCES [dbo].[账户表] ([用户名])
);

