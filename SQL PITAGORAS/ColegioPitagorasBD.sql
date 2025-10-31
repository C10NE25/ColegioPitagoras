CREATE DATABASE ColegioPitagoras3;
GO
USE ColegioPitagoras3;
GO

----------------------------------------------------------
--------------			CRUDS			------------------
----------------------------------------------------------

/* Control Apoderado */
CREATE TABLE Apoderado (
    idApoderado INT IDENTITY(1,1) PRIMARY KEY,
    dniApo VARCHAR(8) NOT NULL,
    nombreApo VARCHAR(40) NOT NULL,
    apellidosApo VARCHAR(40) NOT NULL,
    numCelularApo VARCHAR(9) NOT NULL,
    direccionApo VARCHAR(100) NOT NULL,
    estadoApot BIT NOT NULL
);

----------------------------------------------------------

/* Control de Estudiantes */
CREATE TABLE Estudiante (
    idEstudiante INT IDENTITY(1,1) PRIMARY KEY,
    dniEst VARCHAR(8) NOT NULL,
    nombreEst VARCHAR(40) NOT NULL,
    apellidosEst VARCHAR(40) NOT NULL,
    fechaNacEst DATE NOT NULL,
    direccionEst VARCHAR(100) NOT NULL,
    idApoderado INT NOT NULL,
    estadoEst BIT NOT NULL,
    FOREIGN KEY (idApoderado) REFERENCES Apoderado(idApoderado)
);

----------------------------------------------------------

/* Control Docentes */
CREATE TABLE Docente (
    idDocente INT IDENTITY(1,1) PRIMARY KEY,
    dniDoc VARCHAR(8) NOT NULL,
    nombreDoc VARCHAR(40) NOT NULL,
    apellidosDoc VARCHAR(40) NOT NULL,
    numCelularDoc VARCHAR(9) NOT NULL,
    direccionDoc VARCHAR(100) NOT NULL,
    estadoDoc BIT NOT NULL
);

----------------------------------------------------------

/* Control de Niveles y Grados Académicos */
CREATE TABLE NivelAcademico (
    idNivel INT IDENTITY(1,1) PRIMARY KEY,
    nombreNivel VARCHAR(40) NOT NULL,
    estadoNivel BIT NOT NULL
);

CREATE TABLE GradoAcademico (
    idGrado INT IDENTITY(1,1) PRIMARY KEY,
    nombreGrado VARCHAR(40) NOT NULL,
    idNivel INT NOT NULL,
    estadoGrado BIT NOT NULL,
    FOREIGN KEY (idNivel) REFERENCES NivelAcademico(idNivel)
);

----------------------------------------------------------

/* Control de Cursos */
CREATE TABLE Curso (
    idCurso INT IDENTITY(1,1) PRIMARY KEY,
    nombreCurso VARCHAR(30) NOT NULL,
    idDocente INT NOT NULL,
    idGrado INT NOT NULL,
    estadoCurso BIT NOT NULL,
    FOREIGN KEY (idDocente) REFERENCES Docente(idDocente),
    FOREIGN KEY (idGrado) REFERENCES GradoAcademico(idGrado)
);

----------------------------------------------------------
--------------			CORES			------------------
----------------------------------------------------------

/* Tipos de Documento */
CREATE TABLE TipoDocumento (
    idTipoDocumento INT IDENTITY(1,1) PRIMARY KEY,
    nombreDoc VARCHAR(40) NOT NULL
);

----------------------------------------------------------

/* Carpeta de Inscripción (Recepción de Documentos) */
CREATE TABLE CarpetaInscripcion (
    idCarpeta INT IDENTITY(1,1) PRIMARY KEY,
    idEstudiante INT NOT NULL,
    tipoRegistro VARCHAR(20) NOT NULL,       -- NUEVO o TRASLADO
    tipoColegioOrigen VARCHAR(20) NOT NULL,  -- NACIONAL o PRIVADO
    fechaCarIns DATE NOT NULL,
    estadoCarpeta BIT NOT NULL,
    FOREIGN KEY (idEstudiante) REFERENCES Estudiante(idEstudiante)
);

----------------------------------------------------------

/* Documentos dentro de la Carpeta */
CREATE TABLE Documento (
    idDocumento INT IDENTITY(1,1) PRIMARY KEY,
    idCarpeta INT NOT NULL,
    idTipoDocumento INT NOT NULL,
    estadoDocumento BIT NOT NULL,
    FOREIGN KEY (idCarpeta) REFERENCES CarpetaInscripcion(idCarpeta),
    FOREIGN KEY (idTipoDocumento) REFERENCES TipoDocumento(idTipoDocumento)
);

----------------------------------------------------------

/* Boleta de Inscripción */
CREATE TABLE BoletaInscripcion (
    idBoletaIns INT IDENTITY(1,1) PRIMARY KEY,
    idCarpeta INT NOT NULL,
    fechaEmision DATE NOT NULL,
    estadoBoleta BIT NOT NULL,
    FOREIGN KEY (idCarpeta) REFERENCES CarpetaInscripcion(idCarpeta)
);

----------------------------------------------------------

/* Registro de Inscripción */
CREATE TABLE Inscripcion (
    idInscripcion INT IDENTITY(1,1) PRIMARY KEY,
    idBoletaIns INT NOT NULL,
    idEstudiante INT NOT NULL,
    fechaIns DATE NOT NULL,
    estadoIns BIT NOT NULL,
    FOREIGN KEY (idBoletaIns) REFERENCES BoletaInscripcion(idBoletaIns),
    FOREIGN KEY (idEstudiante) REFERENCES Estudiante(idEstudiante)
);

----------------------------------------------------------

/* Boleta de Matrícula (derivada de una Inscripción) */
CREATE TABLE BoletaMatricula (
    idBoletaMat INT IDENTITY(1,1) PRIMARY KEY,
    idInscripcion INT NOT NULL,
    fechaEmision DATE NOT NULL,
    estadoBoleta BIT NOT NULL,
    FOREIGN KEY (idInscripcion) REFERENCES Inscripcion(idInscripcion)
);

----------------------------------------------------------

/* Registro de Matrícula */
CREATE TABLE Matricula (
    idMatricula INT IDENTITY(1,1) PRIMARY KEY,
    idEstudiante INT NOT NULL,
    idGrado INT NOT NULL,
    idBoletaMat INT NOT NULL,
    fechaMat DATE NOT NULL,
    estadoMatricula BIT NOT NULL,
    FOREIGN KEY (idEstudiante) REFERENCES Estudiante(idEstudiante),
    FOREIGN KEY (idGrado) REFERENCES GradoAcademico(idGrado),
    FOREIGN KEY (idBoletaMat) REFERENCES BoletaMatricula(idBoletaMat)
);



----------------------------------------------------------

/* Tipo de Cargo (conceptos de pago) */
CREATE TABLE TipoCargo (
    idTipoCargo INT IDENTITY(1,1) PRIMARY KEY,
    nombreCargo VARCHAR(50) NOT NULL,
    estadoCargo BIT NOT NULL
);

----------------------------------------------------------

/* Planes de Pago (pueden ser por inscripción o matrícula) */
CREATE TABLE PlanPago (
    idPlanPago INT IDENTITY(1,1) PRIMARY KEY,
    idTipoCargo INT NOT NULL,
    idBoletaMat INT NULL,
    idBoletaIns INT NULL,
    montoTotal DECIMAL(10,2) NOT NULL,
    montoPendiente DECIMAL(10,2) NOT NULL,
    estadoPlan BIT NOT NULL,
    FOREIGN KEY (idTipoCargo) REFERENCES TipoCargo(idTipoCargo),
    FOREIGN KEY (idBoletaMat) REFERENCES BoletaMatricula(idBoletaMat),
    FOREIGN KEY (idBoletaIns) REFERENCES BoletaInscripcion(idBoletaIns)
);

----------------------------------------------------------

/* Registro de Pagos */
CREATE TABLE BoletaPago (
    idBoletaPago INT IDENTITY(1,1) PRIMARY KEY,
    idPlanPago INT NOT NULL,
    idTipoCargo INT NOT NULL,
    montoPagado DECIMAL(10,2) NOT NULL,
    modalidadPago VARCHAR(20),
    fechaPago DATE NOT NULL,
    FOREIGN KEY (idPlanPago) REFERENCES PlanPago(idPlanPago),
    FOREIGN KEY (idTipoCargo) REFERENCES TipoCargo(idTipoCargo)
);

----------------------------------------------------------

/* Control de Asistencia */
CREATE TABLE Asistencia (
    idAsistencia INT IDENTITY(1,1) PRIMARY KEY,
    idEstudiante INT NOT NULL,
    idCurso INT NOT NULL,
    fecha DATE NOT NULL,
    estadoAsistencia VARCHAR(20) NOT NULL, -- ASISTENCIA, FALTA, TARDANZA
    FOREIGN KEY (idEstudiante) REFERENCES Estudiante(idEstudiante),
    FOREIGN KEY (idCurso) REFERENCES Curso(idCurso)
);

----------------------------------------------------------

/* Administración de Notas */
CREATE TABLE Nota (
    idNota INT IDENTITY(1,1) PRIMARY KEY,
    idEstudiante INT NOT NULL,
    idCurso INT NOT NULL,
    tipoEvaluacion VARCHAR(30),
    notaNum DECIMAL(4,2) NOT NULL,
    notaLetra CHAR(2),
    estadoNota BIT NOT NULL,
    FOREIGN KEY (idEstudiante) REFERENCES Estudiante(idEstudiante),
    FOREIGN KEY (idCurso) REFERENCES Curso(idCurso)
);

----------------------------------------------------------
--------------        INSERTS DE EJEMPLO       ------------
----------------------------------------------------------

-- Apoderado
sp_help Apoderado
INSERT INTO Apoderado (dniApo, nombreApo, apellidosApo, numCelularApo, direccionApo, estadoApot)
VALUES 
('78945612', 'Rodrigo', 'Huaman', '987654321', 'Av. Los Olivos 123', 1),
('85296374', 'María', 'Lopez', '988776655', 'Av. San Martín 555', 1);
SELECT * FROM Apoderado;


-- Estudiante
sp_help Estudiante
INSERT INTO Estudiante (dniEst, nombreEst, apellidosEst, fechaNacEst, direccionEst, idApoderado, estadoEst)
VALUES 
('89456123', 'Kadin', 'Valera', '2005-09-16', 'Av. Siempre Viva 742', 1, 1),
('99456123', 'Antonio', 'Zavaleta', '2006-09-16', 'Av. Los Cedros 321', 1, 1),
('77456123', 'Lucía', 'Huaman', '2007-08-10', 'Av. Lima 150', 2, 1);
SELECT * FROM Estudiante;


-- Docente
sp_help Docente
INSERT INTO Docente (dniDoc, nombreDoc, apellidosDoc, numCelularDoc, direccionDoc, estadoDoc)
VALUES 
('12345678', 'Jorge', 'Zavaleta', '999888777', 'Av. Lima 100', 1),
('87654321', 'Carla', 'Pérez', '987999333', 'Av. Grau 200', 1);
SELECT * FROM Docente;


-- Nivel Académico
sp_help NivelAcademico
INSERT INTO NivelAcademico (nombreNivel, estadoNivel)
VALUES 
('Primaria', 1),
('Secundaria', 1);
SELECT * FROM NivelAcademico;


-- Grado Académico
sp_help GradoAcademico
INSERT INTO GradoAcademico (nombreGrado, idNivel, estadoGrado)
VALUES 
('Primero', 1, 1),
('Segundo', 1, 1),
('Primero', 2, 1);
SELECT * FROM GradoAcademico;


-- Curso
sp_help Curso
INSERT INTO Curso (nombreCurso, idDocente, idGrado, estadoCurso)
VALUES 
('Matemática', 1, 1, 1),
('Comunicación', 2, 1, 1),
('Álgebra', 1, 3, 1);
SELECT * FROM Curso;


-- TipoDocumento
sp_help TipoDocumento
INSERT INTO TipoDocumento (nombreDoc)
VALUES 
('DNI'),
('Partida de Nacimiento'),
('Certificado de Estudios'),
('Foto tamaño carnet');
SELECT * FROM TipoDocumento;


-- CarpetaInscripcion
sp_help CarpetaInscripcion
INSERT INTO CarpetaInscripcion (idEstudiante, tipoRegistro, tipoColegioOrigen, fechaCarIns, estadoCarpeta)
VALUES 
(1, 'Nuevo', 'Nacional', '2025-10-26', 1),
(2, 'Traslado', 'Privado', '2025-10-26', 1);
SELECT * FROM CarpetaInscripcion;


-- Documento
sp_help Documento
INSERT INTO Documento (idCarpeta, idTipoDocumento, estadoDocumento)
VALUES 
(1, 1, 1),
(1, 2, 1),
(1, 3, 1),
(2, 1, 1),
(2, 2, 0);
SELECT * FROM Documento;


-- BoletaInscripcion
sp_help BoletaInscripcion
INSERT INTO BoletaInscripcion (idCarpeta, fechaEmision, estadoBoleta)
VALUES 
(1, '2025-10-26', 1),
(2, '2025-10-26', 1);
SELECT * FROM BoletaInscripcion;


-- Inscripcion
sp_help Inscripcion
INSERT INTO Inscripcion (idBoletaIns, idEstudiante, fechaIns, estadoIns)
VALUES 
(1, 1, '2025-10-26', 1),
(2, 2, '2025-10-26', 1);
SELECT * FROM Inscripcion;


-- BoletaMatricula
sp_help BoletaMatricula
INSERT INTO BoletaMatricula (idInscripcion, fechaEmision, estadoBoleta)
VALUES 
(1, '2025-10-26', 1),
(2, '2025-10-26', 1);
SELECT * FROM BoletaMatricula;


-- Matricula
sp_help Matricula
INSERT INTO Matricula (idEstudiante, idGrado, idBoletaMat, fechaMat, estadoMatricula)
VALUES 
(1, 1, 1, '2025-10-26', 1),
(2, 3, 2, '2025-10-26', 1);
SELECT * FROM Matricula;


-- TipoCargo
sp_help TipoCargo
INSERT INTO TipoCargo (nombreCargo, estadoCargo)
VALUES 
('Inscripción', 1),
('Matrícula', 1),
('Pensión Mensual', 1);
SELECT * FROM TipoCargo;


-- PlanPago
sp_help PlanPago
INSERT INTO PlanPago (idTipoCargo, idBoletaMat, idBoletaIns, montoTotal, montoPendiente, estadoPlan)
VALUES 
(1, NULL, 1, 150.00, 0.00, 1),
(2, 1, NULL, 200.00, 50.00, 1);
SELECT * FROM PlanPago;


-- BoletaPago
sp_help BoletaPago
INSERT INTO BoletaPago (idPlanPago, idTipoCargo, montoPagado, modalidadPago, fechaPago)
VALUES 
(1, 1, 150.00, 'Efectivo', '2025-10-26'),
(2, 2, 150.00, 'Transferencia', '2025-10-26');
SELECT * FROM BoletaPago;


-- Asistencia
sp_help Asistencia
INSERT INTO Asistencia (idEstudiante, idCurso, fecha, estadoAsistencia)
VALUES 
(1, 1, '2025-10-25', 'Asistencia'),
(2, 3, '2025-10-25', 'Falta');
SELECT * FROM Asistencia;


-- Nota
sp_help Nota
INSERT INTO Nota (idEstudiante, idCurso, tipoEvaluacion, notaNum, notaLetra, estadoNota)
VALUES 
(1, 1, 'Examen Parcial', 17.50, 'A', 1),
(2, 3, 'Examen Final', 13.00, 'C', 1);
SELECT * FROM Nota;


----------------------------------------------------------
--------------       CONSULTAS			      ------------
----------------------------------------------------------

/* Verificar Documentos por Carpeta */
SELECT 
    c.idCarpeta, 
    e.nombreEst, 
    e.apellidosEst, 
    td.nombreDoc AS Documento, 
    d.estadoDocumento
FROM CarpetaInscripcion c
INNER JOIN Estudiante e ON c.idEstudiante = e.idEstudiante
INNER JOIN Documento d ON c.idCarpeta = d.idCarpeta
INNER JOIN TipoDocumento td ON d.idTipoDocumento = td.idTipoDocumento
ORDER BY c.idCarpeta;

/* Revisar Boletas de Inscripción */
SELECT 
    b.idBoletaIns, 
    e.nombreEst, 
    e.apellidosEst, 
    b.fechaEmision, 
    b.estadoBoleta
FROM BoletaInscripcion b
INNER JOIN CarpetaInscripcion c ON b.idCarpeta = c.idCarpeta
INNER JOIN Estudiante e ON c.idEstudiante = e.idEstudiante;

/* Verificar Inscripciones formales */
SELECT 
    i.idInscripcion, 
    e.nombreEst, 
    e.apellidosEst, 
    i.fechaIns, 
    i.estadoIns
FROM Inscripcion i
INNER JOIN Estudiante e ON i.idEstudiante = e.idEstudiante;

/* Consultar Matrículas por Grado */
SELECT 
    m.idMatricula, 
    e.nombreEst, 
    e.apellidosEst, 
    g.nombreGrado, 
    na.nombreNivel, 
    m.fechaMat
FROM Matricula m
INNER JOIN Estudiante e ON m.idEstudiante = e.idEstudiante
INNER JOIN GradoAcademico g ON m.idGrado = g.idGrado
INNER JOIN NivelAcademico na ON g.idNivel = na.idNivel;

/* Revisar Planes de Pago */
SELECT 
    p.idPlanPago, 
    tc.nombreCargo, 
    p.montoTotal, 
    p.montoPendiente, 
    p.estadoPlan
FROM PlanPago p
INNER JOIN TipoCargo tc ON p.idTipoCargo = tc.idTipoCargo;

/* Consultar Boletas de Pago con tipo de cargo */
SELECT 
    bp.idBoletaPago, 
    tc.nombreCargo, 
    bp.montoPagado, 
    bp.modalidadPago, 
    bp.fechaPago
FROM BoletaPago bp
INNER JOIN TipoCargo tc ON bp.idTipoCargo = tc.idTipoCargo;

/* Asistencia detallada */
SELECT 
    a.idAsistencia, 
    e.nombreEst, 
    e.apellidosEst, 
    c.nombreCurso, 
    a.fecha, 
    a.estadoAsistencia
FROM Asistencia a
INNER JOIN Estudiante e ON a.idEstudiante = e.idEstudiante
INNER JOIN Curso c ON a.idCurso = c.idCurso;

/* Notas de los estudiantes */
SELECT 
    n.idNota, 
    e.nombreEst, 
    e.apellidosEst, 
    c.nombreCurso, 
    n.tipoEvaluacion, 
    n.notaNum, 
    n.notaLetra
FROM Nota n
INNER JOIN Estudiante e ON n.idEstudiante = e.idEstudiante
INNER JOIN Curso c ON n.idCurso = c.idCurso;


