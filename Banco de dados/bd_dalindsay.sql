create database bd_lindsaypo2;

use bd_lindsaypo2;

create table empresa(
id_emp int primary key auto_increment,
nomeFan_emp varchar (300) not null,
rzSocial_emp varchar(300) not null,
stCadastral_emp varchar(300) not null,
cpnj_emp varchar(20) not null,
telefone_emp varchar(100) not null,
dtInicio_emp varchar(100) not null,
rgTributario_emp varchar(300) not null,
endereco_emp varchar (300) not null,
cidade_emp varchar (300) not null,
estado_emp varchar (300) not null,
funcao_emp varchar (300) not null,
tipo_emp varchar (300) not null,
ptEmpresa_emp varchar (300) not null,
ntJuridica_emp varchar (300) not null,
nmProprie_emp varchar (300) not null,
cpfProprie_emp varchar (14) not null
);

create table funcionario(
id_fun int primary key auto_increment,
name_fun varchar (300) not null,
cpf_fun varchar (14) not null,
rg_fun varchar (10) not null,
email_fun varchar (300) not null,
celular_fun varchar (100) not null,
dtNascimento_fun varchar (100) not null,
estadociv_fun varchar (300) not null,
endereco_fun varchar (300) not null,
cidade_fun varchar (300) not null,
estado_fun varchar (300) not null,
funcao_fun varchar (300) not null,
salario_fun varchar (100)
);

INSERT INTO empresa (nomeFan_emp, rzSocial_emp, stCadastral_emp, cpnj_emp, telefone_emp, dtInicio_emp, rgTributario_emp, endereco_emp, cidade_emp, estado_emp, funcao_emp, tipo_emp, ptEmpresa_emp, ntJuridica_emp, nmProprie_emp, cpfProprie_emp) VALUES
('Empresa 1', 'Razão Social 1', 'Status Cadastral 1', '00.000.000/0001-00', '(11) 1111-1111', '2023-01-01', 'Regime Tributário 1', 'Endereço 1', 'Cidade 1', 'Estado 1', 'Função 1', 'Tipo 1', 'Ponto Empresa 1', 'Natureza Jurídica 1', 'Proprietário 1', '000.000.000-01'),
('Empresa 2', 'Razão Social 2', 'Status Cadastral 2', '11.111.111/1111-11', '(22) 2222-2222', '2023-02-02', 'Regime Tributário 2', 'Endereço 2', 'Cidade 2', 'Estado 2', 'Função 2', 'Tipo 2', 'Ponto Empresa 2', 'Natureza Jurídica 2', 'Proprietário 2', '111.111.111-11'),
('Empresa 3', 'Razão Social 3', 'Status Cadastral 3', '22.222.222/2222-22', '(33) 3333-3333', '2023-03-03', 'Regime Tributário 3', 'Endereço 3', 'Cidade 3', 'Estado 3', 'Função 3', 'Tipo 3', 'Ponto Empresa 3', 'Natureza Jurídica 3', 'Proprietário 3', '222.222.222-22'),
('Empresa 4', 'Razão Social 4', 'Status Cadastral 4', '33.333.333/3333-33', '(44) 4444-4444', '2023-04-04', 'Regime Tributário 4', 'Endereço 4', 'Cidade 4', 'Estado 4', 'Função 4', 'Tipo 4', 'Ponto Empresa 4', 'Natureza Jurídica 4', 'Proprietário 4', '333.333.333-33'),
('Empresa 5', 'Razão Social 5', 'Status Cadastral 5', '44.444.444/4444-44', '(55) 5555-5555', '2023-05-05', 'Regime Tributário 5', 'Endereço 5', 'Cidade 5', 'Estado 5', 'Função 5', 'Tipo 5', 'Ponto Empresa 5', 'Natureza Jurídica 5', 'Proprietário 5', '444.444.444-44');

INSERT INTO funcionario (name_fun, cpf_fun, rg_fun, email_fun, celular_fun, dtNascimento_fun, estadociv_fun, endereco_fun, cidade_fun, estado_fun, funcao_fun, salario_fun) VALUES
('Funcionário 1', '000.000.000-00', '1.111.111', 'funcionario1@email.com', '(11) 1111-1111', '1990-01-01', 'Solteiro', 'Endereço 1', 'Cidade 1', 'Estado 1', 'Função 1', '2000'),
('Funcionário 2', '111.111.111-11', '2.222.222', 'funcionario2@email.com', '(22) 2222-2222', '1991-02-02', 'Casado', 'Endereço 2', 'Cidade 2', 'Estado 2', 'Função 2', '2500'),
('Funcionário 3', '222.222.222-22', '3.333.333', 'funcionario3@email.com', '(33) 3333-3333', '1992-03-03', 'Solteiro', 'Endereço 3', 'Cidade 3', 'Estado 3', 'Função 3', '3000'),
('Funcionário 4', '333.333.333-33', '4.444.444', 'funcionario4@email.com', '(44) 4444-4444', '1993-04-04', 'Casado', 'Endereço 4', 'Cidade 4', 'Estado 4', 'Função 4', '3500'),
('Funcionário 5', '444.444.444-44', '5.555.555', 'funcionario5@email.com', '(55) 5555-5555', '1994-05-05', 'Solteiro', 'Endereço 5', 'Cidade 5', 'Estado 5', 'Função 5', '4000');
