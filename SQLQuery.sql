CREATE TABLE [dbo].[StaffTable](
	[id] INT IDENTITY (1,1) NOT NULL,
	[first_name] VARCHAR(20) NOT NULL,
	[last_name] VARCHAR(20) NOT NULL,
	[email] VARCHAR(100) NOT NULL,
	[gender] VARCHAR(20) NOT NULL,
	[dob] VARCHAR(20) NOT NULL,
	[contact] VARCHAR(20) NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC)
)
GO

CREATE TABLE [dbo].[CategoryTable](
	[id] INT IDENTITY (1,1) NOT NULL,
	[name] VARCHAR(20) NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC)
)
GO

CREATE TABLE [dbo].[ProductTable](
	[id] INT IDENTITY (1,1) NOT NULL,
	[name] VARCHAR(50) NOT NULL,
	[description] VARCHAR(100) NOT NULL,
	[category] INT NOT NULL,
	[price] INT NOT NULL,
	[count] INT NOT NULL DEFAULT(0),
	[currency] VARCHAR(5) NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [FK_ProductTable_ToCategoryTable] FOREIGN KEY ([category]) REFERENCES [dbo].[CategoryTable] ([id])
)
GO

CREATE TABLE [dbo].[PaymentTable](
	[id] INT IDENTITY (1,1) NOT NULL,
	[currency] VARCHAR(5) NOT NULL,
	[discount] INT NOT NULL DEFAULT(0),
	[payment_method] VARCHAR(20) NOT NULL,
	[cashier] INT NOT NULL,	
	[payment_date] VARCHAR(20) NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [FK_PaymentTable_ToStaffTable] FOREIGN KEY ([cashier]) REFERENCES [dbo].[StaffTable] ([id])
)
GO

CREATE TABLE [dbo].[QuotaTable](
	[id] INT IDENTITY (1,1) NOT NULL,
	[payment_id] INT NOT NULL,
	[product_id] INT NOT NULL,
	[qty] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [FK_QuotaTable_ToPaymentTable] FOREIGN KEY ([payment_id]) REFERENCES [dbo].[PaymentTable] ([id]),
	CONSTRAINT [FK_QuotaTable_ToProductTable] FOREIGN KEy ([product_id]) REFERENCES [dbo].[ProductTable] ([id])
)
GO