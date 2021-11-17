--El histórico de certificaciones 
select NOMBRESC,APELLIDOSC,TIPOTRAMITE,FECHAT,HORAT,CANTIDADT,VALORT 
from TRAMITE inner join CLIENTE 
on TRAMITE.ID_EMPLEADO= CLIENTE.ID_CLIENTE
where TRAMITE.TIPOTRAMITE='CERTIFICACION'
group by NOMBRESC,APELLIDOSC,TIPOTRAMITE,FECHAT,HORAT,CANTIDADT,VALORT;


--Histórico de pago 

select  TIPOTRAMITE,CANTIDADP,FECHAP,HORAP from PAGO,TRAMITE
Group by CANTIDADP,FECHAP,HORAP,TIPOTRAMITE
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
