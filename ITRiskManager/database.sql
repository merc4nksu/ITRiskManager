USE [YOUR_DB]
GO
create table Assets(
    AssetID int primary key identity(1,1),
    AssetName nvarchar(200),
    AssetType nvarchar(50),
    AssetOwner nvarchar(100),
    criticalityScore int 
    );
create table Threats(
    ThreatID int primary key identity(1,1),
    ThreatName nvarchar(150),
    ThreatDescription nvarchar(500)
    );
    INSERT INTO Threats (ThreatName, ThreatDescription) VALUES ('Yetkisiz Erişim', 'Sisteme izinsiz giriş denemesi')
    INSERT INTO Threats (ThreatName, ThreatDescription) VALUES ('Veri Sızıntısı', 'Hassas verinin dışarı çıkması')
    INSERT INTO Threats (ThreatName, ThreatDescription) VALUES ('Fidye Yazılımı', 'Ransomware saldırısı')
    INSERT INTO Threats (ThreatName, ThreatDescription) VALUES ('DDoS Saldırısı', 'Sistemi servis dışı bırakma')
    INSERT INTO Threats (ThreatName, ThreatDescription) VALUES ('İç Tehdit', 'Çalışan kaynaklı tehdit')
create table Vulnerabilities(
    VulID int primary key identity(1,1),
    VulName nvarchar(150),
    VulDescription nvarchar(500)
    );
    INSERT INTO Vulnerabilities (VulName, VulDescription) VALUES ('Zayıf Parola', 'Tahmin edilebilir şifre kullanımı')
    INSERT INTO Vulnerabilities (VulName, VulDescription) VALUES ('Güncellenmemiş Sistem', 'Patch uygulanmamış işletim sistemi')
    INSERT INTO Vulnerabilities (VulName, VulDescription) VALUES ('Açık Port', 'Gereksiz açık network portu')
    INSERT INTO Vulnerabilities (VulName, VulDescription) VALUES ('Yetki Fazlalığı', 'Kullanıcıya gereğinden fazla yetki verilmesi')
    INSERT INTO Vulnerabilities (VulName, VulDescription) VALUES ('Şifresiz İletişim', 'Veri transferinde şifreleme olmaması')
create table Risks(
    RiskID int primary key identity(1,1),
    AssetID int foreign key references Assets(AssetID),
    ThreatID int foreign key references Threats(ThreatID),
    VulID int foreign key references Vulnerabilities(VulID),
    Probability int check (probability between 1 and 5),
    Impact int check (impact between 1 and 5),
    RiskScore as (probability * impact) persisted,
    RiskLevel as (
  case 
    when (probability * impact) >= 15 then 'Kritik'
    when (probability * impact) >= 10 then 'Yüksek'
    when (probability * impact) >= 5  then 'Orta'
    else 'Düşük'
  end
) persisted,
createdAt datetime default getdate()
    ); 
select * from Assets;

select * from Threats;

select * from Vulnerabilities;

select * from Risks;

