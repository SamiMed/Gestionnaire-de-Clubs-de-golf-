# Gestionnaire-de-Clubs-de-golf-
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


Note : Tous les champs sont non nuls sauf les remarques et les cellulaires.


![image](https://user-images.githubusercontent.com/48655888/174703187-f3384b42-9fcf-49c2-bad8-e1aca8c9ce54.png)










