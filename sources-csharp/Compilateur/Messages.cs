
/*
Copyright Okimi 2015-2018 (contact at okimi dot net)

Ce logiciel est un programme informatique servant à compiler un fichier
Blockly4Thymio (.b4t), à le transfomer en fichier Aseba (.aesl) et le
transmettre à un robot Thymio. Ce logiciel fait partie d'une suites de
logiciels nommée Blockly4Thymio.

Ce logiciel est régi par la licence CeCILL soumise au droit français et
respectant les principes de diffusion des logiciels libres. Vous pouvez
utiliser, modifier et/ou redistribuer ce programme sous les conditions
de la licence CeCILL telle que diffusée par le CEA, le CNRS et l'INRIA 
sur le site "http://www.cecill.info".

En contrepartie de l'accessibilité au code source et des droits de copie,
de modification et de redistribution accordés par cette licence, il n'est
offert aux utilisateurs qu'une garantie limitée.  Pour les mêmes raisons,
seule une responsabilité restreinte pèse sur l'auteur du programme,  le
titulaire des droits patrimoniaux et les concédants successifs.

A cet égard  l'attention de l'utilisateur est attirée sur les risques
associés au chargement,  à l'utilisation,  à la modification et/ou au
développement et à la reproduction du logiciel par l'utilisateur étant 
donné sa spécificité de logiciel libre, qui peut le rendre complexe à 
manipuler et qui le réserve donc à des développeurs et des professionnels
avertis possédant  des  connaissances  informatiques approfondies.  Les
utilisateurs sont donc invités à charger  et  tester  l'adéquation  du
logiciel à leurs besoins dans des conditions permettant d'assurer la
sécurité de leurs systèmes et ou de leurs données et, plus généralement, 
à l'utiliser et l'exploiter dans les mêmes conditions de sécurité. 

Le fait que vous puissiez accéder à cet en-tête signifie que vous avez 
pris connaissance de la licence CeCILL, et que vous en avez accepté les
termes.

===============================================================================

Copyright Okimi 2015-2018 (contact at okimi dot net)

This software is a computer program whose purpose is to compil Blockly4Thymio
file (.b4t), to transform it into Aseba file (.aesl) and send it to Thymio
Robot. This software is part of Blockly4Thymio serie.

This software is governed by the CeCILL license under French law and
abiding by the rules of distribution of free software.  You can  use, 
modify and/ or redistribute the software under the terms of the CeCILL
license as circulated by CEA, CNRS and INRIA at the following URL
"http://www.cecill.info". 

As a counterpart to the access to the source code and  rights to copy,
modify and redistribute granted by the license, users are provided only
with a limited warranty  and the software's author,  the holder of the
economic rights,  and the successive licensors  have only  limited
liability. 

In this respect, the user's attention is drawn to the risks associated
with loading,  using,  modifying and/or developing or reproducing the
software by the user in light of its specific status of free software,
that may mean  that it is complicated to manipulate,  and  that  also
therefore means  that it is reserved for developers  and  experienced
professionals having in-depth computer knowledge. Users are therefore
encouraged to load and test the software's suitability as regards their
requirements in conditions enabling the security of their systems and/or 
data to be ensured and,  more generally, to use and operate it in the 
same conditions as regards security. 

The fact that you are presently reading this means that you have had
knowledge of the CeCILL license and that you accept its terms.
*/

using System;
using 	System.Globalization;



namespace		Blockly4Thymio {
public class 	Messages {

	public enum TYPE {
		BOUCLE_INFÉRIEURE_A_1 = 1,
		BOUCLE_SUPÉRIEURE_A_100,
		DURÉE_INFÉRIEURE_A_0,
		DURÉE_SUPÉRIEURE_A_60,
		DISTANCE_INFÉRIEURE_A_1,
		DISTANCE_SUPÉRIEURE_A_100,
		ANGLE_INFÉRIEURE_A_0,
		ANGLE_SUPÉRIEURE_A_360,
		VITESSE_INFÉRIEURE_A_MOINS_100_POURCENT,
		VITESSE_SUPÉRIEURE_A_100_POURCENT,
		ASEBAHTTP_INTROUVABLE,
		THYMIO_NON_CONNECTÉ,
		PROGRAMME_TROP_GRAND_POUR_THYMIO,
		PAS_D_INSTRUCTION_DE_DÉPART,
		FICHIER,
		LECTURE_DU_FICHIER_B4T,
		COMPILATION_DU_FICHIER_B4T,
		TRANSFERT_DU_FICHIER_ASEBA,
		COMPILATION_ET_TRANSFERT_TERMINÉ,
		FICHIER_N_EXISTE_PAS,
		FICHIER_NON_LISIBLE,
		AIDE,
		ENTÊTE,
		BLOC_NON_TRAITÉ_DANS_CETTE_VERSION,
		LA_VERSION_APPROPRIÉE_POUR_CE_BLOC,
		CHRONOMÈTRE_INFÉRIEUR_À_1_SECONDE,
		CHRONOMÈTRE_SUPÉRIEUR_À_6_SECONDES,
		VARIABLE_NON_INITIALISÉE
	}




	/// <summary>
	/// Liste des messages d'erreur.
	/// </summary>
	/// <returns>String</returns>
	public	static	String	Message( int _numéro ) {

		String		langue;
		String		texte;

		CultureInfo	ci = CultureInfo.InstalledUICulture ;
		
		

		langue = ci.Name.ToLower().Substring(0,2);

		switch (langue) {

		case "en" :

			switch( _numéro ) {

			case (int)TYPE.BOUCLE_INFÉRIEURE_A_1 :						return "In one of the loops, the repetition number is less than 1. This has been corrected to be at least 1";
			case (int)TYPE.BOUCLE_SUPÉRIEURE_A_100 :					return "In one of the loops, the repetition number is greater than 100. This has been corrected to be 100.";
			case (int)TYPE.DURÉE_INFÉRIEURE_A_0 :						return "Une durée est plus petite que 0s. Celle-ci a été corrigée pour être au moins à 0 seconde.";
			case (int)TYPE.DURÉE_SUPÉRIEURE_A_60 :						return "A duration is greater than 60s. This has been corrected to be 60 seconds.";
			case (int)TYPE.DISTANCE_INFÉRIEURE_A_1 :					return "A distance is less than 1cm. This has been corrected to be at least 1cm.";
			case (int)TYPE.DISTANCE_SUPÉRIEURE_A_100 :					return "A distance is greater than 100cm. This has been corrected to be 100cm.";
			case (int)TYPE.ANGLE_INFÉRIEURE_A_0 :						return "An angle is less than 0°. This has been corrected to be at least 0°.";
			case (int)TYPE.ANGLE_SUPÉRIEURE_A_360 :						return "An angle is greater than 360°. This one has been corrected to be 360°.";
			case (int)TYPE.VITESSE_INFÉRIEURE_A_MOINS_100_POURCENT :	return "The speed is less than -100(%). This has been corrected to be -100(%).";
			case (int)TYPE.VITESSE_SUPÉRIEURE_A_100_POURCENT :			return "The speed is greater than 100(%). This has been corrected to be 100(%).";
			case (int)TYPE.ASEBAHTTP_INTROUVABLE :						return "Error ! The executable {0} to pass the .aesl file to the Thymio robot does not exist.";
			case (int)TYPE.THYMIO_NON_CONNECTÉ :						return "Error ! Thymio is offline";
			case (int)TYPE.PROGRAMME_TROP_GRAND_POUR_THYMIO :			return "Error ! The program is too large for Thymio's memory.";
			case (int)TYPE.PAS_D_INSTRUCTION_DE_DÉPART :				return "There is no start instruction in file {0} .";
			case (int)TYPE.FICHIER :									return "File : {0}";		
			case (int)TYPE.LECTURE_DU_FICHIER_B4T :						return "Reading b4t file...";
			case (int)TYPE.COMPILATION_DU_FICHIER_B4T :					return "Compiling b4t file...";
			case (int)TYPE.TRANSFERT_DU_FICHIER_ASEBA :					return "Sending Aseba file...";
			case (int)TYPE.COMPILATION_ET_TRANSFERT_TERMINÉ :			return "Compilation et transfer completed !";
			case (int)TYPE.FICHIER_N_EXISTE_PAS :						return "Error ! The {0} file does not exist.";
			case (int)TYPE.FICHIER_NON_LISIBLE :						return "Error reading file {0}.";
			case (int)TYPE.AIDE :										return	"\r\n" + 
																				"No .b4t source files have been declared.\r\n" +
																				"Usage: Assign the .b4t files to this executable.\r\n";
			case (int)TYPE.ENTÊTE:
				texte = "";
				#if DEBUG
				texte +=														"**********************\r\n" +
																				"* !!! DEBUG MODE !!! *\r\n" +
																				"**********************\r\n";
				#endif
				texte +=														"Blockly4Thymio Compiler  - Okimi ©2015-2018 - version " + Compilateur.version + "\r\n" +
																				"\r\n" +
																				"Compiles a .b4t file into an Aseba file and passes it to the Thymio II robot.\r\n" +
																				"Blockly4Thymio uses the asebahttp program to transfer the Aseba file to the Thymio robot.\r\n" +
																				"\r\n";
				return	texte;
			case (int)TYPE.BLOC_NON_TRAITÉ_DANS_CETTE_VERSION :			return	"Error ! The {0} block is not processed in this version of the compiler.";
			case (int)TYPE.LA_VERSION_APPROPRIÉE_POUR_CE_BLOC :			return	"\nThe most suitable compiler version for this block is version {0}";
			case (int)TYPE.CHRONOMÈTRE_INFÉRIEUR_À_1_SECONDE :			return	"The time of the smallest timer is 1 second.";
			case (int)TYPE.CHRONOMÈTRE_SUPÉRIEUR_À_6_SECONDES :			return	"The largest timer time is 6 seconds.";
			case (int)TYPE.VARIABLE_NON_INITIALISÉE :					return	"The variable {0} is not initialized.";

			}
			break;


		default :	// Langue française (fr)

			switch( _numéro ) {

			case (int)TYPE.BOUCLE_INFÉRIEURE_A_1 :						return "Dans une des boucle, le nombre de répétition est plus petit que 1. Celui-ci a été corrigé pour être au moins à 1.";
			case (int)TYPE.BOUCLE_SUPÉRIEURE_A_100 :					return "Dans une des boucle, le nombre de répétition est plus grand que 100. Celui-ci a été corrigé pour être à 100.";
			case (int)TYPE.DURÉE_INFÉRIEURE_A_0 :						return "Une durée est plus petite que 0s. Celle-ci a été corrigée pour être au moins à 0 seconde.";
			case (int)TYPE.DURÉE_SUPÉRIEURE_A_60 :						return "Une durée est plus grande que 60s. Celle-ci a été corrigée pour être à 60 secondes.";
			case (int)TYPE.DISTANCE_INFÉRIEURE_A_1 :					return "Une distance est plus petite que 1cm. Celle-ci a été corrigée pour être au moins à 1cm.";
			case (int)TYPE.DISTANCE_SUPÉRIEURE_A_100 :					return "Une distance est plus grande que 100cm. Celle-ci a été corrigée pour être de 100cm.";
			case (int)TYPE.ANGLE_INFÉRIEURE_A_0 :						return "Un angle est plus petit que 0°. Celui-ci a été corrigé pour être au moins à 0°.";
			case (int)TYPE.ANGLE_SUPÉRIEURE_A_360 :						return "Un angle est plus grand que 360°. Celui-ci a été corrigé pour être de 360°.";
			case (int)TYPE.VITESSE_INFÉRIEURE_A_MOINS_100_POURCENT :	return "La vitesse est inférieure à -100(%). Celle-ci a été corrigée pour être à -100(%).";
			case (int)TYPE.VITESSE_SUPÉRIEURE_A_100_POURCENT :			return "La vitesse est supérieure à 100(%). Celle-ci a été corrigée pour être à 100(%).";
			case (int)TYPE.ASEBAHTTP_INTROUVABLE :						return "Erreur ! L'exécutable {0} pour transmettre le fichier .aesl au robot Thymio n'existe pas.";
			case (int)TYPE.THYMIO_NON_CONNECTÉ :						return "Erreur ! Thymio n'est pas connecté.";
			case (int)TYPE.PROGRAMME_TROP_GRAND_POUR_THYMIO :			return "Erreur ! Le programme est trop grand pour la mémoire de Thymio.";
			case (int)TYPE.PAS_D_INSTRUCTION_DE_DÉPART :				return "Il n'y a pas d'instruction de départ dans le fichier {0} .";
			case (int)TYPE.FICHIER :									return "Fichier : {0}";		
			case (int)TYPE.LECTURE_DU_FICHIER_B4T :						return "Lecture du fichier b4t...";
			case (int)TYPE.COMPILATION_DU_FICHIER_B4T :					return "Compilation du fichier b4t...";
			case (int)TYPE.TRANSFERT_DU_FICHIER_ASEBA :					return "Transfert du fichier Aseba...";
			case (int)TYPE.COMPILATION_ET_TRANSFERT_TERMINÉ :			return "Compilation et transfert terminés !";
			case (int)TYPE.FICHIER_N_EXISTE_PAS :						return "Erreur ! Le fichier {0} n'existe pas.";
			case (int)TYPE.FICHIER_NON_LISIBLE :						return "Erreur lors de la lecture du fichier {0} .";
			case (int)TYPE.AIDE :										return	"\r\n" + 
																				"Aucun fichier source .b4t n'a été déclaré.\r\n" +
																				"Utilisation : Associez les fichier .b4t à cet éxécutable.\r\n";
			case (int)TYPE.ENTÊTE:
				texte = "";
				#if DEBUG
				texte +=														"**********************\r\n" +
																				"* !!! MODE DEBUG !!! *\r\n" +
																				"**********************\r\n";
				#endif
				texte +=														"Compilateur Blockly4Thymio - Okimi ©2015-2018 - version " + Compilateur.version + "\r\n" +
																				"\r\n" +
																				"Compile un fichier .b4t en fichier Aseba et le transmet au robot Thymio II.\r\n" +
																				"Blockly4Thymio utilise le programme asebahttp pour le transfert du fichier Aseba vers le robot Thymio.\r\n" +
																				"\r\n";
				return	texte;
			case (int)TYPE.BLOC_NON_TRAITÉ_DANS_CETTE_VERSION :			return	"Erreur ! Le bloc {0} n'est pas traité dans cette version du compilateur.";
			case (int)TYPE.LA_VERSION_APPROPRIÉE_POUR_CE_BLOC :			return	"\nLa version du compilateur la plus appropiée pour ce bloc est la version {0}";
			case (int)TYPE.CHRONOMÈTRE_INFÉRIEUR_À_1_SECONDE :			return	"Le temps du chronomètre le plus petit est de 1 seconde.";
			case (int)TYPE.CHRONOMÈTRE_SUPÉRIEUR_À_6_SECONDES :			return	"Le temps du chronomètre le plus grand est de 6 secondes.";
			case (int)TYPE.VARIABLE_NON_INITIALISÉE :					return	"La variable {0} n'est pas initialisée.";

			}
			break;

		}

		throw new Exception( "Le message " + _numéro + " n'existe pas dans la liste des  messages." );

	}


}
}

