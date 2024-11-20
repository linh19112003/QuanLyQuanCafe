CREATE DATABASE QuanLyQuanCafe
Go

USE QuanLyQuanCafe
Go

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên', 
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống' -- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) NOT NULL  PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL  DEFAULT N'Lter',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 -- 1: admin || 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL  DEFAULT N'Chưa đặt tên', 
)

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên', 
	idCategory INT NOT NULL,
	price FLOAT NOT NULL

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL, -- 1: Đã thanh toán || 0: Chưa thanh toán

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY NOT NULL,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

INSERT INTO dbo.Account
	(
		UserName,
		DisplayName,
		PassWord,
		Type
	)
VALUES
	(
		N'Linh' , --UserName - nvarchar(100)
		N'Linh' , --DisplayName - nvarchar(100)
		N'1', --PassWord - nvarchar(1000)
		0 -- Type - int
	)
INSERT INTO dbo.Account
	(
		UserName,
		DisplayName,
		PassWord,
		Type
	)
VALUES
	(
		N'staff' , --UserName - nvarchar(100)
		N'staff' , --DisplayName - nvarchar(100)
		N'1', --PassWord - nvarchar(1000)
		0 -- Type - int
	)
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN 
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'staff' -- nvarchar(100)
GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

-- Thêm bàn-- 
DECLARE @i INT = 0
WHILE @i <=10
BEGIN 
	INSERT dbo.TableFood (name) VALUES	(N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i +1
END
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

UPDATE dbo.TableFood SET STATUS = N'Có người' WHERE id = 8
EXEC dbo.USP_GetTableList


-- Thêm Category --
INSERT dbo.FoodCategory 
		(name)
VALUES	( N'Hải sản' ) -- name - nvarchar(100)
INSERT dbo.FoodCategory 
		(name)
VALUES	( N'Nông sản' ) -- name - nvarchar(100)
INSERT dbo.FoodCategory 
		(name)
VALUES	( N'Lâm sản' ) -- name - nvarchar(100)
INSERT dbo.FoodCategory 
		(name)
VALUES	( N'Sản sản' ) -- name - nvarchar(100)
INSERT dbo.FoodCategory 
		(name)
VALUES	( N'Nước' ) -- name - nvarchar(100)

-- Thêm món ăn --
INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Mực một nắng nước sa tế', -- name - nvarchar(100)
		1, -- idCategory - int
		120000)
INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Nghêu hấp xả', -- name - nvarchar(100)
		2, -- idCategory - int
		70000)
INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Nầm dê nướng sữa', -- name - nvarchar(100)
		3, -- idCategory - int
		350000)
INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Heo rừng nướng muối ớt', -- name - nvarchar(100)
		4, -- idCategory - int
		500000)
INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Cơm chiên không dầu', -- name - nvarchar(100)
		5, -- idCategory - int
		50000)
INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'7UP', -- name - nvarchar(100)
		6, -- idCategory - int
		12000)
INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Cafe', -- name - nvarchar(100)
		7, -- idCategory - int
		15000)
GO

-- Thêm bill --
INSERT dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status	)
VALUES (GETDATE(), --DateCheckIn - date
		NULL, -- --DateCheckOut - date
		1, -- idTable - int
		0 -- status - 0: chưa check out - int
		)
GO

INSERT dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status	)
VALUES (GETDATE(), --DateCheckIn - date
		GETDATE(), -- --DateCheckOut - date
		4, -- idTable - int
		1 -- status - 0: chưa check out - int
		)
INSERT dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status	)
VALUES (GETDATE(), --DateCheckIn - date
		GETDATE(), -- --DateCheckOut - date
		1, -- idTable - int
		0 -- status - 0: chưa check out - int
		)
Go
INSERT dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status	)
VALUES (GETDATE(), --DateCheckIn - date
		GETDATE(), -- --DateCheckOut - date
		2, -- idTable - int
		0 -- status - 0: chưa check out - int
		)
Go
INSERT dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status	)
VALUES (GETDATE(), --DateCheckIn - date
		GETDATE(), -- --DateCheckOut - date
		3, -- idTable - int
		0 -- status - 0: chưa check out - int
		)
Go
INSERT dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status	)
VALUES (GETDATE(), --DateCheckIn - date
		GETDATE(), -- --DateCheckOut - date
		4, -- idTable - int
		1 -- status - 0: chưa check out - int
		)
Go

-- Thêm bill info --
INSERT dbo.BillInfo
		(idBill, idFood, count)
VALUES	(	6, -- idBill - int
			1, --idFood - int
			2 -- count - int
			)

INSERT dbo.BillInfo
		(idBill, idFood, count)
VALUES	(	8, -- idBill - int
			6, --idFood - int
			2 -- count - int
			)

INSERT dbo.BillInfo
		(idBill, idFood, count)
VALUES	(	9, -- idBill - int
			5, --idFood - int
			2 -- count - int
			)
GO

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill
	(	DateCheckIn,
		DateCheckOut,
		idTable,
		status
	)
	VALUES 
	(	GETDATE() , -- DateCheckIn - date
		NULL , -- DateCheckOut - date
		@idTable, -- idTable - int
		0 -- status - int
	)
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

INSERT dbo.BillInfo
		(idBill, idFood, count)
VALUES	(	@idBill, -- idBill - int
			@idFood, --idFood - int
			@count -- count - int
			)
	
END
GO

DELETE dbo.BillInfo
DELETE dbo.Bill

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT idBill FROM inserted
	DECLARE @idTable INT
	SELECT @idBill = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0
	UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
END
GO


CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill FROM inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	DECLARE @count int = 0
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

CREATE PROC [dbo].[USP_UpdateAccount]
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO

--SELECT MAX(id) FROM dbo.Bill



/*SELECT * FROM dbo.BillInfo
SELECT * FROM dbo.Bill
SELECT * FROM dbo.TableFood

SELECT * FROM dbo.Food
*/

/*SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS F
	WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND idTable = 4
	*/




/*	SELECT * FROM dbo.BillInfo WHERE idBill = 2

	SELECT * FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f
	WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.idTable = 4

	SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS F
	WHERE bi.idBill = b.id AND bi.idFood = f.id AND idTable = 4

	SELECT * FROM dbo.Bill
	SELECT * FROM dbo.BillInfo
	SELECT * FROM dbo.TableFood
	SELECT * FROM dbo.FoodCategory
*/
