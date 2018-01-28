
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
 * Classe __SONS
 * -------------
 *
 * Pour la déclaration des constantes
 * et des fonctions des sons
 *
 */


using 	System;



public 		class 	__SONS {

	/*
	 * Constantes
	 */

	public enum DUREE {
		AUCUNE = 0,
		CROCHE,
		NOIRE,
		BLANCHE
	}

	public enum NOTES {
		AUCUNE	= 0,
		DO_3,
		DO_3_DIÈSE,
		RÉ_3,
		RÉ_3_DIÈSE,
		MI_3,
		FA_3,
		FA_3_DIÈSE,
		SOL_3,
		SOL_3_DIÈSE,
		LA_3,
		LA_3_DIÈSE,
		SI_3,
		DO_4,
		DO_4_DIÈSE,
		RÉ_4,
		RÉ_4_DIÈSE,
		MI_4,
		FA_4,
		FA_4_DIÈSE,
		SOL_4,
		SOL_4_DIÈSE,
		LA_4,
		LA_4_DIÈSE,
		SI_4
	}

    public enum SON {
        PAS_DE_SON			=  -1,
        BONJOUR				=   0,
        HO					=   1,
        QUOI				=   2,
        JE_SUIS_PAS_CONTENT	=   3,

        SIRÈNE_DES_POMPIERS	= 100,

		PERSONNEL_01		= 1001,
		PERSONNEL_02		= 1002,
		PERSONNEL_03		= 1003,
		PERSONNEL_04		= 1004,
		PERSONNEL_05		= 1005,
        PERSONNEL_06		= 1006,
		PERSONNEL_07		= 1007,
		PERSONNEL_08		= 1008,
		PERSONNEL_09		= 1009,
		PERSONNEL_10		= 1010,

		DEPUIS_LE_MICROPHONE= 9999
    }

    public enum INSTRUMENTS {
    	PIANO	= 1,
    	BANJO,
		VIBRAPHONE,
		TROMPETTE,
    	PERCUSSIONS
	}

	/*
	 * Méthodes statiques
	 */
	/// <summary>
	/// Calcul la fréquence (en hertz) d'une note.
	/// Fréquences des notes sur : https://fr.wikipedia.org/wiki/Note_de_musique#Degr.C3.A9_et_.C3.A9chelles_musicales
	/// </summary>
	/// <param name="_note"></param>
	/// <returns></returns>
	public	static	int		CalculLaFréquenceDUneNote( int _note ) {

		// Déclarations
		int	fréquence;


		// Initialisations
		fréquence = 0;


		// Traitements
		switch( _note ) {
		case (int)NOTES.DO_3 :			fréquence = 262; break;
		case (int)NOTES.DO_3_DIÈSE :	fréquence = 279; break;
		case (int)NOTES.RÉ_3 :			fréquence = 294; break;
		case (int)NOTES.RÉ_3_DIÈSE :	fréquence = 303; break;		// 302:RE, 304:MI3
		case (int)NOTES.MI_3 :			fréquence = 329; break;
		case (int)NOTES.FA_3 :			fréquence = 349; break;
		case (int)NOTES.FA_3_DIÈSE :	fréquence = 370; break;
		case (int)NOTES.SOL_3 :			fréquence = 399; break;
		case (int)NOTES.SOL_3_DIÈSE :	fréquence = 407; break;
		case (int)NOTES.LA_3 :			fréquence = 440; break;
		case (int)NOTES.LA_3_DIÈSE :	fréquence = 466; break;
		case (int)NOTES.SI_3 :			fréquence = 494; break;
		case (int)NOTES.DO_4 :			fréquence = 522; break;		// 523->522, note corrigée le 08.02.16
		case (int)NOTES.DO_4_DIÈSE :	fréquence = 554; break;
		case (int)NOTES.RÉ_4 :			fréquence = 586; break;		// 587->586, note corrigée le 08.02.16 
		case (int)NOTES.RÉ_4_DIÈSE :	fréquence = 622; break;
		case (int)NOTES.MI_4 :			fréquence = 659; break;
		case (int)NOTES.FA_4 :			fréquence = 697; break;		// 698->697, note corrigée le 15.01.17
		case (int)NOTES.FA_4_DIÈSE :	fréquence = 740; break;
		case (int)NOTES.SOL_4 :			fréquence = 784; break;
		case (int)NOTES.SOL_4_DIÈSE :	fréquence = 831; break;
		case (int)NOTES.LA_4 :			fréquence = 880; break;
		case (int)NOTES.LA_4_DIÈSE :	fréquence = 932; break;
		case (int)NOTES.SI_4 :			fréquence = 988; break;
		}


		// Fin
		return fréquence;

	}


	/// <summary>
	/// Calcul la durée (en seconde) d'une note
	/// </summary>
	/// <param name="_note"></param>
	/// <returns></returns>
	public	static	float	CalculLaDuréeDUneNote( int _note )
	{

		// Déclarations
		float durée;


		// Initialisations
		durée = 0;


		// Traitements
		switch( _note ) {
		case (int)DUREE.CROCHE :	durée = 0.25f; break;
		case (int)DUREE.NOIRE :		durée = 0.50f; break;
		case (int)DUREE.BLANCHE :	durée = 1.00f; break;
		}


		// Fin
		return durée;

	}


	public	static	int		CalculLeNomDuSon( int _instrument, int _note, int _durée )	{

		int	son = 0;

		// Détermine la note
		switch ( _note ) {
		case (int)__SONS.NOTES.DO_3:				son =  1;	break;
		case (int)__SONS.NOTES.DO_3_DIÈSE:			son =  2;	break;
		case (int)__SONS.NOTES.RÉ_3:				son =  3;	break;
		case (int)__SONS.NOTES.RÉ_3_DIÈSE:			son =  4;	break;
		case (int)__SONS.NOTES.MI_3:				son =  5;	break;
		case (int)__SONS.NOTES.FA_3:				son =  6;	break;
		case (int)__SONS.NOTES.FA_3_DIÈSE:			son =  7;	break;
		case (int)__SONS.NOTES.SOL_3:				son =  8;	break;
		case (int)__SONS.NOTES.SOL_3_DIÈSE:			son =  9;	break;
		case (int)__SONS.NOTES.LA_3:				son = 10;	break;
		case (int)__SONS.NOTES.LA_3_DIÈSE:			son = 11;	break;
		case (int)__SONS.NOTES.SI_3:				son = 12;	break;
		case (int)__SONS.NOTES.DO_4:				son = 13;	break;
		case (int)__SONS.NOTES.DO_4_DIÈSE:			son = 14;	break;
		case (int)__SONS.NOTES.RÉ_4:				son = 15;	break;
		case (int)__SONS.NOTES.RÉ_4_DIÈSE:			son = 16;	break;
		case (int)__SONS.NOTES.MI_4:				son = 17;	break;
		case (int)__SONS.NOTES.FA_4:				son = 18;	break;
		case (int)__SONS.NOTES.FA_4_DIÈSE:			son = 19;	break;
		case (int)__SONS.NOTES.SOL_4:				son = 20;	break;
		case (int)__SONS.NOTES.SOL_4_DIÈSE:			son = 21;	break;
		case (int)__SONS.NOTES.LA_4:				son = 22;	break;
		case (int)__SONS.NOTES.LA_4_DIÈSE:			son = 23;	break;
		case (int)__SONS.NOTES.SI_4:				son = 24;	break;
		}

		// Détermine la durée
		switch ( _durée ) {
		case (int)__SONS.DUREE.CROCHE:				son +=  0;	break;
		case (int)__SONS.DUREE.NOIRE:				son += 40;	break;
		case (int)__SONS.DUREE.BLANCHE:				son += 80;	break;
		}

		// Détermine l'instrument
		switch ( _instrument ) {
		case (int)__SONS.INSTRUMENTS.PIANO:			son += 2000;	break;
		case (int)__SONS.INSTRUMENTS.BANJO:			son += 3000;	break;
		case (int)__SONS.INSTRUMENTS.VIBRAPHONE:	son += 4000;	break;
		case (int)__SONS.INSTRUMENTS.PERCUSSIONS:	son += 5000;	break;
		case (int)__SONS.INSTRUMENTS.TROMPETTE:		son += 6000;	break;
		}

		return son;

	}

}

