create table usuario
	(claveU int primary key,
	email varchar(30) not null,
	password varchar(30) not null,
	nombre varchar(100) not null,
	sexo varchar(1),
	edad int);

create table consola
	(claveCon int primary key,
	nombre varchar(50))

create table juego
	(claveJ int primary key,
	nombre varchar(100) not null,
	resumen varchar(250) not null,
	claveCon int not null references consola,
	fechaLanzamiento datetime not null);

create table critica
	(claveC int primary key,
	titulo varchar(100) not null,
	fecha datetime not null,
	contentido varchar(250) not null,
	calif int);

create table escriben
	(claveU int references usuario,
	claveJ int references juego,
	claveC int references critica,
	primary key (claveJ,claveC));
