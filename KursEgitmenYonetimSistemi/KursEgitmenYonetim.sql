CREATE DATABASE KursEgitmenYonetim;

USE KursEgitmenYonetim;

CREATE TABLE Egitmen (
    EgitmenID INT PRIMARY KEY IDENTITY(1,1),
    AdSoyad NVARCHAR(100),
    UzmanlikAlani NVARCHAR(50),    
    BildigiDiller NVARCHAR(200)    
);

CREATE TABLE Kurs (
    KursID INT PRIMARY KEY IDENTITY(1,1),
    KursAdi NVARCHAR(100),
    KursTuru NVARCHAR(50),         
    Dil NVARCHAR(50),              
    Seviye NVARCHAR(50),           
    ProgramlamaDili NVARCHAR(50),  
    Zorluk NVARCHAR(50),           
    EgitmenID INT FOREIGN KEY REFERENCES Egitmen(EgitmenID)
);

CREATE TABLE Admin (
    AdminID INT PRIMARY KEY IDENTITY(1,1),
    KullaniciAdi NVARCHAR(50) UNIQUE NOT NULL,
    Sifre NVARCHAR(100) NOT NULL
);

ALTER TABLE Egitmen
ADD KullandigiMalzemeler NVARCHAR(200),
    CalabildigiEnstrumanlar NVARCHAR(200);
