# MMI 2026 - Bases

# Fonctionnalités ajoutées

- Script de respawn du personnage lorsqu'il tombe dans le vide (script repris et modifié à partir du script du playerRobot).
- Une fois que le joueur a fini le dernier niveau, il peut se téléporter au tout premier niveau.

# MMI 2026 - Bases
# Setup
## Créer un nouveau projet depuis un Template

> [!NOTE]
> Vous retrouverez le tutoriel en ligne [ici](https://learn.unity.com/tutorial/get-started-with-unity-in-editor-tutorial)

1. Ouvrez Unity Hub et sélectionnez l'onglet Projects dans la barre de menu à gauche
2. Appuyez sur le bouton bleu "New project" en haut à droite
3. Sélectionnez la version Unity 6.2
4. Sélectionnez le template "Get Started With Unity"
5. Saisissez un nom pour le projet
6. Cliquez sur le bouton "Create project" et attendez l'ouverture du projet

## Ouvrir un projet Unity existant

1. Ouvrez Unity Hub et sélectionnez l'onglet Projects dans la barre de menu à gauche
2. Appuyez sur le bouton "Add" en haut à droite
3. Sélectionnez le répertoire du projet
4. Cliquez sur le bouton "Open" et attendez l'ouverture du projet

# Premiers pas dans Unity

> [!NOTE]
> Pour plus de détails vous pouvez suivre le tutorial [ici](https://learn.unity.com/tutorial/explore-the-unity-editor-1)

## L'interface de l'éditeur
![Image d'illustration des zones de l'éditeur](https://unity-connect-prd.storage.googleapis.com/20220606/learn/images/7fabb375-5282-4852-9ecf-d8acc254052b_EditorExplore.png)

### Scene view et Game view 
Zones de visualisation des objets 3D (**Scene**) et la vue joueur (**Game**)
> [!TIP]
> Avec le layout par défaut la Game View apparaît au même endroit. Utilisez les onglets pour naviguer.

### Hierarchy window 
Collection d’objets dans la scene.

### Project window 
Équivalent d’un explorateur de fichiers pour le projet.

### Toolbar 
Outils de navigation et de manipulation dans la scène

### Inspector window 
Panneau de configuration d’un objet sélectionné.

## Manipuler les objets 3D
![Image d'illustration des outils de transformation](https://unity-connect-prd.storage.googleapis.com/20220601/learn/images/057c859e-04d5-429a-b980-b852a80b2015_gizmos.png)

- W: Outil de déplacement, pour sélectionner et bouger un objet
- E: Outil de rotation, pour sélectionner et tourner un objet
- R: Outil de dimensionnement, pour sélection et changer la taille d'un objet

> [!TIP]
> Utilisez les raccourcis par défaut W (Move), E (Rotate), R (Scale) pour sélectionner l'outil rapidement.

Pour chacun des outils de transformation, un Gizmo apparaît qui vous permet de manipuler le GameObject le long de chaque axe spécifique. 
Lorsque vous manipulez ces contrôles, les valeurs du composant Transform changent en conséquence.

## Créer une nouvelle scène
### Scène vide
1. Ouvrez le dossier **Assets/Scenes** dans la fenêtre Project
2. Cliquez droit pour ouvrir le menu contextuel
3. Sélectionnez **Create/Scene** 
4. Nommez la scène

### Template
1. Ouvrez le menu **File / New Scene…**
2. Sélectionnez le template souhaité
3. Sauvegardez la scène ouverte

### Ajouter la nouvelle scène au build
1. Ouvrez le sous-menu **Build Profiles** depuis le menu **File**
2. Sélectionner l'onglet "Scene List"
2. Glissez/déposez la nouvelle scène dans l'encadré

> [!TIP]
> Utilisez le raccourcis Ctrl+Shift+B pour ouvrir rapidement les Build Settings

# Prefabs

Un Prefab agit comme un modèle à partir duquel vous pouvez créer de nouvelles instances préfabriquées d'un GameObject dans la scène. 
Cela vous permet de créer, configurer et stocker un GameObject complet avec tous ses composants, valeurs de propriété et enfants en tant qu'asset réutilisable.

## Créer un Prefab
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/CreatingPrefabs.html)

Faites glisser un GameObject de la fenêtre Hierarchy vers la fenêtre Project.
Le GameObject, ainsi que tous ses composants et enfants, deviennent un nouvel Asset dans votre fenêtre Project. 

> [!TIP]
> Ce processus de création du Prefab transforme également le GameObject d'origine en une instance du nouveau Prefab.

Les Prefabs dans la fenêtre Project sont affichés avec une vue miniature du GameObject ou l'icône Prefab en forme de cube bleu en fonction de la manière dont vous avez paramétré l'affichage.

![Image d'illustration](https://docs.unity3d.com/6000.2/Documentation/uploads/Main/prefab-workflow.png)

Toutes les modifications sont automatiquement répercutées dans les instances du Prefab modifié. 
Cela permet des changements à l'échelle du projet sans avoir à effectuer à plusieurs reprises la même modification sur chaque copie de l'élément.

Vous pouvez remplacer les paramètres des instances de Prefab individuelles si vous souhaitez que certaines instances d'un Prefab diffèrent des autres. 
Vous pouvez également créer des variantes de Prefab qui vous permettent de regrouper un ensemble de remplacements dans une variation significative d'un Prefab appelée Prefab Variant.

## Modifier un Prefab
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/EditingInPrefabMode.html)

Ouvrez-le dans le Prefab Mode en cliquant sur la flèche à droite de son nom dans la scène.
Ou en double-cliquant sur le Prefab dans la fenêtre Project.

![Image d'illustration](https://learn.unity.com/_next/image?url=https%3A%2F%2Fconnect-mediagw.unity.com%2Fh1%2F20200829%2Flearn%2Fimages%2Fb9bb8293-36d2-4611-be04-9d241c979ba1_image2.png&w=640&q=75)

Ce mode vous permet d'afficher et de modifier le contenu du Prefab séparément de tout autre GameObject dans votre scène. 
Les modifications que vous effectuez dans le Prefab Mode affectent toutes les instances de ce Prefab.

![Image d'illustration](https://docs.unity3d.com/6000.2/Documentation/uploads/Main/prefabs-isolation-mode.png)

En Prefab Mode, la vue Scene affiche une barre de navigation en haut. 
L'entrée la plus à droite correspond au Prefab actuellement ouvert. 
Utilisez la barre de navigation pour revenir aux scènes principales ou aux autresPrefabs que vous avez peut-être ouvertes en naviguant la hiérarchie.

## Prefab Variants
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/PrefabVariants.html)

Une variante de Prefab hérite des propriétés d'un autre Prefab, appelée la base. 
Les modifications apportés à la variante de Prefab ont priorité sur les valeurs de la base. 
Une variante de Prefab peut avoir n'importe quelle autre Prefab comme base, y compris les Prefab de modèle ou d'autres variantes de Prefab.

Les Prefab Variant sont affichées avec l'icône préfabriquée bleue décorée de flèches.

![Image d'illustration](https://docs.unity3d.com/6000.2/Documentation/uploads/Main/prefab-variant-icon.png)

Cliquez avec le bouton droit sur un Prefab dans la vue Project et sélectionner Create > Prefab Variant. 
Cela crée une variante du Prefab sélectionné, qui ne comporte initialement aucune substitution. 
Vous pouvez ouvrir la variante de Prefab dans le Prefab Mode pour commencer à y ajouter des substitutions.

Vous pouvez également faire glisser une instance de Prefab de la **Hierarchy** vers la fenêtre **Project**. 
Une boîte de dialogue vous demande si vous souhaitez créer un nouveau Prefab ou un Prefab Variant. 
Si vous choisissez Prefab Variant, vous obtenez une nouvelle variante basée sur l'instance de Prefab que vous avez fait glisser. 
Toutes les substitutions que vous aviez sur cette instance se trouvent désormais à l'intérieur de la nouvelle variante. 
Vous pouvez l'ouvrir dans le Prefab Mode pour ajouter des substitutions supplémentaires ou pour modifier ou supprimer des substitutions.

# Créer un nouveau script

> [!CAUTION]
> Avant d'aller plus loin, assurez-vous d'avoir exploré l'éditeur en suivant le tutorial [Get Started With Unity](https://learn.unity.com/tutorial/get-started-with-unity-in-editor-tutorial)

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/CreatingAndUsingScripts.html)

- À partir du menu Créer en haut à gauche du panneau Projet
- À partir du menu contextuel (clic droit) Create / C# Script
- En sélectionnant Assets > Create > C# Script dans le menu principal

> [!TIP]
> Lorsque vous créez un script C# à partir de la fenêtre de projet d’Unity, il hérite automatiquement de [MonoBehaviour](https://docs.unity3d.com/Manual/class-MonoBehaviour.html) et vous fournit un template.

## Ajouter un nouveau component
> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/UsingComponents.html)

Une fois sélectionné le GameObject
- À partir du menu Component s'il s'agit d'un composant natif
- Par le Component Browser dans l'inspecteur

# Collider Interactions

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Manual/collider-interactions.html)

Lorsque deux Colliders entrent en contact, vous pouvez appeler des fonctions pour déclencher d'autres événements dans votre projet via des scripts.

> [!CAUTION]
> Les événements Collider nécessitent une configuration via un script C# ; vous ne pouvez pas les configurer en utilisant uniquement l'interface utilisateur.

### Collision events
Ces événements se produisent lorsque deux Colliders entrent en contact et qu'aucun des collisionneurs n'a la fonction IsTrigger activée.

### Trigger events 
Ces événements se produisent lorsque deux Colliders entrent en contact, qu'au moins un Collider a l'option IsTrigger activée et qu'au moins un Collider a un Rigidbody ou ArticulationBody.

## OnCollision events

Le travail avec les événements de collision implique principalement les fonctions API suivantes :

[Collider.OnCollisionEnter](https://docs.unity3d.com/ScriptReference/Collider.OnCollisionEnter.html) : Appelée sur chaque GameObject lorsque deux Colliders entrent en contact pour la première fois.

[Collider.OnCollisionStay](https://docs.unity3d.com/ScriptReference/Collider.OnCollisionStay.html) : Appelée sur chaque GameObject une fois par mise à jour physique lorsque deux Colliders sont en contact.

[Collider.OnCollisionExit](https://docs.unity3d.com/ScriptReference/Collider.OnCollisionExit.html) : Appelée sur chaque GameObject lorsque deux Colliders cessent le contact.

> [!CAUTION]
> Pour les Collision events, au moins un des objets impliqués doit avoir un corps physique dynamique (c'est-à-dire un Rigidbody ou un ArticulationBody dont l'option IsKinematic est désactivée). 

> [!WARNING]
> Si les deux GameObjects d'une collision sont des corps physiques Kinematic, la collision n'appelle pas les fonctions OnCollision.

## OnTrigger events

Les Triggers Colliders ne provoquent pas de collisions. 
Au lieu de cela, ils détectent les autres **Colliders** qui les traversent et appellent des fonctions que vous pouvez utiliser pour déclencher des événements.

L'utilisation de Trigger Collider implique principalement les fonctions API suivantes :

[Collider.OnTriggerEnter](https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html) : Appelée sur un GameObject qui possède un Collider en mode IsTrigger lorsqu'il entre en contact pour la première fois avec un autre Collider.

[Collider.OnTriggerStay](https://docs.unity3d.com/ScriptReference/Collider.OnTriggerStay.html) : Appelée sur un GameObject qui possède un Collider en mode IsTrigger une fois par image s'il détecte un autre Collider à l'intérieur de ses limites.

[Collider.OnTriggerExit](https://docs.unity3d.com/ScriptReference/Collider.OnTriggerExit.html) : Appelée sur un GameObject qui possède un Collider en mode IsTrigger lorsqu'il cesse le contact avec un autre Collider.

## Créer et configurer un Trigger Collider

1. Créez un GameObject
	- Pour créer un Trigger Collider invisible, créez un GameObject vide. Dans la plupart des cas, ces colliders sont invisibles.
	- Pour créer un Trigger Collider visible, créez un GameObject doté d'un Mesh. Ce type de Collider n'a besoin d'être visible que s'il est possible pour d'autres GameObjects de le traverser de manière visible pendant le jeu.
2. Ajoutez un composant Collider au GameObject
3. Configurez le Collider comme un Trigger:
	- En éditeur, affichez l'inspecteur du Collider en question et cochez la propriété IsTrigger
	- En script, modifiez la propriété IsTrigger avec la valeur true

# Input System

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.15/manual/QuickStartGuide.html)

Obtenir un Input directement à partir d'un périphérique d'entrée est rapide et pratique, mais nécessite un chemin distinct pour chaque type de périphérique.
Cela rend également plus difficile de modifier ultérieurement le contrôle du périphérique qui déclenche un événement spécifique dans le jeu.

À la place il est possible d'utiliser les actions comme intermédiaire entre les Inputs des périphériques et les réponses qu'ils déclenchent.
Le moyen le plus simple est d'utiliser le composant PlayerInput sur le GameObject d'un joueur. 

> [!IMPORTANT]
> Chaque PlayerInput représente un joueur différent dans le jeu.

## Modifier un asset Input Action

Pour afficher l'éditeur d'actions
- double-cliquez sur un élément .inputactions dans le navigateur de projet
- ou sélectionnez le bouton Modifier l'élément dans l'inspecteur de cet élément

L'éditeur d'actions apparaît sous la forme d'une fenêtre distincte, que vous pouvez également ancrer dans l'interface  pour ne pas avoir à accéder à l'asset systématiquement.

![Image d'illustration](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.15/manual/images/ActionsEditorCallout.png)

> [!CAUTION]
> Par défaut, Unity n'enregistre pas les modifications que vous effectuez dans l'éditeur d'actions lorsque vous enregistrez le projet.
> Pour enregistrer vos modifications, sélectionnez Save Asset dans la barre d'outils de la fenêtre.
> Ou bien activez l'enregistrement automatique en activant la case à cocher Auto Save dans la barre d'outils.

# Camera

> [!NOTE]
> Plus de détails dans le [manuel](https://docs.unity3d.com/6000.2/Documentation/Manual/CamerasOverview.html)

Une scène Unity représente des GameObjects dans un espace tridimensionnel. 
L'écran de l'utilisateur étant bidimensionnel, Unity doit capturer une vue et l'« aplatir » pour l'affichage. Il utilise pour cela des caméras.
La caméra Unity est un GameObject qui inclut un composant Camera.

> [!TIP]
> Chaque nouvelle scène Unity vient avec une camera pour en faire le rendu. Elle est défini comme la caméra principale (MainCamera).
> Attention si vous venez à la dupliquer ou en créer une vous-même. Il est important de n'avoir qu'une seule caméra principale.

## Projection
Active ou désactive la capacité de la caméra à simuler la perspective.

### Perspective
La caméra rendra les objets avec une perspective intacte.
Utilisez les paramètres de Field of View pour contrôler l'angle de vue de la caméra.
Mesuré en degrés selon l'axe spécifié dans FOV Axis.

![Image d'illustration](https://docs.unity3d.com/2022.3/Documentation/uploads/Main/Camera-Non-Ortho-FPS.jpg)

### Orthographic
La caméra rendra les objets de manière uniforme, sans aucun sens de la perspective.
Contrôlez la zone visible par l’utilisateur sur son écran (viewport) grâce au paramètre Size. 

![Image d'illustration](https://docs.unity3d.com/2022.3/Documentation/uploads/Main/Camera-Ortho-FPS.jpg)

> [!NOTE]
> Pour aller plus loin sur les différents modes de [projection](https://docs.unity3d.com/6000.2/Documentation/Manual/2Dor3D.html).
> Chaque mode est compatible avec des graphismes 2D ou des géométries 3D. Il est cependant important d'avoir une bonne compréhension des contraintes de chaque mode.

![Image d'illustration](https://docs.unity3d.com/uploads/Main/MecanimAnimatorControllerWindow.png)
