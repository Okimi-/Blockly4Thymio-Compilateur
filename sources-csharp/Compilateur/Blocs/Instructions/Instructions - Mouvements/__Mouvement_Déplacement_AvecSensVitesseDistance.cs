
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
 * __Mouvement_Déplacement_AvecDistance
 * ------------------------------------
 *
 * Fais se déplacer le robot,
 * du nombre de centimètre demandé.
 * 
 */


using 	System;
using 	System.IO;
using 	System.Collections.Generic;
using 	System.Xml;



namespace 		Blockly4Thymio {
public class 	__Mouvement_Déplacement_Avec_Sens_Vitesse_Distance : __Bloc {

	/*
	 * Membres
	 */
	private		int	__distance;   		// Distance en centimètres
    
	protected	int	__vitesse;    		// Vitesse de déplacement
    protected	int	__sens;       		// Sens de déplacement



	/*
	 * Propriétés
     */
	public	int		distance {
	get { return __distance; }
	set {
		__distance = value;
		if ( __distance < 1 ) {
			__distance = 1;
			Compilateur.AfficheUnMessageDInformation( Messages.Message((int)Messages.TYPE.DISTANCE_INFÉRIEURE_A_1) );
		}
		if ( __distance > 100 ) {
			__distance = 100;
			Compilateur.AfficheUnMessageDInformation( Messages.Message((int)Messages.TYPE.DURÉE_SUPÉRIEURE_A_60) );
		}
	}
	}



	/*
	 * Constructeur
	 */
	public	__Mouvement_Déplacement_Avec_Sens_Vitesse_Distance( int _UID, XmlNode _XMLDuBloc, __Bloc _blocPrécédent, __GroupeDeBlocs _groupeDeBlocs, int _sens, int _vitesse, int _distance ) : base( _UID, _XMLDuBloc, _blocPrécédent, _groupeDeBlocs ) {

		// Initialisation des membres
		// --------------------------

		__sens = _sens;
		__vitesse = __MOTEUR.contrôleDeLaVitesse( _vitesse );

		__distance = _distance;


		// Liste les séquences du bloc
		// ---------------------------
		__séquences.Add( (Séquence)Séquence_1 );
		__séquences.Add( (Séquence)Séquence_2 );

	}



	/*
	 * Séquences
	 */

	// Séquence 1
	// - Initialise le chrono à 0
	// - Allume les lumières
	public	String	Séquence_1() {

		String	code = "";
		
		
		code +=		"  if __sequenceur[" + UIDDuSéquenceur + "]==" + Compilateur.ComplèteÀZéro(UID) + " then\n";
		
        switch ( __sens ) {
        case (int)__MOTEUR.SENS.EN_AVANT:
            code +=	"    motor.left.target=" + __vitesse + " motor.right.target=" + __vitesse + "\n";
            break;
        case (int)__MOTEUR.SENS.EN_ARRIERE:
            code +=	"    motor.left.target=-" + __vitesse + " motor.right.target=-" + __vitesse + "\n";
            break;
        }
		
		code +=		"    __sequenceur[" + UIDDuSéquenceur + "]=" + Compilateur.ComplèteÀZéro(UID + 1) + "\n" +
					"  end";
		
		return code;
		
	}


	// Séquence 2
	// - Incrémente le chrono
	// - Test la fin du chrono
	//     - Si le chrono est écoulé, éteins les lumières et passe au bloc suivant
	public	String	Séquence_2() {
		
		int		correctionDeCalibration = 0;
		
		String	code = "";
		
		

	if (__vitesse==(int)__MOTEUR.VITESSE.LENTE)
			correctionDeCalibration = 7;
		
		code +=		"  if __sequenceur[" + UIDDuSéquenceur + "]==" + Compilateur.ComplèteÀZéro(UID + 1) + " then\n";

        switch (__sens) {
        case (int)__MOTEUR.SENS.EN_AVANT :
			code +=	"    if __odo.x>" + ( __distance * ( __MOTEUR.calibration - correctionDeCalibration) ) + " then\n";
            break;
        case (int)__MOTEUR.SENS.EN_ARRIERE :
			code += "    if __odo.x<-" + ( __distance * ( __MOTEUR.calibration - correctionDeCalibration) ) + " then\n";
            break;
		}

		code +=		"      callsub __ArreteLesMoteurs\n" +
					"      __sequenceur[" + UIDDuSéquenceur + "]=" + Compilateur.ComplèteÀZéro(UIDDuBlocSuivant) + "\n" +
					"    end\n" +
					"  end";
		
		return code;

	}


}
}


