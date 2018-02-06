DROP TABLE IF EXISTS Plati CASCADE;
DROP TABLE IF EXISTS MetodePlati CASCADE;
DROP TABLE IF EXISTS Detalii_ComandaF CASCADE;
DROP TABLE IF EXISTS Materii_Prime CASCADE;
DROP TABLE IF EXISTS Detalii_Comanda CASCADE;
DROP TABLE IF EXISTS Produse_Finite CASCADE;
DROP TABLE IF EXISTS Facturi CASCADE;
DROP TABLE IF EXISTS Comenzi_Clienti CASCADE;
DROP TABLE IF EXISTS MetodeLivrare CASCADE;
DROP TABLE IF EXISTS Comenzi_Furnizori CASCADE;
DROP TABLE IF EXISTS Angajati CASCADE;
DROP TABLE IF EXISTS Furnizori CASCADE;
DROP TABLE IF EXISTS Clienti CASCADE;


CREATE TABLE Furnizori(
	Furnizor_ID numeric (3) PRIMARY KEY,
	Furnizor_Nume varchar (40),
	Persoana_Contact varchar(40),
	CUI numeric (10),
	Adresa varchar (50),
	Oras varchar (15),
	Regiune varchar (12),
	CodPostal numeric (6),
	Tara varchar (15),
	Telefon varchar (10),
	Fax varchar (10),
	PaginaWeb varchar (20),
	Banca varchar (25)
);

CREATE TABLE Clienti(
	Client_ID numeric (3) PRIMARY KEY,
	Client_Nume varchar (40),
	Persoana_Contact varchar(40),
	CUI numeric (10),
	Adresa varchar (50),
	Oras varchar (15),
	Regiune varchar (12),
	CodPostal numeric (6),
	Tara varchar (15),
	Telefon varchar (10),
	Fax varchar (10),
	Banca varchar(25)
);

CREATE TABLE Angajati(
	Angajat_ID numeric (3) PRIMARY KEY,
	Nume varchar (40),
	Prenume varchar (40),
	Functie varchar (15),
	DataNasterii DATE,
	DataAngajare DATE,
	Adresa varchar (50),
	Oras varchar (50),
	Regiune varchar (50),
	CodPostal numeric (6),
	Tara varchar (15),
	Telefon varchar (10),
	email varchar (40),
	sex char (8),
	salariu numeric (5)
);

CREATE TABLE MetodeLivrare(
	MetodaLivrare_ID numeric(2) PRIMARY KEY,
	MetodaLivrare varchar (11)
);

CREATE TABLE MetodePlati(
	MetodaPlata_ID numeric(2) PRIMARY KEY,
	MetodaPlata varchar (20)
);

CREATE TABLE Comenzi_Furnizori(
	ComandaF_ID numeric (3) NOT NULL PRIMARY KEY,
	Furnizor_ID numeric (3) REFERENCES Furnizori(Furnizor_ID),
	Angajat_ID numeric (3) REFERENCES Angajati(Angajat_ID),
	DataComanda DATE,
	DataLimita DATE,
	DataLivrare DATE
);

CREATE TABLE Materii_Prime(
	MP_ID numeric (3) PRIMARY KEY,
	Denumire varchar (15)
);

CREATE TABLE Detalii_ComandaF (
	ComandaF_ID numeric (3) REFERENCES Comenzi_Furnizori (ComandaF_ID),
	MP_ID numeric (3) REFERENCES Materii_Prime (MP_ID),
	Pret_Unitar double precision,
	Cantitate numeric (6),
	Unitate_Masura varchar (10),
	Discount double precision,
	TVA double precision,
	Total double precision 
);
ALTER TABLE Detalii_ComandaF ADD CONSTRAINT pk_dcf PRIMARY KEY (ComandaF_ID, MP_ID);

CREATE TABLE Comenzi_Clienti(
	ComandaC_ID numeric (3) NOT NULL PRIMARY KEY,
	Client_ID numeric (3) REFERENCES Clienti(Client_ID),
	Angajat_ID numeric (3) REFERENCES Angajati(Angajat_ID),
	MetodaLivrare_ID numeric (2) REFERENCES MetodeLivrare (MetodaLivrare_ID),
	DataComanda DATE,
	DataLimita DATE,
	DataLivrare DATE
);

CREATE TABLE Produse_Finite(
	Produs_ID numeric (3) NOT NULL PRIMARY KEY,
	Denumire varchar (30),
	PeStoc numeric (3),
	Pretperkg numeric (3)
);

CREATE TABLE Detalii_Comanda (
	ComandaC_ID numeric (3) REFERENCES Comenzi_Clienti (ComandaC_ID),
	Produs_ID numeric (3) REFERENCES Produse_Finite (Produs_ID),
	PretperKg numeric (3),
	Cantitate numeric (6),
	TVA numeric double precision,
	Total double precision
);
ALTER TABLE Detalii_Comanda ADD CONSTRAINT pk_dcc PRIMARY KEY (ComandaC_ID, Produs_ID);

CREATE TABLE Facturi (
	Factura_ID numeric (3) PRIMARY KEY,
	Data_Factura DATE,
	DataScadenta DATE,
	ComandaF_ID numeric (3)  REFERENCES Comenzi_Furnizori(ComandaF_ID),
	ComandaC_ID numeric (3)  REFERENCES Comenzi_Clienti(ComandaC_ID),
	ValoareFactura double precision
);

CREATE TABLE Plati (
	Factura_ID numeric (3) REFERENCES Facturi(Factura_ID),
	Valoare double precision,
	DataPlata DATE,
	nrordinplata numeric(10),
	ibanplatitor varchar(24),
	ibanbeneficiar varchar (24),
	MetodaPlata_ID numeric (2) REFERENCES MetodePlati (MetodaPlata_ID)
);
ALTER TABLE Plati ADD CONSTRAINT pk_plati PRIMARY KEY (Factura_ID);
--alter table plati add constraint uk_nrordin UNIQUE (nrordinplata);