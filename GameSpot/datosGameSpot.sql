--Datos GameSpot
--Usuarios
insert into usuario values(1,'juan@gmail.com','juanito','Juan','M',20);
insert into usuario values(2,'luis@gmail.com','luisito','Luis','M',20);
insert into usuario values(3,'diana@gmail.com','dianita','Diana','F',24);
insert into usuario values(4,'elsa@gmail.com','elsita','Elsa','F',22);
insert into usuario values(5,'daniel@gmail.com','dany','Daniel','M',22);

--Consolas
insert into consola values(10,'PS4')
insert into consola values(20,'Xbox 360')
insert into consola values(30,'Nintendo DS3')
insert into consola values(40,'PC')

--Juegos
insert into juego values(1,'Destiny',
	'It is a first-person shooter with elements of open-world sandbox and persistent world where humans are up against an alien threat seeking to rid them of existence.',
	10,'2014/09/09');
insert into juego values(2,'Alien: isolation',
	'Alien Isolation sees you take on the role of Amanda Ripley as she faces off with Xenomorphs in the search for answers about her mothers disappearance.',
	20,'2014/06/10');
insert into juego values(3,'Styx: master of shadows',
	'Styx: Master of Shadows is an infiltration game with RPG elements developed by Cyanide Studio for PC.',
	10,'2014/06/10');
insert into juego values(23,'Resident Evil Village','Sequel to Resident Evil 7',
	40,'2021/05/07')


--Criticas
insert into critica values(1,'Mal juego','2014/03/03','No me gustó, los botones no responden','1');
insert into critica values(2,'Muy bueno','2014/05/05','Hasta que lo acabe!','7');
insert into critica values(3,'Excelente!','2014/06/06','Los personajes son muy buenos','9');
insert into critica values(4,'Mal programado','2014/07/07','La animacion es muy mala','8');
insert into critica values(5,'Aburrido','2014/08/08','No pasa nada, nunca','7');
insert into critica values(6,'Muy corto','2014/09/09','Lo acabe muy rápido','6');
insert into critica values(10,'No es como la franquicia','2021/09/12','Evoluciona para ser algo muy diferente que su predecesor','7')
insert into critica values(11,'Me gustó más que el anterior','2021/08/08','Es mucho más emocionante y espeluznante que el pasado','9')
--Escriben
insert into escriben values(1,1,5);
insert into escriben values(2,2,3);
insert into escriben values(4,2,2);
insert into escriben values(5,1,4);
insert into escriben values(1,3,6);
insert into escriben values(1,23,10);
insert into escriben values(5,23,11);