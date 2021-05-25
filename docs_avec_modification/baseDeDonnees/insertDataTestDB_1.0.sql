use wineManagerTests;

insert into countries (countryName) values 
("country1"),
("country2"),
("country3"),
("country4")
;


insert into colors (wineColor) values 
("rouge"),
("rose"),
("blanc")
;

insert into grapeVarieties(varietyName) values 
("cépage1"),
("cépage2"),
("cépage3"),
("cépage4")
;

insert into manufacturers(manufacturersName, country_id) values 
("producteur1", 1),
("producteur4", 2),
("producteur3", 4),
("producteur2", 4),
("producteur5", 3)
;


insert into storageBoxes (name, location) values 
("casier 1", "en haut à droite"),
("casier 2", "en haut à gauche"),
("casier 3", "en bas à droite")
;

insert into alerts (alertName, alertText) values 
("alerte1", "message1"),
("alerte2", "message2"),
("alerte3", "message3"),
("alerte4", "message4")
;

insert into wines
(wineName, color_id, storageBox_id, manufacturer_id, bottleNumber, volume, productionYear, description) 
values 
("bouteille1", 1, 2, 1, 4, 1.0, 2020, "description test"),
("bouteille2", 3, 3, 3, 6, 1.5, 1960, "description bouteille 2"), 
("bouteille3", 2, 1, 1, 1, 1.0, 1999, "description bouteille 3")
;

insert into logs (wine_id, actionName, detail, time) values 
(1, "Ajout de bouteille", "Ajout de la nouvelle bouteille bouteille1 dans la base de données", '2020-04-20 00:00:00'),
(3, "Ajout de bouteille", "Ajout de la nouvelle bouteille bouteille3 dans la base de données", '2020-04-28 00:00:00'),
(2, "Ajout de bouteille", "Ajout de la nouvelle bouteille bouteille2 dans la base de données", '2020-05-05 00:00:00')
;

insert into wines_has_alerts(alert_id, wine_id) values 
(1,1),
(2,2),
(3,3),
(4,4)
;


insert into wines_has_grapeVarieties(grapeVariety_ID, wine_id) values 
(3,1),
(2,2),
(1,3)
;
