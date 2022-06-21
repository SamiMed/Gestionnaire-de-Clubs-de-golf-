# Gestionnaire de Clubs de golf
Un groupe d’entrepreneurs ont fondé six nouveaux petits terrains de golf, dans six municipalités voisines.  Pour attirer davantage de clientèle, on voudrait offrir des abonnements annuels.  On vous demande d’informatiser cette nouvelle façon de faire.    


Le tableau suivant vous indique les types d’abonnement qui seront disponibles et les prix ainsi que le montant des dépenses obligatoires pour l’année 2020.


|No	  |	Description							| Prix annuel 		|	Dépenses 	  |
|-----|-------------------------------------|-------------------|-----------------|
| 1	  |	Personne seule						|850 $				|	 400 $	      |
| 2	  |	Âge d’or							|500 $				|	 400 $ 	      |
| 3	  |	Couple								|1200$				|	 700 $	      |
| 4	  |	Famille (couple + 1 enfant)			|1 700 $			|	 700 $	      |
| 5	  |	Famille (couple + 2 enfants)		|1 900 $			|	 700 $	      |
| 6	  |	Famille (couple + 3 enfants ou plus)|2 100 $			|	 700 $	      |





Dans chaque abonnement, il y a l’abonné principal et ses dépendants (conjoint(e) et enfant(s)).
Les propriétaires veulent conserver l’information sur l’abonné principal et sur chacun de ses dépendants.  
Le numéro de l’abonné principal est codé de la manière suivante : NomFamille#LienP (par exemple : Gervais1P).
Le numéro de chaque dépendant est codé de la manière suivante : NomFamilleAbonnePrincipal#Lien[H|F|E]#Dépendant par exemple : Gervais1F0, Gervais1E1, Gervais1E2]).

Le système devra pouvoir en tout temps enregistrer un nouvel abonnement (pour l’abonné principal et ses dépendants).
Le système devra pouvoir également modifier les données de l’abonné principal et de ses dépendants.
Un an à la suite de son abonnement ou de son réabonnement, l’abonné principal peut renouveler son abonnement. S’il n’a pas renouvelé son abonnement, il ne peut plus jouer au golf et ne peut plus faire de dépenses.

En plus de payer son abonnement, l’abonné principal doit se voir inscrire des dépenses tout au long de la saison.  Les dépenses faites par ses dépendants sont cumulées à l’abonné principal. Ces dépenses proviennent principalement de trois services différents : Magasin Pro-Shop, Restaurant et Leçon de golf. Noter que d’autres types de services peuvent être enregistrés. 
Le système devra pouvoir, une fois par année seulement, modifier le prix annuel et les dépenses obligatoires.

Les propriétaires veulent aussi que le système puisse gérer les employés. Il existe 7 types d’employés : Administrateur (il n’y en a qu’un), Direction (il peut y en avoir plusieurs), Propriétaire d’un club (il peut y en avoir plusieurs), Employé au club de golf, Employé au magasin Pro-Shop, Employé au restaurant et Professeur de golf.


|No|Description	Remarque
|--|-----------------------
|1|	Administrateur	Il n’y en a qu’un et son numéro est 1
|2|	Direction	
|3|	Propriétaire d’un club	
|4|	Employé d’un club	
|5|	Employé Pro-Shop	
|6|	Employé d’un restaurant	
|7|	Professeur de golf	




Les propriétaires veulent aussi que le système puisse inscrire les parties jouées par les abonnés sur des terrains déjà déterminés. Les propriétaires veulent aussi avoir un certain nombre de rapports et de statistiques qui sont à déterminer.



Schéma de la base donnée :

![image](https://user-images.githubusercontent.com/48655888/174703187-f3384b42-9fcf-49c2-bad8-e1aca8c9ce54.png)



<h1>L’entrée dans le système et les cas d’utilisation</h1>

Pour entrer dans le système, l’utilisateur doit s’authentifier en fournissant son numéro d’employé et son mot de passe. Le mot de passe doit être validé; il doit avoir un minimum de 8 caractères, au moins une lettre, au moins un chiffre et au moins 1 caractère qui n’est ni une lettre, ni un chiffre.


Informations d'accès : 

| No d'employé | Mot de passe | Types d'utilisateurs|                                      
|--------------|--------------|--------------------|
|     1        | admin12#     |Administrateur      |
|     2        | direct0#     |Direction           |
|     3        | propri0#     |Propriétaire de club|                 
|     4        | empclb0#     |Employer-club       |
|     5        | emppro3#     |Employer pro-shop   |
|     6        | empres3#     |Employer restaurant |      
|     7        | profgol3#    |Prof de golf        |




Voici tous les cas d’utilisation:
-	Gestion des employés
-	Abonnement
-	Réabonnement
-	Mise à jour des abonnés (abonné principal et dépendants)
-	Modification des prix et des dépenses d’abonnement  
-	Inscription d’une partie de golf jouée
-	Inscription d’une dépense
-	Visualisation des rapports
-	Visualisation des statistiques
-	Déconnexion du système 
-	Sortie du système

Si l’employé n’a pas accès à un des cas d’utilisation, celui-ci doit être innacessible (invisible ou désactivé).

La déconnexion et la sortie du système sont accessibles à tous les employés.

  
<h1>La gestion des employés</h1>

L’administrateur ou un membre de la direction a le droit de gérer les employés.

On doit voir toutes les informations de tous les employés présents dans le système (de préférence dans un DataGridView).

Ajout d’un employé : 
-	On ne peut ajouter un administrateur (un seul administrateur pour le système)
-	Le numéro doit être calculé automatiquement
-	Tous les champs doivent être validés à l’exception du champ Remarque (obligatoire)
-	L’âge minimum est de 16 ans et le maximum est de 65 ans.
-	Le salaire horaire minimum est de 10.00$ et le maximum est de 500.00$.

Modification d’un employé :
-	À l’exception du numéro et du type, toutes les données d’un employé peuvent être modifiées. Valider. 

Suppression d’un employé.
-	L’administrateur ne peut être supprimé. 
-	Un administrateur ou un membre de la direction ne peut  s’auto-supprimer. 
-	Un employé qui offre des services ne peut être supprimé.

L’ajout et la modification des données d’un employé doivent être traitées de manière distincte (à l’intérieur de deux formulaires différents).

Une confirmation doit être demandée avant d’effectuer une  suppression.
 

<h1>L’abonnement</h1>

L’administrateur, un propriétaire d’un club, un employé d’un club ont le droit d’ajouter un nouvel abonnement.

-	L’âge minimum de l’abonné principal est de 60 ans pour les personnes de l’âge d’or et de 18 ans pour tous les autres. 

-	L’id de l’abonnement (qui correspond à l’id de l’abonné principal) est une chaîne de caractères Nom#LienP que votre programme doit créer. Par exemple, Gervais1P. Le #Lien doit être séquentiel. Par exemple, si le nom de famille du prochain abonné principal est Tremblay alors son id doit être Tremblay2P.  

-	La date d’abonnement doit être la date du jour. 

-	Dans le cas d’un abonnement pour une personne seule (#1) ou pour une personne de l’âge d’or (#2), l’abonnement se termine ici.

-	Dans le cas d’un abonnement pour un couple (#3) ou pour une famille (#4, #5 et #6), on demande, en plus, toutes les informations sur le conjoint (nom, prénom, sexe, date de naissance et remarque). Pour le conjoint, l’id de ce dépendant est une chaîne de caractères : NomAbonnePrincipal#Lien[H|F]0 que votre programme doit créer. Par exemple, Gervais1F0 (si c’est une conjointe). Par exemple, Gervais1H0 (si c’est un conjoint). 

-	Le conjoint doit être âgé de 18 ans ou plus

-	Dans le cas d’un abonnement pour une famille (#4, #5 et #6), on doit saisir les informations sur les enfants. S’il s’agit d’une famille avec 3 enfants ou plus, on doit demander, en plus, le nombre d’enfants (minimum 3 et maximum 9). Pour chaque enfant, l’id de l’enfant est une chaîne de caractères : NomAbonnePrincipal#LienE#Enfant que votre programme doit créer. Par exemple, Gervais1E1 (pour l’enfant #1) Gervais1E2 (pour l’enfant #2).
-	chaque enfant doit avoir moins que 18 ans (mais plus que 0 ans). 

-	Effectuez l’ensemble de ces ajouts dans la base de dommées au sein de la même transaction.

-	Informez l’utilisateur du succès de l’opération.

Attention : On ne peut pas supprimer un abonnement.

<h1>Le réabonnement</h1>

- L’administrateur ou un propriétaire d’un club ou un employé d’un club ont le droit de renouveller un abonnement.

- L’application doit afficher la liste de tous les abonnements qui peuvent être renouvelés (l’id de l’abonné principal accompagné de son nom complet).
 
- L’utilisateur sélectionne l’abonnement qu’il veut renouveller.

- L’utilisateur peut entrer une remarque.

*Attention : On ne peut renouveler un abonnement deux fois la même année. 

- Lorsque l’abonné principal se réabonne, la date de renouvellement (et la remarque) est ajoutée dans les réabonnements. 

*Attention : On ne peut pas supprimer un réabonnement.

<h1>La mise à jour des abonnés</h1>

- L’administrateur ou un propriétaire d’un club ou un employé d’un club ont le droit de mettre à jour les abonnés.

-	On ne peut supprimer des abonnés.

-	On doit voir toutes les infos des abonnés principaux (dans un DataGridView de préférence) et toutes les infos de tous les dépendants (dans un autre DataGridView). La sélection d’un abonné provoque l’affichage de tous ses dépendants.

-	On peut modifier tous le champs de l’abonné principal à l’exception de  son id, son nom de famille, sa date de naissance, la date d’abonnement et le type d’abonnement. 

-	On peut modifier tous le champs du dépendant à l’exception de  son id, l’id de l’abonnement et sa date de naissance (il peut modifier son nom de famille).

-	Effectuez Les modifications directement dans les DataGridView (et non pas sur un autre formulaire). 

-	Un bouton doit être prévu pour enregistrer les modifications dans la base de données. Toutes les modifications doivent avoir lieu au sein d’une même transaction. Sauvegardez, dans la base de données, l’ensemble de ces modifications au sein d’une même transaction. 


<h1>Modification d’un prix et des dépenses obligatoires</h1>

- L’administrateur ou un membre de la direction ou un propriétaire d’un club ont le droit de modifier un prix et des dépenses obligatoires d’abonnement.

- Tous les types d’abonnement doivent être affichés(dans un DataGridView de préférence): la description du type d’abonnement ainsi que le prix et les dépenses obligatoires courantes 
 *Attention : L’utilisateur peut modifier un prix et des dépenses obligatoires de chaque type d’abonnement une fois par année seulement. Par exemple, si les derniers prix et dépenses obligatoires ont été insérés en 2021, il doit attendre en 2022 (ou une des années suivantes) pour modifier ces montants. 

- Tous les types d’abonnement (modifiés ou non) doivent être insérés. 

- Les modifications doivent être réalisées directement dans le DataGridView.

- Sauvegardez l’ensemble de ces modifications au sein d’une même transaction.

*Attention : Le nouveau montant des dépenses obligatoires reliés à un type d’abonnement s’appliquent à toutes les dépenses effectuées pendant l’année en cours.


<h1>L’inscription d’une partie de golf jouée</h1>

- L’administrateur, un propriétaire d’un club, ou un employé peuvent inscrire une partie de golf jouée.

- L’utilisateur sélectionne l’abonnement (l’id de l’abonné principal accompagné de son nom complet), le terrain (le nom du terrain), entre son pointage et, possiblement, une remarque. La date de la partie est la date du jour. 

*Attention : Une partie de golf ne peut pas être inscrite si l’abonné principal est désabonné. Par exemple, si la date actuelle est en 2021 et que l’abonné principal ne s’est pas réabonné en 2021, alors l’inscription de cette partie de golf est refusée. 

<h1>L’inscription d’une dépense</h1>

- Tous les employés, sauf les employés d’un club, peuvent  inscrire une dépense.

- l’utilisateur (l’employé) sélectionne le client (l’id de l’abonné principal accompagné de son nom complet), entre ou choisit le montant de la dépense et, possiblement, une remarque. Le montant maximum est de 1000.00$. 

- La date de la dépense est la date du jour. Le numéro de la dépense doit être calculé par votre programme. 

Le type de service doit être automatiquement :
-	Magasin Pro Shop pour un employé Pro Shop
-	Restaurant pour un  employé Restaurant
-	Leçon de golf pour un employé professeur de golf

- Un administrateur, un membre de la direction ou un propriétaire de club peut entrer le le type de service qu’il désire. Valider. 

- Avant d’ajouter la dépense dans la base de données, vérifiez si le type de service pour cet employé existe déjà dans la base de données, sinon l’insérer. Ne pas oublier de relier la dépense au nouveau service.

- Par exemple, supposons que l’employé no 10 est un employé Pro-Shop et que le type de service Magasin Pro Shop n’existe pas pour l’employé no 10, vous devez ajouter l’enregistrement suivant dans la table des services.

|No	                    | TypeService 	  | NoEmploye |
|-----------------------|-----------------|-----------|
|Prochain numéro calculé|	Magasin Pro Shop|	    10    |
  
Puis, reliez la dépense à ce service.

Enregistrez la dépense dans la base de données. Tous les ajouts doivent avoir lieu au sein de la même transaction. 

A la fin de l’inscription de la dépense, un formulaire d’information doit être affiché. Ce formulaire doit contenir : le nom de l’abonné principal, la date de la dépense, le montant de la dépense, le type de service et le nom complet de l’employé ayant offert le service. Ce formulaire doit aussi inclure le montant des dépenses déjà effectuées et celui nécessaire pour atteindre la somme exigée par l’abonnement. 



<h1>Les rapports</h1>

- L’administrateur ou un membre de la direction ou un propriétaire d’un club ont le droit de visualiser les rapports.

Six rapports sont disponibles (suggestion : mettre les rapports dans des onglets)
-	Le rapport des dépenses par employé
-	Le rapport des dépenses par abonnement
-	Le rapport des dépenses par année
-	Le rapport des parties jouées par terrain
-	Le rapport des parties jouées par abonnement
-	Le rapport des parties jouées par année    

- Le rapport des dépenses par employé
Ce rapport doit être regroupé par nom complet d’employé. Pour chaque employé, on doit afficher le type de service rendu par l’employé, le montant de la dépense effectuée, la date de la dépense et le nom complet de l’abonné principal qui a effectué la dépense.

- Le rapport des dépenses par abonnement
Ce rapport doit être regroupé par le nom complet de l’abonné principal. Pour chaque abonnement, on doit afficher le montant de la dépense, la date de la dépense, le type de service rendu et le nom complet de l’employé qui a offert le service.

- Le rapport des dépenses par année
Ce rapport doit être regroupé par année. Pour chaque année, on doit afficher le nom complet de l’abonné principal qui a effectué la dépense, le montant de la dépense, la date de la dépense, le type de service rendu, le nom complet de l’employé qui a offert le service.

- Le rapport des parties jouées par terrain
Ce rapport doit être regroupé par nom de terrain. Pour chaque terrain, on doit afficher la date de la partie, le nom de l’abonné principal qui a joué la partie et son pointage.


- Le rapport des parties jouées par abonnement
Ce rapport doit être regroupé par nom complet d’abonné principal. Pour chaque abonné, on doit afficher la date de la partie, le nom du terrain et le pointage.

- Le rapport des parties jouées par année
Ce rapport doit être regroupé par année de partie jouée. Pour chaque année, on doit voir la date de la partie, le nom de l’abonné principal qui a joué la partie, le nom du terrain et le pointage.
