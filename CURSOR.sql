-----CURSOR-----
do $$
declare
 ndatos Record;
 valort int =0;
 c_ncursor cursor for select * from tramite,cliente where 
tramite.id_empleado = cliente.id_cliente 
order by valort;	
begin
for ndatos in  c_ncursor loop
fetch  c_ncursor into ndatos;
valort= valort  + count (ndatos.id_empleado);
raise notice 'tipotramite: % , FECHA_TRAMITE: % ,CANTIDAD_TRAMITE: % , TOTAL: % ', ndatos.tipotramite,
ndatos.fechat,ndatos.cantidadt,ndatos.valort;
end loop;
end $$
language 'plpgsql';

