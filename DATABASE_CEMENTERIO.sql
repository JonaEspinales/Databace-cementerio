/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     15/11/2021 11:18:56                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONSTRUCCIONP') and o.name = 'FK_CONSTRUC_PANTEON_C_PANTEON')
alter table CONSTRUCCIONP
   drop constraint FK_CONSTRUC_PANTEON_C_PANTEON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLEADO') and o.name = 'FK_EMPLEADO_CEMENTERI_CEMENTER')
alter table EMPLEADO
   drop constraint FK_EMPLEADO_CEMENTERI_CEMENTER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FALLECIDO') and o.name = 'FK_FALLECID_PANTEON_F_PANTEON')
alter table FALLECIDO
   drop constraint FK_FALLECID_PANTEON_F_PANTEON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INCIDENTE') and o.name = 'FK_INCIDENT_CEMENTERI_CEMENTER')
alter table INCIDENTE
   drop constraint FK_INCIDENT_CEMENTERI_CEMENTER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INCIDENTE') and o.name = 'FK_INCIDENT_INCIDENTE_MANZANA')
alter table INCIDENTE
   drop constraint FK_INCIDENT_INCIDENTE_MANZANA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INCIDENTE') and o.name = 'FK_INCIDENT_INCIDENTE_PROPIETA')
alter table INCIDENTE
   drop constraint FK_INCIDENT_INCIDENTE_PROPIETA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MANZANA') and o.name = 'FK_MANZANA_CEMENTERI_CEMENTER')
alter table MANZANA
   drop constraint FK_MANZANA_CEMENTERI_CEMENTER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PANTEON') and o.name = 'FK_PANTEON_MANZANA_P_MANZANA')
alter table PANTEON
   drop constraint FK_PANTEON_MANZANA_P_MANZANA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PANTEON') and o.name = 'FK_PANTEON_SERVICIO__SERVICIO')
alter table PANTEON
   drop constraint FK_PANTEON_SERVICIO__SERVICIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SERVICIO') and o.name = 'FK_SERVICIO_TRAMITE_S_TRAMITE')
alter table SERVICIO
   drop constraint FK_SERVICIO_TRAMITE_S_TRAMITE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRAMITE') and o.name = 'FK_TRAMITE_PAGO_TRAM_PAGO')
alter table TRAMITE
   drop constraint FK_TRAMITE_PAGO_TRAM_PAGO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRAMITE') and o.name = 'FK_TRAMITE_TRAMITE_CLIENTE')
alter table TRAMITE
   drop constraint FK_TRAMITE_TRAMITE_CLIENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRAMITE') and o.name = 'FK_TRAMITE_TRAMITE2_EMPLEADO')
alter table TRAMITE
   drop constraint FK_TRAMITE_TRAMITE2_EMPLEADO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRAMITE') and o.name = 'FK_TRAMITE_TRAMITE_A_AUTORIDA')
alter table TRAMITE
   drop constraint FK_TRAMITE_TRAMITE_A_AUTORIDA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AUTORIDAD')
            and   type = 'U')
   drop table AUTORIDAD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CEMENTERIO')
            and   type = 'U')
   drop table CEMENTERIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTE')
            and   type = 'U')
   drop table CLIENTE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONSTRUCCIONP')
            and   name  = 'PANTEON_CONSTRUCCIONP_FK'
            and   indid > 0
            and   indid < 255)
   drop index CONSTRUCCIONP.PANTEON_CONSTRUCCIONP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONSTRUCCIONP')
            and   type = 'U')
   drop table CONSTRUCCIONP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLEADO')
            and   name  = 'CEMENTERIO_EMPLEADO_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLEADO.CEMENTERIO_EMPLEADO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLEADO')
            and   type = 'U')
   drop table EMPLEADO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FALLECIDO')
            and   name  = 'PANTEON_FALLECIDO_FK'
            and   indid > 0
            and   indid < 255)
   drop index FALLECIDO.PANTEON_FALLECIDO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FALLECIDO')
            and   type = 'U')
   drop table FALLECIDO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INCIDENTE')
            and   name  = 'INCIDENTE_PROPIETARIO_FK'
            and   indid > 0
            and   indid < 255)
   drop index INCIDENTE.INCIDENTE_PROPIETARIO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INCIDENTE')
            and   name  = 'INCIDENTE_MANZANA_FK'
            and   indid > 0
            and   indid < 255)
   drop index INCIDENTE.INCIDENTE_MANZANA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INCIDENTE')
            and   name  = 'CEMENTERIO_INCIDENTE_FK'
            and   indid > 0
            and   indid < 255)
   drop index INCIDENTE.CEMENTERIO_INCIDENTE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INCIDENTE')
            and   type = 'U')
   drop table INCIDENTE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MANZANA')
            and   name  = 'CEMENTERIO_MANZANA_FK'
            and   indid > 0
            and   indid < 255)
   drop index MANZANA.CEMENTERIO_MANZANA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MANZANA')
            and   type = 'U')
   drop table MANZANA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PAGO')
            and   type = 'U')
   drop table PAGO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PANTEON')
            and   name  = 'SERVICIO_PANTEON_FK'
            and   indid > 0
            and   indid < 255)
   drop index PANTEON.SERVICIO_PANTEON_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PANTEON')
            and   name  = 'MANZANA_PANTEON_FK'
            and   indid > 0
            and   indid < 255)
   drop index PANTEON.MANZANA_PANTEON_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PANTEON')
            and   type = 'U')
   drop table PANTEON
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROPIETARIO')
            and   type = 'U')
   drop table PROPIETARIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SERVICIO')
            and   name  = 'TRAMITE_SERVICIO_FK'
            and   indid > 0
            and   indid < 255)
   drop index SERVICIO.TRAMITE_SERVICIO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SERVICIO')
            and   type = 'U')
   drop table SERVICIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRAMITE')
            and   name  = 'TRAMITE_AUTORIDAD_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRAMITE.TRAMITE_AUTORIDAD_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRAMITE')
            and   name  = 'PAGO_TRAMITE_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRAMITE.PAGO_TRAMITE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRAMITE')
            and   name  = 'TRAMITE_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRAMITE.TRAMITE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRAMITE')
            and   name  = 'TRAMITE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRAMITE.TRAMITE2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRAMITE')
            and   type = 'U')
   drop table TRAMITE
go

/*==============================================================*/
/* Table: AUTORIDAD                                             */
/*==============================================================*/
create table AUTORIDAD (
   ID_AUTORIDAD         int                  not null,
   CARGOA               varchar(20)          null,
   constraint PK_AUTORIDAD primary key nonclustered (ID_AUTORIDAD)
)
go


INSERT INTO AUTORIDAD (ID_AUTORIDAD, CARGOA)
VALUES ('2', 'POLICIAS');
INSERT INTO AUTORIDAD (ID_AUTORIDAD, CARGOA)
VALUES ('4', 'GOBERNADOR');



/*==============================================================*/
/* Table: CEMENTERIO                                            */
/*==============================================================*/
create table CEMENTERIO (
   ID_CEMENTERIO        int                  not null,
   NOMBRECEME           varchar(25)          not null,
   DIRECCIONCEME        varchar(25)          not null,
   constraint PK_CEMENTERIO primary key nonclustered (ID_CEMENTERIO)
)
go

INSERT INTO CEMENTERIO (ID_CEMENTERIO, NOMBRECEME, DIRECCIONCEME)
VALUES ('1', 'CIELITO LINDO', 'MANTA');


/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   ID_CLIENTE           int                  not null,
   NOMBRESC             varchar(35)          not null,
   APELLIDOSC           varchar(35)          not null,
   CEDULAC              varchar(10)          not null,
   CORREOC              varchar(25)          not null,
   DIRECCIONC           varchar(25)          not null,
   GENEROC              varchar(10)          not null,
   TELEFONOC            varchar(10)          not null,
   FECHANACI            date             not null,
   constraint PK_CLIENTE primary key nonclustered (ID_CLIENTE)
)
go

INSERT INTO CLIENTE(ID_CLIENTE, NOMBRESC, APELLIDOSC, CEDULAC, CORREOC, DIRECCIONC, GENEROC, TELEFONOC, FECHANACI)
VALUES ('1', 'LUIS ANTONIO', 'FRANCO LUCAS', '1234567895', 'LUCASF@GMAIL.COM', 'MANTA-TARQUI', 'MASCULINO', '0952525248', '28/05/1998');
INSERT INTO CLIENTE(ID_CLIENTE, NOMBRESC, APELLIDOSC, CEDULAC, CORREOC, DIRECCIONC, GENEROC, TELEFONOC, FECHANACI)
VALUES ('2', 'JESSICA ALEXANDRA', 'PONCE SANCHEZ', '1324569873', 'JESIICAFRESA@GMAIL.COM', 'LA PROAÑO', 'FEMENINO', '0978963215', '07/01/1997');
INSERT INTO CLIENTE(ID_CLIENTE, NOMBRESC, APELLIDOSC, CEDULAC, CORREOC, DIRECCIONC, GENEROC, TELEFONOC, FECHANACI)
VALUES ('3', 'MARIA MAGDALENA', 'NAVARRETE PLAZA', '0512365983', 'PLAZAN@GMAIL.COM', 'MANTA-TARQUI', 'FEMENINO', '0952525255', '15/12/1975');
INSERT INTO CLIENTE(ID_CLIENTE, NOMBRESC, APELLIDOSC, CEDULAC, CORREOC, DIRECCIONC, GENEROC, TELEFONOC, FECHANACI)
VALUES ('4', 'ANGIE MICHELLE', 'MACIAS MOREIRA', '0278963697', 'SHELMI15@GMAIL.COM', 'MANTA-CUBA', 'FEMENINO', '0997976885', '08/11/2000');
INSERT INTO CLIENTE(ID_CLIENTE, NOMBRESC, APELLIDOSC, CEDULAC, CORREOC, DIRECCIONC, GENEROC, TELEFONOC, FECHANACI)
VALUES ('5', 'DARIO FABRICIO', 'ARTEAGA MURILLO', '1316578941', 'DARIO55@GMAIL.COM', 'PORTOVIEJO - EL LIMON', 'MASCULINO', '0952525225', '01/01/1990');

/*==============================================================*/
/* Table: CONSTRUCCIONP                                         */
/*==============================================================*/
create table CONSTRUCCIONP (
   ID_CONJUNTO          int                  not null,
   ID_PANTEON           int                  null,
   TIPOCONSTRUCCION     varchar(30)          not null,
   ALTURA               varchar(10)          not null,
   CAPACIDAD            varchar(10)          not null,
   NUMERO               varchar(10)          not null,
   UBICACION            varchar(25)          not null,
   constraint PK_CONSTRUCCIONP primary key nonclustered (ID_CONJUNTO)
)
go


INSERT INTO CONSTRUCCIONP(ID_CONJUNTO, ID_PANTEON, TIPOCONSTRUCCION, ALTURA, CAPACIDAD, NUMERO, UBICACION)
VALUES('1', '1', 'FOSA CUMUN', '3X2 METROS', '1', '250', 'MANZANA 5');
INSERT INTO CONSTRUCCIONP(ID_CONJUNTO, ID_PANTEON, TIPOCONSTRUCCION, ALTURA, CAPACIDAD, NUMERO, UBICACION)
VALUES('2', '2', 'FOSA CUMUN', '4X2 METROS', '1', '150', 'MANZANA 4');
INSERT INTO CONSTRUCCIONP(ID_CONJUNTO, ID_PANTEON, TIPOCONSTRUCCION, ALTURA, CAPACIDAD, NUMERO, UBICACION)
VALUES('3', '3', 'BOBEDAS', '3X5 METROS', '15', '90', 'MANZANA 1');
INSERT INTO CONSTRUCCIONP(ID_CONJUNTO, ID_PANTEON, TIPOCONSTRUCCION, ALTURA, CAPACIDAD, NUMERO, UBICACION)
VALUES('4', '4', 'BOBEDAS', '2X5 METROS', '10', '85', 'MANZANA 2');
INSERT INTO CONSTRUCCIONP(ID_CONJUNTO, ID_PANTEON, TIPOCONSTRUCCION, ALTURA, CAPACIDAD, NUMERO, UBICACION)
VALUES('5', '5', 'NICHOS', '1X2 METROS', '1', '120', 'MANZANA 3');

/*==============================================================*/
/* Index: PANTEON_CONSTRUCCIONP_FK                              */
/*==============================================================*/
create index PANTEON_CONSTRUCCIONP_FK on CONSTRUCCIONP (
ID_PANTEON ASC
)
go

/*==============================================================*/
/* Table: EMPLEADO                                              */
/*==============================================================*/
create table EMPLEADO (
   ID_EMPLEADO          int                  not null,
   ID_CEMENTERIO        int                  null,
   NOMBRESE             varchar(35)          not null,
   APELLIDOSE           varchar(35)          not null,
   CEDULAE              varchar(10)          not null,
   CORREOE              varchar(20)          not null,
   FECHANAE             date            not null,
   DIRECCIONE           varchar(25)          not null,
   TIPOCARGOE           varchar(25)          not null,
   GENEROE              varchar(15)          not null,
   constraint PK_EMPLEADO primary key nonclustered (ID_EMPLEADO)
)
go

INSERT INTO EMPLEADO (ID_EMPLEADO, ID_CEMENTERIO, NOMBRESE, APELLIDOSE, CEDULAE, CORREOE, FECHANAE, DIRECCIONE, TIPOCARGOE, GENEROE)
VALUES ('1', '1', 'KARLA MELISSA', 'ONTANEDA ROSALES', '1316369170','KARLITA@GMAIL.COM', '15/08/2000', 'BARIO CUBA', 'LIMPIEZA', 'FEMENINO');
INSERT INTO EMPLEADO (ID_EMPLEADO, ID_CEMENTERIO, NOMBRESE, APELLIDOSE, CEDULAE, CORREOE, FECHANAE, DIRECCIONE, TIPOCARGOE, GENEROE)
VALUES ('2', '1', 'MAHOLY MILENA', 'CARDONA ORDOÑES', '0512222365','MAHOLYO@GMAIL.COM', '25/12/2003', 'BARIO JIPIJAPA', 'LIMPIEZA', 'FEMENINO');
INSERT INTO EMPLEADO (ID_EMPLEADO, ID_CEMENTERIO, NOMBRESE, APELLIDOSE, CEDULAE, CORREOE, FECHANAE, DIRECCIONE, TIPOCARGOE, GENEROE)
VALUES ('3', '1', 'MIGUEL ANGEL', 'SANCHEZ ARTEAGA', '1316369171','MIGUELITO@GMAIL.COM', '03/07/2000', 'BARIO LA FLORITA', 'SUPERVISOR', 'MASCULINO');
INSERT INTO EMPLEADO (ID_EMPLEADO, ID_CEMENTERIO, NOMBRESE, APELLIDOSE, CEDULAE, CORREOE, FECHANAE, DIRECCIONE, TIPOCARGOE, GENEROE)
VALUES ('4', '1', 'JONATHAN JOEL', 'ESPINALES MENDOZA', '1316313457','MISHOL@GMAIL.COM', '13/09/1993', 'BARIO URBIRIOS', 'SECRETARIO', 'MASCULINO');
INSERT INTO EMPLEADO (ID_EMPLEADO, ID_CEMENTERIO, NOMBRESE, APELLIDOSE, CEDULAE, CORREOE, FECHANAE, DIRECCIONE, TIPOCARGOE, GENEROE)
VALUES ('5', '1', 'DAVID ENRIQUE', 'CHAVES GARLARZA', '1316378970','KIKE_80@GMAIL.COM', '06/11/1980', 'BARIO LA PAZ', 'CONTRUCTOR', 'MASCULINO');


/*==============================================================*/
/* Index: CEMENTERIO_EMPLEADO_FK                                */
/*==============================================================*/
create index CEMENTERIO_EMPLEADO_FK on EMPLEADO (
ID_CEMENTERIO ASC
)
go

/*==============================================================*/
/* Table: FALLECIDO                                             */
/*==============================================================*/
create table FALLECIDO (
   ID_FALLECIDO         int                  not null,
   ID_PANTEON           int                  null,
   NOMBRESF             varchar(20)          not null,
   APELLIDOSF           varchar(20)          not null,
   FECHAF               date             not null,
   HORAF                time             not null,
   CAUSAF               varchar(25)          not null,
   CANTIDADF            varchar(10)          not null,
   constraint PK_FALLECIDO primary key nonclustered (ID_FALLECIDO)
)
go

INSERT INTO FALLECIDO (ID_FALLECIDO, ID_PANTEON, NOMBRESF, APELLIDOSF, FECHAF, HORAF, CAUSAF, CANTIDADF)
VALUES('1', '1', 'FELIPE JESUS', 'SALAZAR PIGUAVE', '15/11/2021', '14:00', 'DERRAME', '5');
INSERT INTO FALLECIDO (ID_FALLECIDO, ID_PANTEON, NOMBRESF, APELLIDOSF, FECHAF, HORAF, CAUSAF, CANTIDADF)
VALUES('2', '2', 'LUZ CONSUELO', 'ROMO PALACIO', '23/05/2021', '23:00', 'MUERTE NATURAL', '10');
INSERT INTO FALLECIDO (ID_FALLECIDO, ID_PANTEON, NOMBRESF, APELLIDOSF, FECHAF, HORAF, CAUSAF, CANTIDADF)
VALUES('3', '3', 'MILENA MOKAELA', 'CARDONA OROZCO', '11/11/2021', '15:00', 'CANCER', '15');
INSERT INTO FALLECIDO (ID_FALLECIDO, ID_PANTEON, NOMBRESF, APELLIDOSF, FECHAF, HORAF, CAUSAF, CANTIDADF)
VALUES('4', '4', 'NELSON FABIAN', 'MERA ARAUJO', '02/03/2021', '17:00', 'PARO CARDIACO', '5');
INSERT INTO FALLECIDO (ID_FALLECIDO, ID_PANTEON, NOMBRESF, APELLIDOSF, FECHAF, HORAF, CAUSAF, CANTIDADF)
VALUES('5', '5', 'MARCOS ALEX', 'VELIZ VELIZ', '01/07/2021', '18:00', 'ASESINATO', '6');

/*==============================================================*/
/* Index: PANTEON_FALLECIDO_FK                                  */
/*==============================================================*/
create index PANTEON_FALLECIDO_FK on FALLECIDO (
ID_PANTEON ASC
)
go

/*==============================================================*/
/* Table: INCIDENTE                                             */
/*==============================================================*/
create table INCIDENTE (
   ID_INCIDENTE         int                  not null,
   ID_CEMENTERIO        int                  null,
   ID_MANZANA           int                  null,
   ID_PROPIETARIO       int                  null,
   TIPOINCIDENTE        varchar(25)          not null,
   HORAIN               time             not null,
   FECHAIN              date            not null,
   LUGARIN              varchar(30)          not null,
   NUMEROIN             numeric(6,2)          not null,
   ANIO                 varchar(10)          not null,
   constraint PK_INCIDENTE primary key nonclustered (ID_INCIDENTE)
)
go


/*-----------------DUDASSSSSSSSSSSS    LUGAR  -  AÑO */
INSERT INTO INCIDENTE (ID_INCIDENTE, ID_CEMENTERIO, ID_MANZANA, ID_PROPIETARIO, TIPOINCIDENTE, HORAIN, FECHAIN, LUGARIN, NUMEROIN, ANIO)
VALUES ('1', '1', '1', '1', 'ROBO DE HUESO', '14:00', '15/02/2021', 'MANZANA 2', '10', '2019');
INSERT INTO INCIDENTE (ID_INCIDENTE, ID_CEMENTERIO, ID_MANZANA, ID_PROPIETARIO, TIPOINCIDENTE, HORAIN, FECHAIN, LUGARIN, NUMEROIN, ANIO)
VALUES ('2', '1', '2', '2', 'INTRUSOS', '00:00', '16/10/2021', 'MANZANA 2', '8', '2020');
INSERT INTO INCIDENTE (ID_INCIDENTE, ID_CEMENTERIO, ID_MANZANA, ID_PROPIETARIO, TIPOINCIDENTE, HORAIN, FECHAIN, LUGARIN, NUMEROIN, ANIO)
VALUES ('3', '1', '3', '3', 'RODE DE NICHOS', '15:00', '04/08/2021', 'MANZANA 3', '5', '2018');
INSERT INTO INCIDENTE (ID_INCIDENTE, ID_CEMENTERIO, ID_MANZANA, ID_PROPIETARIO, TIPOINCIDENTE, HORAIN, FECHAIN, LUGARIN, NUMEROIN, ANIO)
VALUES ('4', '1', '4', '4', 'ROBO DE HUESO', '23:00', '26/07/2021', 'MANZANA 2', '2', '2021');
INSERT INTO INCIDENTE (ID_INCIDENTE, ID_CEMENTERIO, ID_MANZANA, ID_PROPIETARIO, TIPOINCIDENTE, HORAIN, FECHAIN, LUGARIN, NUMEROIN, ANIO)
VALUES ('5', '1', '5', '5', 'DESTRUCCION DE BOBEDAS', '10:00', '31/08/2021', 'MANZANA 5', '7', '2021');

/*==============================================================*/
/* Index: CEMENTERIO_INCIDENTE_FK                               */
/*==============================================================*/
create index CEMENTERIO_INCIDENTE_FK on INCIDENTE (
ID_CEMENTERIO ASC
)
go

/*==============================================================*/
/* Index: INCIDENTE_MANZANA_FK                                  */
/*==============================================================*/
create index INCIDENTE_MANZANA_FK on INCIDENTE (
ID_MANZANA ASC
)
go

/*==============================================================*/
/* Index: INCIDENTE_PROPIETARIO_FK                              */
/*==============================================================*/
create index INCIDENTE_PROPIETARIO_FK on INCIDENTE (
ID_PROPIETARIO ASC
)
go

/*==============================================================*/
/* Table: MANZANA                                               */
/*==============================================================*/
create table MANZANA (
   ID_MANZANA           int                  not null,
   ID_CEMENTERIO        int                  null,
   LUGARMA              varchar(30)          not null,
   DIRECCIONMA          varchar(30)          not null,
   UBICACIONMA          varchar(30)          not null,
   NUMEROMA             varchar(10)          not null,
   constraint PK_MANZANA primary key nonclustered (ID_MANZANA)
)
go

/*------------------INCOMPLETO*/
INSERT INTO MANZANA (ID_MANZANA, ID_CEMENTERIO, LUGARMA, DIRECCIONMA,UBICACIONMA, NUMEROMA)
VALUES ('1', '1', 'Lugar1','Los 3 Hermanos', 'ubicacion1', '1');
INSERT INTO MANZANA (ID_MANZANA, ID_CEMENTERIO, LUGARMA, DIRECCIONMA,UBICACIONMA, NUMEROMA)
VALUES ('2', '1', 'Lugar2','5 judios', 'ubicaion2', '2');
INSERT INTO MANZANA (ID_MANZANA, ID_CEMENTERIO, LUGARMA, DIRECCIONMA,UBICACIONMA, NUMEROMA)
VALUES ('3', '1', 'Lugar3','8 maria', 'ubicacion3', '3');
INSERT INTO MANZANA (ID_MANZANA, ID_CEMENTERIO, LUGARMA, DIRECCIONMA,UBICACIONMA, NUMEROMA)
VALUES ('4', '1', 'Lugar4','los esteros', 'ubicaion4', '4');

/*==============================================================*/
/* Index: CEMENTERIO_MANZANA_FK                                 */
/*==============================================================*/
create index CEMENTERIO_MANZANA_FK on MANZANA (
ID_CEMENTERIO ASC
)
go

/*==============================================================*/
/* Table: PAGO                                                  */
/*==============================================================*/
create table PAGO (
   ID_PAGO              int                  not null,
   CANTIDADP            numeric(6,2)         not null,
   FECHAP               date       not null,
   HORAP                time             not null,
   constraint PK_PAGO primary key nonclustered (ID_PAGO)
)
go


INSERT INTO PAGO (ID_PAGO, CANTIDADP, FECHAP, HORAP)
VALUES ('1', '20', '16/08/2021', '20:00');
INSERT INTO PAGO (ID_PAGO, CANTIDADP, FECHAP, HORAP)
VALUES ('2', '15', '17/09/2021', '18:00');
INSERT INTO PAGO (ID_PAGO, CANTIDADP, FECHAP, HORAP)
VALUES ('3', '10', '18/10/2021', '17:00');
INSERT INTO PAGO (ID_PAGO, CANTIDADP, FECHAP, HORAP)
VALUES ('4', '5', '19/07/2021', '16:00');
INSERT INTO PAGO (ID_PAGO, CANTIDADP, FECHAP, HORAP)
VALUES ('5', '10', '20/11/2021', '15:00');

/*==============================================================*/
/* Table: PANTEON                                               */
/*==============================================================*/
create table PANTEON (
   ID_PANTEON           int                  not null,
   ID_MANZANA           int                  null,
   ID_SERVICIO          int                  null,
   CAPACIDADP           varchar(10)          not null,
   INSCRIPCIONP         varchar(30)          not null,
   NOMBREP              varchar(25)          not null,
   constraint PK_PANTEON primary key nonclustered (ID_PANTEON)
)
go


INSERT INTO PANTEON (ID_PANTEON, ID_MANZANA, ID_SERVICIO, CAPACIDADP, INSCRIPCIONP, NOMBREP)
VALUES ('1', '1', '1', '3', 'NORMAL', 'PANTEAN 1');
INSERT INTO PANTEON (ID_PANTEON, ID_MANZANA, ID_SERVICIO, CAPACIDADP, INSCRIPCIONP, NOMBREP)
VALUES ('2', '2', '2', '5', 'NORMAL', 'PANTEAN 2');
INSERT INTO PANTEON (ID_PANTEON, ID_MANZANA, ID_SERVICIO, CAPACIDADP, INSCRIPCIONP, NOMBREP)
VALUES ('3', '3', '3', '4', 'NORMAL', 'PANTEAN 3');
INSERT INTO PANTEON (ID_PANTEON, ID_MANZANA, ID_SERVICIO, CAPACIDADP, INSCRIPCIONP, NOMBREP)
VALUES ('4', '4', '4', '8', 'NORMAL', 'PANTEAN 4');
INSERT INTO PANTEON (ID_PANTEON, ID_MANZANA, ID_SERVICIO, CAPACIDADP, INSCRIPCIONP, NOMBREP)
VALUES ('5', '1', '5', '10', 'NORMAL', 'PANTEAN 5');

/*==============================================================*/
/* Index: MANZANA_PANTEON_FK                                    */
/*==============================================================*/
create index MANZANA_PANTEON_FK on PANTEON (
ID_MANZANA ASC
)
go

/*==============================================================*/
/* Index: SERVICIO_PANTEON_FK                                   */
/*==============================================================*/
create index SERVICIO_PANTEON_FK on PANTEON (
ID_SERVICIO ASC
)
go

/*==============================================================*/
/* Table: PROPIETARIO                                           */
/*==============================================================*/
create table PROPIETARIO (
   ID_PROPIETARIO       int                  not null,
   NOMBRESP             varchar(30)          not null,
   APELLIDOSP           varchar(30)          not null,
   DIRECCIONP           varchar(30)          not null,
   CEDULAP              varchar(10)          not null,
   TELEFONOP            varchar(10)          not null,
   CORREOP              varchar(30)          not null,
   constraint PK_PROPIETARIO primary key nonclustered (ID_PROPIETARIO)
)
go


INSERT INTO PROPIETARIO (ID_PROPIETARIO, NOMBRESP, APELLIDOSP, DIRECCIONP, CEDULAP, TELEFONOP, CORREOP)
VALUES('1', 'PABLO EMILIO', 'ESCOBAR GAVIRIA', 'BARRIO CUBA', '0996123645','0978632980', 'ELPATRON@GMAIL.COM');
INSERT INTO PROPIETARIO (ID_PROPIETARIO, NOMBRESP, APELLIDOSP, DIRECCIONP, CEDULAP, TELEFONOP, CORREOP)
VALUES('2', 'PEDRO PABLO', 'LEON JARAMILLO', '20 DE MAYO', '0996123650','0978632960', 'ELCAPO@GMAIL.COM');
INSERT INTO PROPIETARIO (ID_PROPIETARIO, NOMBRESP, APELLIDOSP, DIRECCIONP, CEDULAP, TELEFONOP, CORREOP)
VALUES('3', 'JOSE FERNANDO', 'COSCULLUELA GARCIA', '15 DE ABRIL', '0996123670','0978632990', 'COCULLUELA@GMAIL.COM');
INSERT INTO PROPIETARIO (ID_PROPIETARIO, NOMBRESP, APELLIDOSP, DIRECCIONP, CEDULAP, TELEFONOP, CORREOP)
VALUES('4', 'REYMON DAVIR', 'AYALA PINARGOTE', '7 PUÑALADA', '0996123610','0978632920', 'DADDYANKE@GMAIL.COM');
INSERT INTO PROPIETARIO (ID_PROPIETARIO, NOMBRESP, APELLIDOSP, DIRECCIONP, CEDULAP, TELEFONOP, CORREOP)
VALUES('5', 'KAROL EMILIA', 'GARCIA GARCIA', 'LOS QUIOSCO', '0996123630','0978632940', 'KAROLG@GMAIL.COM');


/*==============================================================*/
/* Table: SERVICIO                                              */
/*==============================================================*/
create table SERVICIO (
   ID_SERVICIO          int                  not null,
   ID_CLIENTE           int                  null,
   ID_EMPLEADO          int                  null,
   TIPOSERVICIO         varchar(30)          not null,
   HORASERVICIO         datetime             not null,
   FECHASERVICIO        datetime             not null,
   PRECIOSERVICIO       numeric(6,2)         not null,
   DESCRIPCION          varchar(20)          not null,
   constraint PK_SERVICIO primary key nonclustered (ID_SERVICIO)
)
go

INSERT INTO SERVICIO (ID_SERVICIO, ID_CLIENTE, ID_EMPLEADO, TIPOSERVICIO, HORASERVICIO, FECHASERVICIO, PRECIOSERVICIO, DESCRIPCION)
VALUES('1', '1', '1', 'EXHUMACIONES', '14:00', '15/07/2021', '450', 'SERVIO EXHUMACIONES');
INSERT INTO SERVICIO (ID_SERVICIO, ID_CLIENTE, ID_EMPLEADO, TIPOSERVICIO, HORASERVICIO, FECHASERVICIO, PRECIOSERVICIO, DESCRIPCION)
VALUES('2', '2', '2', 'INHUMACIONES', '15:00', '01/01/2021', '500', 'SERVIO INHUMACIONES');
INSERT INTO SERVICIO (ID_SERVICIO, ID_CLIENTE, ID_EMPLEADO, TIPOSERVICIO, HORASERVICIO, FECHASERVICIO, PRECIOSERVICIO, DESCRIPCION)
VALUES('3', '3', '3', 'MANTENIMIENTO', '8:00', '10/12/2021', '300', 'SERVIO MANTENIMIENTO');
INSERT INTO SERVICIO (ID_SERVICIO, ID_CLIENTE, ID_EMPLEADO, TIPOSERVICIO, HORASERVICIO, FECHASERVICIO, PRECIOSERVICIO, DESCRIPCION)
VALUES('4', '4', '4', 'CERTIFICACION', '11:00', '26/06/2021', '400', 'SERVIO CERTIFICACION');
INSERT INTO SERVICIO (ID_SERVICIO, ID_CLIENTE, ID_EMPLEADO, TIPOSERVICIO, HORASERVICIO, FECHASERVICIO, PRECIOSERVICIO, DESCRIPCION)
VALUES('5', '5', '5', 'CREMACION', '00:00', '25/05/2021', '800', 'SERVIO CREMACION');

/*==============================================================*/
/* Index: TRAMITE_SERVICIO_FK                                   */
/*==============================================================*/
create index TRAMITE_SERVICIO_FK on SERVICIO (
ID_CLIENTE ASC,
ID_EMPLEADO ASC
)
go

/*==============================================================*/
/* Table: TRAMITE                                               */
/*==============================================================*/
create table TRAMITE (
   ID_CLIENTE           int                  not null,
   ID_EMPLEADO          int                  not null,
   ID_PAGO              int                  null,
   ID_AUTORIDAD         int                  null,
   TIPOTRAMITE          varchar(30)          not null,
   FECHAT               datetime             not null,
   HORAT                datetime             not null,
   DESCRIPCIONT         varchar(40)          not null,
   CANTIDADT            varchar(15)          not null,
   VALORT               numeric(6,2)         not null,
   constraint PK_TRAMITE primary key nonclustered (ID_CLIENTE, ID_EMPLEADO)
)
go

INSERT INTO TRAMITE (ID_CLIENTE, ID_EMPLEADO, ID_PAGO, ID_AUTORIDAD, TIPOTRAMITE, FECHAT, HORAT, DESCRIPCIONT, CANTIDADT, VALORT)
VALUES ('1', '1', '1', '1', 'EXHUMACIONES', '24/09/2021' , '8:00','SE REALIZA TRAMITE DE EXHUMACIONES', '12', '500');
INSERT INTO TRAMITE (ID_CLIENTE, ID_EMPLEADO, ID_PAGO, ID_AUTORIDAD, TIPOTRAMITE, FECHAT, HORAT, DESCRIPCIONT, CANTIDADT, VALORT)
VALUES ('2', '2', '2', '2', 'INHUMACIONES', '12/10/2021', '10:00','SE REALIZA TRAMITE DE NHUMACIONES', '8', '500');
INSERT INTO TRAMITE (ID_CLIENTE, ID_EMPLEADO, ID_PAGO, ID_AUTORIDAD, TIPOTRAMITE, FECHAT, HORAT, DESCRIPCIONT, CANTIDADT, VALORT)
VALUES ('3', '3', '3', '3', 'COMPRA DE LOTE', '03/05/2021', '11:00','SE REALIZA COMPRA DE LOTE', '12', '500');
INSERT INTO TRAMITE (ID_CLIENTE, ID_EMPLEADO, ID_PAGO, ID_AUTORIDAD, TIPOTRAMITE, FECHAT, HORAT, DESCRIPCIONT, CANTIDADT, VALORT)
VALUES ('4', '4', '4', '4', 'COMPRA DE NICHO', '18/08/2021', '15:00','SE REALIZA COMPRA DE NICHO', '12', '500');
INSERT INTO TRAMITE (ID_CLIENTE, ID_EMPLEADO, ID_PAGO, ID_AUTORIDAD, TIPOTRAMITE, FECHAT, HORAT, DESCRIPCIONT, CANTIDADT, VALORT)
VALUES ('5', '5', '5', '5', 'CERTIFICACION', '16/09/2021', '12:00','SE REALIZA CERTIFICACION', '12', '500');

/*==============================================================*/
/* Index: TRAMITE2_FK                                           */
/*==============================================================*/
create index TRAMITE2_FK on TRAMITE (
ID_EMPLEADO ASC
)
go

/*==============================================================*/
/* Index: TRAMITE_FK                                            */
/*==============================================================*/
create index TRAMITE_FK on TRAMITE (
ID_CLIENTE ASC
)
go

/*==============================================================*/
/* Index: PAGO_TRAMITE_FK                                       */
/*==============================================================*/
create index PAGO_TRAMITE_FK on TRAMITE (
ID_PAGO ASC
)
go

/*==============================================================*/
/* Index: TRAMITE_AUTORIDAD_FK                                  */
/*==============================================================*/
create index TRAMITE_AUTORIDAD_FK on TRAMITE (
ID_AUTORIDAD ASC
)
go

alter table CONSTRUCCIONP
   add constraint FK_CONSTRUC_PANTEON_C_PANTEON foreign key (ID_PANTEON)
      references PANTEON (ID_PANTEON)
go

alter table EMPLEADO
   add constraint FK_EMPLEADO_CEMENTERI_CEMENTER foreign key (ID_CEMENTERIO)
      references CEMENTERIO (ID_CEMENTERIO)
go

alter table FALLECIDO
   add constraint FK_FALLECID_PANTEON_F_PANTEON foreign key (ID_PANTEON)
      references PANTEON (ID_PANTEON)
go

alter table INCIDENTE
   add constraint FK_INCIDENT_CEMENTERI_CEMENTER foreign key (ID_CEMENTERIO)
      references CEMENTERIO (ID_CEMENTERIO)
go

alter table INCIDENTE
   add constraint FK_INCIDENT_INCIDENTE_MANZANA foreign key (ID_MANZANA)
      references MANZANA (ID_MANZANA)
go

alter table INCIDENTE
   add constraint FK_INCIDENT_INCIDENTE_PROPIETA foreign key (ID_PROPIETARIO)
      references PROPIETARIO (ID_PROPIETARIO)
go

alter table MANZANA
   add constraint FK_MANZANA_CEMENTERI_CEMENTER foreign key (ID_CEMENTERIO)
      references CEMENTERIO (ID_CEMENTERIO)
go

alter table PANTEON
   add constraint FK_PANTEON_MANZANA_P_MANZANA foreign key (ID_MANZANA)
      references MANZANA (ID_MANZANA)
go

alter table PANTEON
   add constraint FK_PANTEON_SERVICIO__SERVICIO foreign key (ID_SERVICIO)
      references SERVICIO (ID_SERVICIO)
go

alter table SERVICIO
   add constraint FK_SERVICIO_TRAMITE_S_TRAMITE foreign key (ID_CLIENTE, ID_EMPLEADO)
      references TRAMITE (ID_CLIENTE, ID_EMPLEADO)
go

alter table TRAMITE
   add constraint FK_TRAMITE_PAGO_TRAM_PAGO foreign key (ID_PAGO)
      references PAGO (ID_PAGO)
go

alter table TRAMITE
   add constraint FK_TRAMITE_TRAMITE_CLIENTE foreign key (ID_CLIENTE)
      references CLIENTE (ID_CLIENTE)
go

alter table TRAMITE
   add constraint FK_TRAMITE_TRAMITE2_EMPLEADO foreign key (ID_EMPLEADO)
      references EMPLEADO (ID_EMPLEADO)
go

alter table TRAMITE
   add constraint FK_TRAMITE_TRAMITE_A_AUTORIDA foreign key (ID_AUTORIDAD)
      references AUTORIDAD (ID_AUTORIDAD)
go


select * from CEMENTERIO;
select * from TRAMITE;
select * from PAGO;

--El histórico de certificaciones 
select NOMBRESC,APELLIDOSC,TIPOTRAMITE,FECHAT,HORAT,CANTIDADT,VALORT 
from TRAMITE inner join CLIENTE 
on TRAMITE.ID_EMPLEADO= CLIENTE.ID_CLIENTE
where TRAMITE.TIPOTRAMITE='CERTIFICACION'
group by NOMBRESC,APELLIDOSC,TIPOTRAMITE,FECHAT,HORAT,CANTIDADT,VALORT;


--Histórico de pago 

select  CANTIDADP,FECHAP,HORAP from PAGO
Group by CANTIDADP,FECHAP,HORAP
order by CANTIDADP;


--La cantidad de tipo de estructura que tiene el cementerio 

select (TIPOCONSTRUCCION)as TIPO_ESTRUCTURA ,UBICACION,ALTURA from CONSTRUCCIONP
where CONSTRUCCIONP.TIPOCONSTRUCCION='BOBEDAS' OR CONSTRUCCIONP.TIPOCONSTRUCCION='NICHOS'
group by TIPOCONSTRUCCION,UBICACION,ALTURA
order by UBICACION;



--Que por cada año aparezca el total de incidente que haya habido

select * from INCIDENTE;

select (NUMEROIN)as TOTAL_INCIDENTE,TIPOINCIDENTE,ANIO,FECHAIN,LUGARIN from INCIDENTE
where INCIDENTE.ANIO='2021'
group by NUMEROIN,TIPOINCIDENTE,ANIO,FECHAIN,LUGARIN
order by TIPOINCIDENTE;
