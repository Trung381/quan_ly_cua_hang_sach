--create database QUANLYBANSACH
go

CREATE TABLE [Author] (
-- ID_TK int IDENTITY(1,1) PRIMARY KEY NOT NULL,
-- Ma_TK as 'TK' + cast(ID_TK as nvarchar(5)) persisted,
  [ID_Author] int IDENTITY(1,1),
  [Ma_TacGia] as 'TG' + cast(ID_Author as varchar(10)) persisted,
  [name] nvarchar(100),
  PRIMARY KEY ([ID_Author])
);

CREATE TABLE [Category] (
  [ID_Category] int identity(1,1),
  [Ma_Loai] as 'ML' + cast([ID_Category] as varchar(10)) persisted,
  [name] varchar(100),
  PRIMARY KEY ([ID_Category])
);

CREATE TABLE [OrderDetail] (
  [ID_OrderDetail] int identity(1,1),
  [quantity] int,
  [ID_Order] int,
  [ID_Book] int,
  [payAmount] int,
  PRIMARY KEY ([ID_OrderDetail])
);

CREATE TABLE [KhachHang] (
  [ID_KH] int identity(1,1),
  [Ma_KH] as 'KH' + cast([ID_KH] as varchar(10)) persisted,
  [name] nvarchar(100),
  [SDT] varchar(12),
  [birthDay] date,
  PRIMARY KEY ([ID_KH])
);

CREATE TABLE [NXB] (
  [ID_NXB] int identity(1,1),
  [Ma_NXB] as 'NXB' + cast([ID_NXB] as varchar(10)) persisted,
  [name] varchar(100),
  PRIMARY KEY ([ID_NXB])
);

CREATE TABLE [Book] (
  [ID_Book] int identity(1,1),
  [Ma_Sach] as 'SACH' + cast([ID_Book] as varchar(10)) persisted,
  [ID_NXB] int,
  [name] nvarchar(150),
  [amount] int,
  [year] int,
  [status] int,
  [quantity] int,
  PRIMARY KEY ([ID_Book])
);

CREATE TABLE [BookCategory] (
  [ID_BookCategory] int identity(1,1),
  [ID_Book] int,
  [ID_Category] int,
  PRIMARY KEY ([ID_BookCategory])
);

CREATE TABLE [Order] (
  [ID_Order] int identity(1,1),
  [Ma_Oder] as 'OD' + cast([ID_Order] as varchar(10)) persisted,
  [ID_Bill] int,
  [note] nvarchar(150),
  PRIMARY KEY ([ID_Order])
);

CREATE TABLE [Bill] (
  [ID_Bill] int identity(1,1),
  [Ma_Bill] as 'B' + cast(ID_Bill as varchar(10)) persisted,
  [ID_KH] int,
  [amount] int,
  [billDate] datetime,
  [note] varchar(200),
  [billStatus] int,
  PRIMARY KEY ([ID_Bill])
);

CREATE TABLE [BookAuthor] (
  [ID_BookAuthor] int identity(1,1),
  [ID_Book] int,
  [ID_Author] int,
  PRIMARY KEY ([ID_BookAuthor])
);

go

alter table BookAuthor
add constraint FK_BookAuthor_Book_ID_Book
foreign key (ID_Book)
references Book(ID_Book)


alter table BookAuthor
add constraint FK_BookAuthor_Author_ID_Author
foreign key (ID_Author)
references Author(ID_Author)

alter table BookCategory
add constraint FK_BookCategory_Book_ID_Book
foreign key (ID_Book)
references Book(ID_Book)

alter table BookCategory
add constraint Fk_BookCategory_Category_ID_Category
foreign key (ID_Category)
references Category(ID_Category)

alter table Book
add constraint FK_Book_NXB_ID_NXB
foreign key (ID_NXB)
references NXB(ID_NXB)

alter table OrderDetail
add constraint FK_OrderDetail_Book_ID_Book
foreign key (ID_Book)
references Book(ID_Book)

alter table OrderDetail
add constraint FK_OrderDetail_Order_ID_Order
foreign key (ID_Order)
references [Order](ID_Order)

alter table [Order]
add constraint Fk_Order_Bill_ID_Bill
foreign key (ID_Bill)
references Bill(ID_Bill)

alter table Bill
add constraint FK_Bill_KhachHang_ID_KH
foreign key (ID_KH)
references KhachHang(ID_KH)

go