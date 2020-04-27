create table garagem (
	id int identity (1, 1) not null,
	cnpj varchar (14) not null,
	nome varchar (100) not null,
	telefone varchar (15) not null,
	constraint pk_garagem primary key (id),
	constraint uq_garagem unique (cnpj, nome)
);

create table cliente (
	id int identity (1, 1) not null,
	nome varchar (100) not null,
	telefone varchar (15) not null,
	constraint pk_cliente primary key (id),
	constraint uq_cliente unique (nome, telefone)
);

create table funcionario (
	id int identity (1, 1) not null,
	nome varchar (100) not null,
	telefone varchar (15) not null,
	salario decimal (8, 2) not null,
	constraint pk_funcionario primary key (id),
	constraint uq_funcionario unique (nome, telefone)
);

create table motor (
	id int identity (1, 1) not null,
	descricao varchar (100) not null,
	constraint pk_motor primary key (id),
	constraint uq_motor unique (descricao)
);

create table carro (
	id int identity (1, 1) not null,
	nome varchar (100) not null,
	marca varchar (100) not null,
	modelo varchar (100) not null,
	cor varchar (50),
	ano_fabricacao int not null,
	ano_modelo int not null,
	id_motor int not null,
	id_garagem int not null,
	constraint pk_carro primary key (id),
	constraint fk_carro_motor foreign key (id_motor) references motor (id),
	constraint fk_carro_garagem foreign key (id_garagem) references garagem (id)
);

create table atendimento (
	id int identity (1, 1) not null,
	data datetime not null,
	id_cliente int not null,
	id_carro int not null,
	constraint pk_atendimento primary key (id),
	constraint fk_atendimento_cliente foreign key (id_cliente) references cliente (id),
	constraint fk_atendimento_carro foreign key (id_carro) references carro (id)
);