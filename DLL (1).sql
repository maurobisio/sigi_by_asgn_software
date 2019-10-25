SHOW VARIABLES LIKE 'collation_server';
CREATE DATABASE `sigesi` /*!40100 COLLATE 'latin1_swedish_ci' */;
SHOW DATABASES;
/* Entrando a la sesión "Unnamed" */
SELECT `DEFAULT_COLLATION_NAME` FROM `information_schema`.`SCHEMATA` WHERE `SCHEMA_NAME`='sigesi';
SHOW TABLE STATUS FROM `sigesi`;
SHOW FUNCTION STATUS WHERE `Db`='sigesi';
SHOW PROCEDURE STATUS WHERE `Db`='sigesi';
SHOW TRIGGERS FROM `sigesi`;
SELECT *, EVENT_SCHEMA AS `Db`, EVENT_NAME AS `Name` FROM information_schema.`EVENTS` WHERE `EVENT_SCHEMA`='sigesi';
USE `sigesi`;

CREATE TABLE rol(
					id_rol int not null,
                    nombre_rol varchar(50),
                    primary  key (id_rol)
					);

CREATE TABLE usuario(
					ci int not null,
                    primer_nombre varchar(100),
                    segundo_nombre varchar(100),
                    apellido varchar(100),
                    direccion varchar(100),
                    email varchar(50),
                    pass varchar(50),
                    id_rol int not null,
                    primary key (ci),
                    foreign key (id_rol) references rol (id_rol)
                    );

CREATE TABLE usuario_telefono(
					ci int not null,
                    telefono int not null,
                    primary key (ci, telefono),
                    foreign key (ci) references usuario (ci)
                    );
                    
CREATE TABLE documento(
					tipo_doc varchar(100),
                    primary key (tipo_doc)
                    );
                    
CREATE TABLE solicita(
					ci int not null,
                    fecha date not null,
                    hora time(6) not null,
                    tipo_doc varchar(100),
                    primary key (ci),
                    foreign key (ci) references usuario (ci)
                    );
                    
CREATE TABLE solicita_gestiona(
					ci int not null,
                    fecha date not null,
                    hora time(6) not null,
                    tipo_doc varchar(100),
                    primary key (ci, tipo_doc),
					foreign key (ci) references usuario (ci),
                    foreign key (tipo_doc) references documento (tipo_doc)
                    );
                    
CREATE TABLE edificio(
                    id_edificio int not null,
					tipo_edificio varchar(50),
                    primary key (id_edificio)
                    );
	
CREATE TABLE grupo(
                    id_grupo int not null,
					nombre_grupo varchar(10),
                    turno varchar(20),
                    id_edificio int not null,
                    primary key (id_grupo),
                    foreign key (id_edificio) references edificio (id_edificio)
                    );
                    
CREATE TABLE materia(
					id_materia int not null,
                    nom_materia varchar(20),
                    año int not null,
                    primary key (id_materia)
                    );
                    
CREATE TABLE tiene (
                    id_tiene int not null AUTO_INCREMENT,
					id_materia int not null,
                    id_grupo int not null,
                    primary key (id_tiene, id_materia, id_grupo),
                    foreign key (id_materia) references materia (id_materia),
                    foreign key (id_grupo) references grupo (id_grupo)
                    );

CREATE TABLE pertenece(
                    id_pertenece int not null AUTO_INCREMENT,
					ci int not null,
                    id_tiene int not null,
                    nro_lista int not null,
                    primary key (id_pertenece, ci, id_tiene),
                    foreign key (ci) references usuario (ci),
                    foreign key (id_tiene) references tiene (id_tiene)
                    );

CREATE TABLE registro_tiene(
                    id_registro_tiene int not null,
					id_tiene int not null,
                    falta_justificada char,
                    falta_injustificada char,
                    promedio_1 int,
                    promedio_2 int,
                    promedio_3 int,
                    ci int not null,
					primary key (id_registro_tiene, id_tiene, ci),
                    foreign key (id_tiene) references tiene (id_tiene),
                    foreign key (ci) references usuario (ci)
                    );
                    
CREATE TABLE registro_notas(
					id_registro_nota int not null,
					id_tiene int not null,
                    ci int not null,
                    notas int,
                    primary key (id_tiene, id_registro_nota, ci),
                    foreign key (id_tiene) references tiene (id_tiene),
                    foreign key (ci) references usuario (ci)
                    );
                    
CREATE TABLE registro_faltas(
					id_registro_faltas int not null,
					id_tiene int not null,
                    ci int not null,
                    faltas int,
                    primary key (id_tiene, id_registro_faltas, ci),
                    foreign key (id_tiene) references tiene (id_tiene),
                    foreign key (ci) references usuario (ci)
                    );

INSERT INTO rol (id_rol, nombre_rol) 
VALUES ('0','Administrador de sistema');
INSERT INTO rol (id_rol, nombre_rol)  
VALUES ('1','Director/a');
INSERT INTO rol (id_rol, nombre_rol)  
VALUES ('2','Bedel');
INSERT INTO rol (id_rol, nombre_rol) 
VALUES ('3','Administrativo/a');
INSERT INTO rol (id_rol, nombre_rol)  
VALUES ('4','Docente');
INSERT INTO rol (id_rol, nombre_rol) 
VALUES ('5','Alumno/a');

INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, pass, id_rol)
VALUES ('0', 'root', 'root', 'root', 'root', 'root', 'root','0');

INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, pass, id_rol)
VALUES ('1', 'director', 'director', 'director', 'director', 'director', 'director','1');

INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, pass, id_rol)
VALUES ('2', 'bedel', 'bedel', 'bedel', 'bedel', 'bedel', 'bedel','2');

INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, pass, id_rol)
VALUES ('3', 'admin', 'admin', 'admin', 'admin', 'admin', 'admin','3');

INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, pass, id_rol)
VALUES ('4', 'docente', 'docente', 'docente', 'docente', 'docente', 'docente','4');

INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, pass, id_rol)
VALUES ('5', 'alumno', 'alumno', 'alumno', 'alumno', 'alumno', 'alumno','5');

INSERT INTO materia (id_materia, nom_materia, año) 
VALUES ('0','Fisica', '2019');

INSERT INTO materia (id_materia, nom_materia, año) 
VALUES ('1','Quimica', '2019');

INSERT INTO materia (id_materia, nom_materia, año) 
VALUES ('2','Sociologia', '2019');

INSERT INTO materia (id_materia, nom_materia, año) 
VALUES ('3','Historia', '2019');

INSERT INTO materia (id_materia, nom_materia, año) 
VALUES ('4','Base de Datos', '2019');

INSERT INTO edificio (id_edificio, tipo_edificio) 
VALUES ('0','Central');

INSERT INTO edificio (id_edificio, tipo_edificio) 
VALUES ('1','Anexo 1');

INSERT INTO edificio (id_edificio, tipo_edificio) 
VALUES ('2','Anexo 2');

INSERT INTO grupo (id_grupo, nombre_grupo, turno, id_edificio) 
VALUES ('0','3ro HI', 'Matutino', '0');

INSERT INTO grupo (id_grupo, nombre_grupo, turno, id_edificio) 
VALUES ('1','2ro HI', 'Vespertino', '1');

INSERT INTO grupo (id_grupo, nombre_grupo, turno, id_edificio) 
VALUES ('2','1ro HI', 'Nocturno', '2');

INSERT INTO tiene (id_grupo,id_materia)
VALUES ('0','0');

INSERT INTO pertenece (ci, id_tiene, nro_lista)
VALUES ('5','1','0');
