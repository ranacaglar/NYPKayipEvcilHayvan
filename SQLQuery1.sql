USE EvcilHayvanDB;

CREATE TABLE Sahipler (
    SahipID INT PRIMARY KEY IDENTITY,
    AdSoyad NVARCHAR(100),
    Telefon NVARCHAR(20),
    Eposta NVARCHAR(100)
);

CREATE TABLE Hayvanlar (
    HayvanID INT PRIMARY KEY IDENTITY,
    Ad NVARCHAR(50),
    Tur NVARCHAR(50),
    Cins NVARCHAR(50),
    Renk NVARCHAR(30),
    KaybolmaTarihi DATE,
    SahipID INT FOREIGN KEY REFERENCES Sahipler(SahipID)
);

CREATE TABLE Ilanlar (
    IlanID INT PRIMARY KEY IDENTITY,
    HayvanID INT FOREIGN KEY REFERENCES Hayvanlar(HayvanID),
    IlanTarihi DATE,
    Aciklama NVARCHAR(250)
);





DELETE FROM Ilanlar;
DBCC CHECKIDENT ('Ilanlar', RESEED, 0);

DELETE FROM Hayvanlar;
DBCC CHECKIDENT ('Hayvanlar', RESEED, 0);

DELETE FROM Sahipler;
DBCC CHECKIDENT ('Sahipler', RESEED, 0);
