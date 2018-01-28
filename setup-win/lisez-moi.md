Blockly4Thymio
==============

Guide de création du fichier setup.exe pour l'OS Windows
--------------------------------------------------------

Le fichier d'installation (setup.exe) blockly4thymio.vX.XX.exe est crée à l'aide de l'appliation InnoSetup Compiler 5.5, disponible sur http://www.jrsoftware.org/isinfo.php.

Etapes
------

* Générer la Release du projet Blockly4Thymio.csproj à l'aide de Xamarin Studio ou Visual Studio,
* Dans le répertoire \bin\x86\Release, copier le fichier Compilateur.X.XX.exe généré dans le répertoire \setup-win\fichiers,
* Corriger le numéro de version dans le fichier LISEZ-MOI.rtf,
* Lancer la compilation du fichier setup.iss, depuis InnoSetup.

Copyrigth Okimi 2015-2018 (contact at okimi dot net)
