-----TRIGGER--
create or replace function tr_tramite()
returns trigger as $tr_tramite$
declare
cantidadt int;
ncantidad int;
begin
select count (*) into cantidadt  from tramite where id_empleado=new.id_empleado;
		 select id_empleado into ncantidad from empleado ;  
if(cantidadt > 3) then
   raise exception SQLSTATE 'E0002' using
        message = 'Este empleado a realizado mas de 3 tramites por dia..';
	return false;
end if;
return new;
end;
$tr_tramite$ language plpgsql;
create trigger tr_tramite
before insert or update on empleado
for each row
execute procedure tr_tramite();

INSERT INTO EMPLEADO (ID_EMPLEADO, ID_CEMENTERIO, NOMBRESE, APELLIDOSE, CEDULAE, CORREOE, FECHANAE, DIRECCIONE, TIPOCARGOE, GENEROE)
VALUES ('1', '1', 'KARLA MELISSA', 'ONTANEDA ROSALES', '1316369170','KARLITA@GMAIL.COM', '15/08/2000', 'BARIO CUBA', 'LIMPIEZA', 'FEMENINO');

