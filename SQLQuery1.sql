CREATE TABLE Kullanici (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Isim NVARCHAR(50),
    Soyisim NVARCHAR(50),
    Email NVARCHAR(100),
    Sifre NVARCHAR(100)
);
