use BD_B31359;

CREATE TABLE [dbo].[persona](
	[nombre] [varchar](20) NOT NULL,
	[apellido1] [varchar](20) NOT NULL,
	[apellido2] [varchar](20),
	[cedula] [varchar](10) NOT NULL,
	[correo] [varchar](10),
	[direccion] [varchar](40),
	
	CONSTRAINT pk_PersonID PRIMARY KEY (cedula)
 );

CREATE TABLE [dbo].[telefono](
	[telefono] [varchar](8) NOT NULL,
	[cedula] [varchar](10) NOT NULL,
	
	CONSTRAINT pk_telefono PRIMARY KEY CLUSTERED (cedula, telefono ASC),
	CONSTRAINT fk_cedula_telefono FOREIGN KEY  (cedula) REFERENCES persona(cedula)
 );

CREATE TABLE [dbo].[cuenta](
	[tipo] [varchar](8) NOT NULL,
	[cedula] [varchar](10) NOT NULL,
	[numero] [varchar](30) NOT NULL,

	CONSTRAINT pk_cuenta PRIMARY KEY CLUSTERED (cedula, numero ASC),
	CONSTRAINT fk_cedula_cuenta FOREIGN KEY (cedula) REFERENCES persona(cedula)
 );
