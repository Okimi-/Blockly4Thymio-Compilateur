
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



/*
 * Classe CAPTEURS
 * ----------
 *
 * Pour la déclaration des constantes
 * et des fonctions des CAPTEURS
 *
 */


using System;


namespace	Blockly4Thymio {
public 		class 	__CAPTEURS {

	/*
	 * Constantes
	 */

	// Valeurs des distances
	const	int		DISTANCE_LOIN	= 0;
	const	int		DISTANCE_PRÈS	= 1000;

	const	String	SOL_LIMITE_BASSE= ">10";		// Limite basse de déclenchement pour les capteurs de sol
	const	String	SOL_NOIR		= "<=450";
	const	String	SOL_BLANC		= ">450";

	public	enum PARAMÈTRE {
		// Enumération des distances detectées par les capteurs de proximité avants et arrières.	
		DISTANCE_LOIN,
		DISTANCE_PRÈS,
		// Enumération des couleurs vues par les capteurs du dessous.
		COULEUR_SOL_BLANC,
		COULEUR_SOL_NOIR
	}
	


	// Capteurs de proximité.
	// Capteurs de luminosité du sol
	// Capteur infra-rouge de la télécommande
	public	enum NOM {
		AVANT_AUCUN,			//  .....
		AVANT_GAUCHE,			//  *....
		AVANT_MILIEU_GAUCHE,	//  .*...
		AVANT_MILIEU,			//  ..*..
		AVANT_MILIEU_DROITE,	//  ...*.
		AVANT_DROITE,			//  ....*
		AVANT_AU_MOINS_UN,		// [*****]
		ARRIÈRE_AUCUN,			//    ..
		ARRIÈRE_GAUCHE,			//    *.
		ARRIÈRE_DROITE,			//    .*
		ARRIÈRE_AU_MOINS_UN,	//   [**]
		DESSOUS_GAUCHE,
		DESSOUS_DROITE,
		TEMPERATURE,
		IR
	}
	

	/*
	 * Méthodes statiques
	 */

	public	static	String	code( int _capteur, int _paramètre ) {

		// Déclarations
		// ------------

		String	code;
		String	condition;



		// Initialisations
		// ---------------
		code = "";
		condition = "";



		// Traitements
		// -----------
		switch( _paramètre ) {
		case (int)PARAMÈTRE.DISTANCE_LOIN :
			condition = "==" + DISTANCE_PRÈS;
			break;
		case (int)PARAMÈTRE.DISTANCE_PRÈS :
			condition = ">" + DISTANCE_LOIN;
			break;
		case (int)PARAMÈTRE.COULEUR_SOL_BLANC :
			condition = SOL_BLANC;
			break;
		case (int)PARAMÈTRE.COULEUR_SOL_NOIR :
			condition = SOL_NOIR;
			break;
		}

		
		switch( _capteur ) {

		// Capteurs de proximité
		// ---------------------
		case (int)NOM.AVANT_AUCUN :
			code = "not (prox.horizontal[0]" + condition + " and prox.horizontal[1]" + condition + " and prox.horizontal[2]" + condition + " and prox.horizontal[3]" + condition + " and prox.horizontal[4]" + condition + ")";
			break;
		case (int)NOM.AVANT_GAUCHE :
			code = "prox.horizontal[0]" + condition;
			break;
		case (int)NOM.AVANT_MILIEU_GAUCHE :
			code = "prox.horizontal[1]" + condition;
			break;
		case (int)NOM.AVANT_MILIEU :
			code = "prox.horizontal[2]" + condition;
			break;
		case (int)NOM.AVANT_MILIEU_DROITE :
			code = "prox.horizontal[3]" + condition;
			break;
		case (int)NOM.AVANT_DROITE :
			code = "prox.horizontal[4]" + condition;
			break;
		case (int)NOM.AVANT_AU_MOINS_UN :
			code = "prox.horizontal[0]" + condition + " or prox.horizontal[1]" + condition + " or prox.horizontal[2]" + condition + " or prox.horizontal[3]" + condition + " or prox.horizontal[4]" + condition;
			break;
		case (int)NOM.ARRIÈRE_AUCUN :
			code = "not (prox.horizontal[5]" + condition + " or prox.horizontal[6]" + condition + ")";
			break;
		case (int)NOM.ARRIÈRE_GAUCHE :
			code = "prox.horizontal[5]" + condition;
			break;
		case (int)NOM.ARRIÈRE_DROITE :
			code = "prox.horizontal[6]" + condition;
			break;
		case (int)NOM.ARRIÈRE_AU_MOINS_UN :
			code = "prox.horizontal[5]" + condition + " or prox.horizontal[6]" + condition;
			break;
					
		// Capteurs de couleur du sol
		// --------------------------
		case (int)NOM.DESSOUS_GAUCHE :
			code = "prox.ground.delta[0]" + condition + " and prox.ground.delta[0]" + SOL_LIMITE_BASSE;
			break;
		case (int)NOM.DESSOUS_DROITE :
			code = "prox.ground.delta[1]" + condition + " and prox.ground.delta[1]" + SOL_LIMITE_BASSE;
			break;


		// Capteur de température
		// ----------------------
		case (int)NOM.TEMPERATURE :
			code = "temperature*10";	// La température est exprimée en °C (le capteur lit en dixième de °C)
			break;


		// Capteur IR de la télécommande
		// -----------------------------
		case (int)NOM.IR :
			code = "temperature*10";	// La température est exprimée en °C (le capteur lit en dixième de °C)
			break;

		}

		// Fin
		// ---
		return code;

	}

}
}

