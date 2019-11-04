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
                    telefono varchar(50),
                    pass varchar(50),
                    id_rol int not null,
                    estado int not null,
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
                    id_edificio int not null AUTO_INCREMENT,
					tipo_edificio varchar(50),
                    primary key (id_edificio)
                    );
	
CREATE TABLE grupo(
                    id_grupo int not null AUTO_INCREMENT,
					nombre_grupo varchar(10),
                    turno varchar(20),
                    id_edificio int not null,
                    primary key (id_grupo),
                    foreign key (id_edificio) references edificio (id_edificio)
                    );
                    
CREATE TABLE materia(
					id_materia int not null AUTO_INCREMENT,
                    nom_materia varchar(20),
                    año int not null,
                    primary key (id_materia)
                    );
                    
CREATE TABLE tiene (
                    id_tiene int not null AUTO_INCREMENT,
					id_materia int not null,
                    id_grupo int not null,
                    primary key (id_tiene),
                    foreign key (id_materia) references materia (id_materia),
                    foreign key (id_grupo) references grupo (id_grupo)
                    );

CREATE TABLE pertenece(
                    id_pertenece int not null AUTO_INCREMENT,
					ci int not null,
                    id_tiene int not null,
                    nro_lista int not null,
                    primary key (id_pertenece),
                    foreign key (ci) references usuario (ci),
                    foreign key (id_tiene) references tiene (id_tiene)
                    );

CREATE TABLE tipo_registro(
					id_tipo_registro int not null AUTO_INCREMENT,
					nom_registro varchar(250) not null,
                    primary key (id_tipo_registro)
                    );

CREATE TABLE registro(
					id_registro int not null AUTO_INCREMENT,
					id_pertenece int not null,
                    id_tipo_registro int not null,
                    valor int,
                    observacion varchar(250),
                    fecha datetime, 
                    primary key (id_registro),
                    foreign key (id_pertenece) references pertenece (id_pertenece),
                    foreign key (id_tipo_registro) references tipo_registro (id_tipo_registro)
                    );

CREATE TABLE tipo_incidencia(
					id_tipo_incidencia int not null AUTO_INCREMENT,
					nom_tipo varchar(250) not null,
                    primary key (id_tipo_incidencia)
                    );

CREATE TABLE incidencia(
					id_incidencia int not null AUTO_INCREMENT,
					id_alumno int not null,
                    id_autoridad int not null,
                    id_tipo_incidencia int not null,
                    observación varchar(250),
                    fecha datetime, 
                    primary key (id_incidencia),
                    foreign key (id_tipo_incidencia) references tipo_incidencia (id_tipo_incidencia),
                    foreign key (id_alumno) references usuario (ci),
                    foreign key (id_autoridad) references usuario (ci)
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

INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, telefono, pass, id_rol, estado)
VALUES ('0', 'root', 'root', 'root', 'root', 'root', 'tel','root','0', '1');
INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, telefono, pass, id_rol, estado)
VALUES ('49508304', 'director', 'director', 'director', 'director', 'director', 'tel','director','1', '1');
INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, telefono, pass, id_rol, estado)
VALUES ('33288615', 'bedel', 'bedel', 'bedel', 'bedel', 'bedel','tel', 'bedel','2', '1');
INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, telefono, pass, id_rol, estado)
VALUES ('14869143', 'admin', 'admin', 'admin', 'admin', 'admin', 'tel','admin','3', '1');
INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, telefono, pass, id_rol, estado)
VALUES ('10749389', 'docente', 'docente', 'docente', 'docente', 'docente', 'tel','docente','4', '1');
INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, telefono, pass, id_rol, estado)
VALUES ('49348459', 'alumno', 'alumno', 'alumno', 'alumno', 'alumno', 'tel','alumno','5', '1');

INSERT INTO materia (nom_materia, año) 
VALUES ('Fisica', '2019');
INSERT INTO materia (nom_materia, año) 
VALUES ('Quimica', '2019');
INSERT INTO materia (nom_materia, año) 
VALUES ('Sociologia', '2019');
INSERT INTO materia (nom_materia, año) 
VALUES ('Historia', '2019');
INSERT INTO materia (nom_materia, año) 
VALUES ('Base de Datos', '2019');

INSERT INTO edificio (tipo_edificio) 
VALUES ('Dirección');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Aulas');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Laboratorios');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Sub Dirección');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Adscripción');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Administración');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Cordinación de Informatica');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Biblioteca');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Salas de profesores');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Salas de servidores');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Cantina');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Patio');
INSERT INTO edificio (tipo_edificio) 
VALUES ('Corredores');

INSERT INTO grupo (nombre_grupo, turno, id_edificio) 
VALUES ('3ro HI', 'Matutino', '1');
INSERT INTO grupo (nombre_grupo, turno, id_edificio) 
VALUES ('2ro HI', 'Vespertino', '2');
INSERT INTO grupo (nombre_grupo, turno, id_edificio) 
VALUES ('1ro HI', 'Nocturno', '3');

INSERT INTO tiene (id_grupo,id_materia)
VALUES ('1','1');
INSERT INTO tiene (id_grupo,id_materia)
VALUES ('1','2');
INSERT INTO tiene (id_grupo,id_materia)
VALUES ('1','3');
INSERT INTO tiene (id_grupo,id_materia)
VALUES ('2','2');
INSERT INTO tiene (id_grupo,id_materia)
VALUES ('2','3');


INSERT INTO pertenece (ci, id_tiene, nro_lista)
VALUES ('49508304','1','0');
INSERT INTO pertenece (ci, id_tiene, nro_lista)
VALUES ('33288615','1','0');
INSERT INTO pertenece (ci, id_tiene, nro_lista)
VALUES ('14869143','1','0');
INSERT INTO pertenece (ci, id_tiene, nro_lista)
VALUES ('10749389','1','0');
INSERT INTO pertenece (ci, id_tiene, nro_lista)
VALUES ('49348459','1','0');
INSERT INTO pertenece (ci, id_tiene, nro_lista)
VALUES ('49348459','2','0');
INSERT INTO pertenece (ci, id_tiene, nro_lista)
VALUES ('49348459','3','0');


INSERT INTO tipo_registro (nom_registro)
VALUES ('Calificación');
INSERT INTO tipo_registro (nom_registro)
VALUES ('Inasistencia');
INSERT INTO tipo_registro (nom_registro)
VALUES ('Calificación Final');
INSERT INTO tipo_registro (nom_registro)
VALUES ('Revalida');

INSERT INTO tipo_incidencia (nom_tipo)
VALUES ('Suspención');
INSERT INTO tipo_incidencia (nom_tipo)
VALUES ('Observaciones');
INSERT INTO tipo_incidencia (nom_tipo)
VALUES ('Califiaciónes bajas');
INSERT INTO tipo_incidencia (nom_tipo)
VALUES ('Solicitud de boletin');
INSERT INTO tipo_incidencia (nom_tipo)
VALUES ('Formula 69');
INSERT INTO tipo_incidencia (nom_tipo)
VALUES ('Escolaridad');
INSERT INTO tipo_incidencia (nom_tipo)
VALUES ('Pase Egreso');
INSERT INTO tipo_incidencia (nom_tipo)
VALUES ('Ficha Acumulativa');


INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('6','1', '8','Calificación','2019-10-31 10:12:00');
INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('6','1', '7','Calificación','2019-10-31 10:12:00');
INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('6','1', '10','Calificación','2019-10-31 10:12:00');
INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('5','1', '8','Calificación','2019-10-31 10:12:00');
INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('5','1', '7','Calificación','2019-10-31 10:12:00');
INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('5','1', '10','Calificación','2019-10-31 10:12:00');
INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('7','1', '3','Calificación','2019-10-31 10:12:00');
INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('7','1', '6','Calificación','2019-10-31 10:12:00');
INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('7','1', '12','Calificación','2019-10-31 10:12:00');


INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('5','3', '8','Calificación Final','2019-10-31 10:12:00');
INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('6','3', '9','Calificación Final','2019-10-31 10:12:00');
INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha)
VALUES ('7','3', '7','Calificación Final','2019-10-31 10:12:00');


INSERT INTO incidencia(id_alumno, id_autoridad, id_tipo_incidencia, observación, fecha)
VALUES ('49348459','49508304', '1','Suspencion','2019-10-31 10:12:00');
INSERT INTO incidencia(id_alumno, id_autoridad, id_tipo_incidencia, observación, fecha)
VALUES ('49348459','33288615', '1','Suspencion','2019-10-31 10:12:00');
INSERT INTO incidencia(id_alumno, id_autoridad, id_tipo_incidencia, observación, fecha)
VALUES ('49348459','14869143', '1','Suspencion','2019-10-31 10:12:00');
INSERT INTO incidencia(id_alumno, id_autoridad, id_tipo_incidencia, observación, fecha)
VALUES ('49348459','10749389', '1','Suspencion','2019-10-31 10:12:00');


