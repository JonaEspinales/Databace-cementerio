-----Procedimiento--
create or replace function causasmuerte(int)
returns  varchar as $$
	DECLARE 
		datoingre alias for $1; datos RECORD;
		cur_datos  cursor for SELECT 
			fallecido.causaf as Causa_Muerte,
			panteon.id_panteon as id,
			fallecido.fechaf as Anio_Muerte,
			fallecido.cantidadf as Cantidad_Fallecidos,
			panteon.nombrep as nombre
			FROM fallecido
		  	inner join panteon on fallecido.id_fallecido= panteon.id_panteon WHERE panteon.id_panteon=$1
			group by fallecido.causaf , panteon.id_panteon,fallecido.fechaf ,fallecido.cantidadf,panteon.nombrep;
begin
	OPEN cur_datos;
		FETCh cur_datos INTO datos;
		RAISE NOTICE 
			'
			NOMBRE PANTEON: % 
        ESTOS SON LOS FALLECIDOS POR ANIO Y EN QUE PANTEON:
			',
			datos.nombre;
		while (found) loop 
			RAISE NOTICE 
			'
			CAUSA: % 
			ANIO MUERTE: %
			CANTIDAD FALLECIDOS: %
			',
            datos.Causa_Muerte, datos.Anio_Muerte,datos.Cantidad_Fallecidos;
			FETCh cur_datos INTO datos;
		end loop;
END;
$$ LANGUAGE plpgsql;
SELECT causasmuerte(2)
