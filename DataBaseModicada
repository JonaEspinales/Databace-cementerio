/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     23/1/2022 18:50:46                           */
/*==============================================================*/


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
            from  sysindexes
           where  id    = object_id('PROPIETARIO')
            and   name  = 'RELATIONSHIP_17_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROPIETARIO.RELATIONSHIP_17_FK
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
           where  id    = object_id('TIPOCONSTRUCCION')
            and   name  = 'RELATIONSHIP_16_FK'
            and   indid > 0
            and   indid < 255)
   drop index TIPOCONSTRUCCION.RELATIONSHIP_16_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIPOCONSTRUCCION')
            and   name  = 'RELATIONSHIP_15_FK'
            and   indid > 0
            and   indid < 255)
   drop index TIPOCONSTRUCCION.RELATIONSHIP_15_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOCONSTRUCCION')
            and   type = 'U')
   drop table TIPOCONSTRUCCION
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

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRANSFERIRR')
            and   name  = 'RELATIONSHIP_19_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRANSFERIRR.RELATIONSHIP_19_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRANSFERIRR')
            and   name  = 'RELATIONSHIP_18_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRANSFERIRR.RELATIONSHIP_18_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRANSFERIRR')
            and   type = 'U')
   drop table TRANSFERIRR
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

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   ID_CLIENTE           int                  not null,
   NOMBRE               varchar(50)          not null,
   APELLIDOS            varchar(80)          not null,
   CEDULA               varchar(10)          not null,
   CORREO               varchar(30)          not null,
   DIRECCION            varchar(30)          not null,
   GENERO               varchar(20)          not null,
   FECHA_NACIMIENTO     datetime             not null,
   constraint PK_CLIENTE primary key nonclustered (ID_CLIENTE)
)
go

/*==============================================================*/
/* Table: EMPLEADO                                              */
/*==============================================================*/
create table EMPLEADO (
   ID_EMPLEADO          int                  not null,
   ID_CEMENTERIO        int                  null,
   NOMBRE               varchar(50)          not null,
   APELLIDOS            varchar(80)          not null,
   CEDULA               varchar(10)          not null,
   CORREO               varchar(30)          not null,
   FECHA_NACIMIENTO     datetime             not null,
   DIRECCCION           varchar(30)          not null,
   TIPO_CARGO           varchar(30)          not null,
   GENERO               varchar(20)          not null,
   constraint PK_EMPLEADO primary key nonclustered (ID_EMPLEADO)
)
go

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
   IDFALLECIDO          int                  not null,
   NOMBRE               varchar(20)          not null,
   APELLIDO             varchar(20)          not null,
   FECHA                datetime             not null,
   CAUSAF               varchar(25)          not null,
   FALLECIDOESPERANDO   numeric(10,2)        null,
   constraint PK_FALLECIDO primary key nonclustered (IDFALLECIDO)
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
   HORAIN               datetime             not null,
   FECHAIN              datetime             not null,
   LUGARIN              varchar(25)          not null,
   NUMEROIN             varchar(10)          not null,
   ANIO                 varchar(10)          not null,
   constraint PK_INCIDENTE primary key nonclustered (ID_INCIDENTE)
)
go

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
   IDPAGO               int                  not null,
   VALORP               numeric(10,2)        not null,
   constraint PK_PAGO primary key nonclustered (IDPAGO)
)
go

/*==============================================================*/
/* Table: PANTEON                                               */
/*==============================================================*/
create table PANTEON (
   IDPANTEON            int                  not null,
   IDFALLECIDO          int                  null,
   ID_MANZANA           int                  null,
   IDSERVICIO           int                  null,
   CAPACIDADP           varchar(10)          not null,
   NOMBREP              varchar(25)          not null,
   PERSONAEN            numeric(10,2)        null,
   constraint PK_PANTEON primary key nonclustered (IDPANTEON)
)
go

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
IDSERVICIO ASC
)
go

/*==============================================================*/
/* Table: PROPIETARIO                                           */
/*==============================================================*/
create table PROPIETARIO (
   ID_PROPIETARIO       int                  not null,
   IDFALLECIDO          int                  null,
   NOMBRESP             varchar(30)          not null,
   APELLIDOSP           varchar(30)          not null,
   DIRECCIONP           varchar(30)          not null,
   CEDULAP              varchar(10)          not null,
   TELEFONOP            varchar(10)          not null,
   CORREOP              varchar(30)          not null,
   constraint PK_PROPIETARIO primary key nonclustered (ID_PROPIETARIO)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_17_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_17_FK on PROPIETARIO (
IDFALLECIDO ASC
)
go

/*==============================================================*/
/* Table: SERVICIO                                              */
/*==============================================================*/
create table SERVICIO (
   IDSERVICIO           int                  not null,
   ID_CLIENTE           int                  null,
   ID_EMPLEADO          int                  null,
   TIPOSERVICIO         varchar(30)          not null,
   VALORSERVICIO        numeric(10,2)        null,
   constraint PK_SERVICIO primary key nonclustered (IDSERVICIO)
)
go

/*==============================================================*/
/* Index: TRAMITE_SERVICIO_FK                                   */
/*==============================================================*/
create index TRAMITE_SERVICIO_FK on SERVICIO (
ID_CLIENTE ASC,
ID_EMPLEADO ASC
)
go

/*==============================================================*/
/* Table: TIPOCONSTRUCCION                                      */
/*==============================================================*/
create table TIPOCONSTRUCCION (
   IDFALLECIDO          int                  null,
   IDPANTEON            int                  null,
   CANTIDADTRANSLADADOS numeric(10,2)        null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_15_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_15_FK on TIPOCONSTRUCCION (
IDFALLECIDO ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_16_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_16_FK on TIPOCONSTRUCCION (
IDPANTEON ASC
)
go

/*==============================================================*/
/* Table: TRAMITE                                               */
/*==============================================================*/
create table TRAMITE (
   ID_CLIENTE           int                  not null,
   ID_EMPLEADO          int                  not null,
   ID_AUTORIDAD         int                  null,
   TIPOTRAMITE          varchar(30)          not null,
   FECHAT               datetime             not null,
   HORAT                datetime             not null,
   DESCRIPCIONT         varchar(30)          not null,
   CANTIDADT            varchar(15)          not null,
   VALORT               money                not null,
   constraint PK_TRAMITE primary key nonclustered (ID_CLIENTE, ID_EMPLEADO)
)
go

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
/* Index: TRAMITE_AUTORIDAD_FK                                  */
/*==============================================================*/
create index TRAMITE_AUTORIDAD_FK on TRAMITE (
ID_AUTORIDAD ASC
)
go

/*==============================================================*/
/* Table: TRANSFERIRR                                           */
/*==============================================================*/
create table TRANSFERIRR (
   IDPAGO               int                  null,
   IDSERVICIO           int                  null,
   IMPORTE              numeric(10,2)        null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_18_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_18_FK on TRANSFERIRR (
IDPAGO ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_19_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_19_FK on TRANSFERIRR (
IDSERVICIO ASC
)
go

