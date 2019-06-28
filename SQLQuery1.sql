﻿drop table if exists CONSUMOS
drop table if exists ESTOQUES
drop table if exists QUARTOS
drop table if exists CHECKOUTS
drop table if exists CHECKINS
drop table if exists PRODUTOS
drop table if exists FORNECEDORES
drop table if exists CLIENTES
drop table if exists USUARIOS

CREATE TABLE USUARIOS(

ID INT PRIMARY KEY IDENTITY,
NOME VARCHAR(50) NOT NULL,
RG VARCHAR(10) UNIQUE NOT NULL,
CPF VARCHAR(14) UNIQUE NOT NULL,
ENDERECO VARCHAR(100) NOT NULL,
TELEFONE VARCHAR(20) NOT NULL,
EMAIL VARCHAR(50) UNIQUE NOT NULL,
SENHA VARCHAR(200) NOT NULL,
IS_ADMIN bit NOT NULL 
)

CREATE TABLE CLIENTES(

ID INT PRIMARY KEY IDENTITY,
NOME VARCHAR(50) NOT NULL,
RG VARCHAR(10) UNIQUE NOT NULL,
CPF VARCHAR(14) UNIQUE NOT NULL,
TELEFONE_1 VARCHAR(100) NOT NULL,
TELEFONE_2 VARCHAR(100) NOT NULL,
EMAIL VARCHAR(50) UNIQUE NOT NULL,
USUARIO_ID int REFERENCES USUARIOS(ID) NOT NULL
)

CREATE TABLE FORNECEDORES(

ID INT PRIMARY KEY IDENTITY,
RAZAO_SOCIAL VARCHAR(20) NOT NULL UNIQUE,
CNPJ VARCHAR(21) NOT NULL UNIQUE,
NOME_CONTATO VARCHAR(50) NOT NULL,
TELEFONE VARCHAR(30) NOT NULL,
EMAIL VARCHAR(50) NOT NULL UNIQUE,
USUARIO_ID int FOREIGN KEY REFERENCES USUARIOS(ID) NOT NULL

)

CREATE TABLE PRODUTOS(

ID INT PRIMARY KEY IDENTITY,
NOME VARCHAR(50) NOT NULL,
DESCRICAO VARCHAR(100) NOT NULL,
PRECO FLOAT NOT NULL,
QTD_ESTOQUE INT NULL,
USUARIO_ID int FOREIGN KEY REFERENCES USUARIOS(ID) NOT NULL
)

CREATE TABLE QUARTOS(

ID INT PRIMARY KEY IDENTITY,
VALOR_DIARIA FLOAT NOT NULL,
USUARIO_ID int FOREIGN KEY REFERENCES USUARIOS(ID) NOT NULL,
ESTA_OCUPADO BIT NOT NULL
)

CREATE TABLE RESERVAS(

ID INT PRIMARY KEY IDENTITY,
USUARIO_ID int FOREIGN KEY REFERENCES USUARIOS(ID) NOT NULL,
CLIENTE_ID int FOREIGN KEY REFERENCES CLIENTES(ID) NOT NULL,
DATA_PREVISAO_CHEGADA DATE NOT NULL,
DATA_PREVISAO_SAIDA DATE NOT NULL,
ID_QUARTO INT REFERENCES  QUARTOS(ID) NOT NULL
)

CREATE TABLE CHECKINS(

ID INT PRIMARY KEY IDENTITY,
DATA_ENTRADA DATE NOT NULL,
DATA_PREVISTA_SAIDA DATE NOT NULL,
QUARTO_ID int FOREIGN KEY REFERENCES QUARTOS(ID) NOT NULL,
CLIENTE_ID int FOREIGN KEY REFERENCES CLIENTES(ID) NOT NULL,
ID_RESERVA INT REFERENCES RESERVAS(ID) NULL
)

CREATE TABLE CHECKOUTS(

ID INT PRIMARY KEY IDENTITY,
CHECK_IN_ID int FOREIGN KEY REFERENCES CHECKINS(ID) NOT NULL,
VALOR_TOTAL FLOAT NOT NULL,
DATA_SAIDA DATE NOT NULL
)

CREATE TABLE ENTRADAPRODUTOS
(
ID INT PRIMARY KEY IDENTITY,
USUARIO_ID int FOREIGN KEY REFERENCES USUARIOS(ID) NOT NULL,
DATA_ENTRADA DATE NOT NULL,
VALORTOTAL FLOAT NOT NULL
)

CREATE TABLE ENTRADAPRODUTOSDETALHES
(
ENTRADAPRODUTO INT NOT NULL REFERENCES ENTRADAPRODUTOS,
PRODUTO INT NOT NULL REFERENCES PRODUTOS,
FORNECEDOR_ID int FOREIGN KEY REFERENCES FORNECEDORES(ID) NOT NULL,
QUANTIDADE INT NOT NULL,
VALOR_UNITARIO FLOAT NOT NULL,
PRIMARY KEY (ENTRADAPRODUTO, PRODUTO)
)

CREATE TABLE SAIDAPRODUTOSDETALHES
(
SAIDAPRODUTO INT NOT NULL REFERENCES ENTRADAPRODUTOS,
PRODUTO INT NOT NULL REFERENCES PRODUTOS,
FORNECEDOR_ID int FOREIGN KEY REFERENCES FORNECEDORES(ID) NOT NULL,
QUANTIDADE INT NOT NULL,
VALOR_UNITARIO FLOAT NOT NULL,
PRIMARY KEY (ENTRADAPRODUTO, PRODUTO)
)