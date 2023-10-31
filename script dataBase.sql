create database gestionEntreprise
use gestionEntreprise
-- create all table for database
create table utilisateur(
	idUtilisateur bigint identity primary key,
	[login] varchar(255),
	[password] varchar(255)
)
create table categorie(
	idCategorie bigint identity primary key,
	nomCategorie varchar(255)
)
create table stock(
	idStock bigint identity primary key,
	nomStock varchar(255)
)
create table detailleur(
	idDetailleur bigint identity primary key ,
	nomDetailleur varchar(255),
	prenomDetailleur varchar(255),
	telephoneDetailleur varchar(10)
)
create table phasonie(
	idPhasonie bigint identity primary key,
	nomPhasonie varchar(255),
	prenomPhasonie varchar(255),
	telephonePhasonie varchar(10)
)
create table lavage(
	idLavage bigint identity primary key,
	nomLavage varchar(255),
	prenomLavage  varchar(255),
	telephoneLavage varchar(255)
)
create table modele(
	referenceModele varchar(255) primary key,
	idCategorie bigint,
	taille varchar(255),
	designation varchar(max),
	imageModele varchar(255),
	marqueModele varchar(255),
	prixModele bigint,
	constraint fkModeleClient foreign key (idCategorie) references categorie(idCategorie)
)
alter table modele add qteStock bigint ; 
alter table modele add idStock bigint constraint fkModeleStock foreign key references stock(idStock);
alter table modele add constraint dfQteModeleStock default 0 for qteStock;
-- Les tables pour la Gestion des commandes
create table ville(
	idVille bigint identity primary key,
	nomVille varchar(55)
) 
create table client(
	idClient bigint identity primary key,
	nomClient varchar(255),
	prenomClient varchar(255),
	telephoneClient varchar(10),
	adresseClient varchar(255),
	villeClient varchar(255)
) 
alter table client add idVille bigint constraint fkClientVille foreign key references ville(idVille)
alter table client drop column villeClient
alter table client add restePayer bigint 

create table statutPayement(
	idStatutPayement bigint identity primary key,
	designation varchar(55)
)
drop table statutPayement

create table statutLivraison(
	idStatutLivraison bigint identity primary key,
	designation varchar(55)
)

create table commande(
	idCommande bigint identity primary key,
	dateCommande date,
	numeroBon bigint,
	idClient bigint,
	constraint fkCommandeClient foreign key(idClient) references client(idClient)
)
alter table commande add idStatutPayement bigint constraint fkCommandeStatutPayement foreign key references statutPayement(idStatutPayement); -- SUPPRIMER CE COLONNE
alter table COMMANDE add constraint dfStatutPayement default 2 for idStatutPayement; -- SUPPRIMER CE COLONNE
-- une colonne de statut de livraison a la table commande pour afficher le statut de livraison si livré ou en cour de livraison
alter table commande add idStatutLivraison bigint constraint fkcommandeStatutLivraison foreign key references statutLivraison(idStatutLivraison);
alter table commande add constraint dfStatutLivraison default 2 for idStatutLivraison

-- suppresion columne idStatutPayement from commande
ALTER TABLE commande DROP CONSTRAINT dfStatutPayement;
ALTER TABLE commande DROP CONSTRAINT fkCommandeStatutPayement;
ALTER TABLE commande DROP COLUMN idStatutPayement;
ALTER TABLE commande DROP COLUMN numeroBon;

create table detailCommande(
	idCommande bigint,
	referenceModele varchar(255),
	qteAchat bigint,
	prixAchat bigint,
	constraint fkDetailCommandeCommande foreign key(idCommande) references commande(idCommande),
	constraint fkDetailCommandeModele foreign key(referenceModele) references modele(referenceModele)
)
select * from client
---------   
---------
create table savonnerie(
	
) select * from ville
-- les table pour la gestion de phasonie et de savonnerie
create table matla(
	idMatla bigint identity primary key,
	referenceModele varchar(255),
	idDetailleur bigint,
	idPhasonie bigint,
	nbPiece bigint,
	dateDetailler date,
	nbPieceSorter bigint,
	prixPhasonnier bigint,
	numeroBon bigint,
	constraint fkMatlaModele foreign key(referenceModele) references modele(referenceModele),
	constraint fkMatlaDetailleur foreign key(idDetailleur) references detailleur(idDetailleur),
	constraint fkMatlaPhasonie foreign key(idPhasonie) references phasonie(idPhasonie)
)
alter table matla add statutMatla varchar(255)
create table phasonieStocker(
	idPhasonierStocker bigint identity primary key,
	idPhasonie bigint,
	idStock bigint,
	idMatla bigint,
	qteStocker bigint,
	dateStocker date,
	constraint fkPhasonieStockerPhasonie foreign key(idPhasonie) references phasonie(idPhasonie),
	constraint fkPhasonieStockerStock foreign key(idStock) references stock(idStock),
	constraint fkPhasonieStockerMatla foreign key(idMatla) references matla(idMatla)
)
create table transferePhasonieToLavage(
	idTransferePhasonieToLavage bigint identity primary key,
	idPhasonie bigint,
	idLavage bigint,
	idMatla bigint,
	qteTransfere bigint,
	dateTransfere date,
	numeroBon bigint,
	constraint fkTransferePhasonieToLavagePhasonie foreign key(idPhasonie) references phasonie(idPhasonie),
	constraint fkTransferePhasonieToLavageMatla foreign key(idMatla) references matla(idMatla),
	constraint fkTransferePhasonieToLavageLavage foreign key(idLavage) references lavage(idLavage)
)
create table transfereLavageToPhasonie(
	idtransfereLavageToPhasonie bigint identity primary key,
	idPhasonie bigint,
	idLavage bigint,
	idMatla bigint,
	qteTransfere bigint,
	dateTransfere date,
	numeroBon bigint,
	constraint fkTransfereLavageToPhasoniePhasonie foreign key(idPhasonie) references phasonie(idPhasonie),
	constraint fkTransfereLavageToPhasonieLavage foreign key(idLavage) references lavage(idLavage),
	constraint fkTransfereLavageToPhasonieMatla foreign key(idMatla) references matla(idMatla)
)
-- La partie de Sécurité de la base de données
create login [redwane kassou] with password = '123456' must_change, check_expiration=on; 
create login aziz with password = '123456' must_change, check_expiration=on; 
--creattion des utilisateur pour login
create user [redwane kassou] for login [redwane kassou];
create user [aziz] for login [aziz]
									-------------------------------------- **** Requettes **** ----------------------------------------------
									-------------------------------------- **** Requettes **** ----------------------------------------------
									-------------------------------------- **** Requettes **** ----------------------------------------------
-- insertion des information dans les tables 
-- insertion des utilisateurs
insert into utilisateur values ('redwane kassou','123456');
select distinct villeClient from client
select * from client order by idClient desc
select idClient,nomClient,prenomClient,telephoneClient,adresseClient,nomVille from client c inner join ville v on v.idVille=c.idVille 
where c.idVille = (select idVille from ville  where nomVille='agadir') 
select * from client
insert into client values('','','','')
select max(idClient)+1 from client
use gestionEntreprise
select * from utilisateur
select * from utilisateur
select * from client where idClient=4
select * from client
select * from ville

update client set nomClient='',prenomClient='', telephoneClient='',adresseClient='',idVille= where idClient=

select * from detailCommande

select c.idCommande,dateCommande,numeroBon,referenceModele,qteAchat,prixAchat 
from commande c inner join detailCommande dc on dc.idCommande=c.idCommande where idClient=1 

select count(*) from commande where idClient=1 group by idClient

select sum(prixAchat*qteAchat) from detailCommande dc inner join commande c on c.idCommande=dc.idCommande where idClient=1 group by idClient

select sum(qteAchat) from detailCommande dc inner join commande c on dc.idCommande=c.idCommande where idClient=1 group by idClient

select * from commande
select * from detailCommande
select * from statutPayement
-- insert coande to client 
insert into commande values(@dateCommande,@numeroBon,@idClient,@idStatutPayement)
insert into detailCommande values (@idCommande,@referenceModele,@qteAchat,@prixAchat)

update commande set dateCommande=@dateCommande,numeroBon=@numeroBon,idStatutPayement=@idStatutPayement where idCommande=22
update detailCommande set referenceModele=@referenceModele,qteAchat=@qteAchat,prixAchat=@prixAchat

select dateCommande,numeroBon,idClient,idStatutPayement,referenceModele,qteAchat,prixAchat from commande c inner join detailCommande dc on dc.idCommande=c.idCommande where c.idCommande=1

select c.idCommande,dateCommande,numeroBon,referenceModele,qteAchat,prixAchat,designation from commande c inner join detailCommande dc on dc.idCommande=c.idCommande 
inner join statutPayement sp on sp.idStatutPayement=c.idStatutPayement where c.idStatutPayement=1

select * from modele
select * from commande c inner join detailCommande dc on dc.idCommande=c.idCommande
select * from detailCommande
select * from modele m inner join categorie c on c.idCategorie=m.idCategorie where nomCategorie=''

select * from modele m inner join categorie c on c.idCategorie=m.idCategorie where m.idCategorie=2

insert into modele(referenceModele,idCategorie,taille,designation,imageModele,marqueModele,prixModele,idStock) 
values ('MD 5',8,'8 - 16 ans','test desgination','WhatsApp Image 2023-10-27 at 12.29.08 (1).jpeg','marque test',100,1)

insert into detailCommande values(12,'MD 1',100,70)
select * from commande c inner join detailCommande dc on dc.idCommande=c.idCommande where c.idCommande=12

select * from detailCommande where idCommande=23

select * from commande c inner join detailCommande dc on dc.idCommande=c.idCommande where c.idCommande=23

select c.idCommande,dateCommande,sum(qteAchat) as quantite from commande c inner join detailCommande dc on dc.idCommande=c.idCommande 
where idClient=13 and c.idCommande=23 group by c.idCommande,dateCommande

select c.idCommande,dateCommande,sum(qteAchat) as quantite,designation from commande c 
inner join detailCommande dc on dc.idCommande=c.idCommande 
inner join statutLivraison sl on sl.idStatutLivraison=c.idStatutLivraison 
where idClient=13 group by c.idCommande,dateCommande,designation

insert into commande(dateCommande,idClient) values('2023-10-31',13)
insert into detailCommande values(23,'MD 3',100,70)

select * from commande c inner join detailCommande dc on dc.idCommande=c.idCommande
update detailCommande set qteAchat=120,prixAchat=90 where idCommande=23 and referenceModele='MD 4'

select * from detailCommande where idCommande=23 and referenceModele='MD 4'

delete from detailCommande where idCommande=26 and referenceModele='MD 2'

select c.idCommande,dateCommande,designation from commande c 
inner join detailCommande dc on dc.idCommande=c.idCommande 
inner join statutLivraison sl on sl.idStatutLivraison=c.idStatutLivraison where idClient=13

delete from detailCommande where idCommande=23 and referenceModele='MD 2' and prixAchat=100
delete from detailCommande where idCommande=23 and referenceModele='MD 1'

delete from detailCommande where idCommande = 23 and referenceModele = 'MD 4'