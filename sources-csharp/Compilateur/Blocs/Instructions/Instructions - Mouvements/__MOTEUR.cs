
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
 * Classe __MOTEUR
 * ---------------
 *
 * Pour la déclaration des constantes.
 *
 */


using 	System;



public 		class 	__MOTEUR {

    /*
	 * Constantes
	 */

    // Côté
	public enum TOURNE {
    	PAS = 0,
		A_GAUCHE,
		A_DROITE
	}

    // Sens
	public enum SENS {
    	AUCUN = 0,
		ARRÊT,
		EN_AVANT,
		EN_ARRIERE,
		LIBRE
	}

	// Vitesses
	public enum VITESSE {
		NULLE	=   0,
		LENTE	=  50,
		NORMALE	= 250,
		RAPIDE	= 350
	}



	/*
	 * Propriétés statiques
	 */
	// Valeur de calibration pour le parcours d'une distance. Sur le Thymio d'Okimi, les valeurs relevée
	// 59 en vitesse normale (soit target=250)
    // 52 en vitesse lente (soit target=50)
    // 59 en vitesse rapide (soit target=350)
	public	static	int	calibration = 50;



	/*
	 * Méthodes statiques
	 */
	
	public	static	String	code( int _sens, int _vitesseAGauche = 0, int _vitesseADroite = 0 ) {

		// Déclarations
		// ------------
		String	code;


		// Initialisations
		// ---------------
		code = "";


		// Contrôles
		// ---------
		_vitesseADroite = contrôleDeLaVitesse( _vitesseADroite );
		_vitesseAGauche = contrôleDeLaVitesse( _vitesseAGauche );


		// Traitements
		// -----------
		switch( _sens ) {
		case (int)SENS.EN_AVANT :
			code = "motor.left.target=" + _vitesseAGauche + " motor.right.target=" + _vitesseAGauche;
			break;
		case (int)SENS.EN_ARRIERE :
			code = "motor.left.target=-" + _vitesseAGauche + " motor.right.target=-" + _vitesseAGauche;
			break;
		case (int)SENS.LIBRE :
			code = "motor.left.target=" + _vitesseAGauche + " motor.right.target=" + _vitesseADroite;
			break;
		case (int)SENS.ARRÊT :
			code = "callsub __ArreteLesMoteurs";
			break;
		}


		// Fin
		// ---
		return code;

	}

	public	static	int		contrôleDeLaVitesse( int _vitesse ) {
		if ( _vitesse < -500 ) _vitesse = -500;
		if ( _vitesse >  500 ) _vitesse =  500;
		return _vitesse;
	}

}

