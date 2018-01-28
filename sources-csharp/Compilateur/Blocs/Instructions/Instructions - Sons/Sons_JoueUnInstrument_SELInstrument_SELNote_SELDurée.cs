
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
 * Sons_JoueUnInstrument_SELInstrument_SELNote_SELDurée
 * ----------------------------------------------------
 *
 * Joue un instrument.
 *
 */



using System;
using 	System.IO;
using 	System.Collections.Generic;
using 	System.Xml;



namespace 		Blockly4Thymio {
public class 	Sons_JoueUnInstrument_SELInstrument_SELNote_SELDurée : __Sons_JoueUnSon_AvecSon {


	/*
	 * Constructeur
	 */
	public	Sons_JoueUnInstrument_SELInstrument_SELNote_SELDurée( int _UID, XmlNode _XMLDuBloc, __Bloc _blocPrécédent, __GroupeDeBlocs _groupeDeBlocs, int __instrument = 0 ) : base( _UID, _XMLDuBloc, _blocPrécédent, _groupeDeBlocs, (int)__SONS.SON.PAS_DE_SON ) {
    
		// Déclarations
		// ------------
		int		durée;
		int		instrument;
		int		note;

        String	nomDeLAttribut;


		// Initialisations
        // ---------------
        __commentaire = "";
        durée = 0;
        instrument = __instrument;
        note = 0;


        // Traitements
        // -----------

        // Analyse du Block d'instruction
        foreach (XmlNode XMLDUnNoeudFils in _XMLDuBloc.ChildNodes) {

            nomDeLAttribut = "";
            if (XMLDUnNoeudFils.Attributes["name"] != null)
                nomDeLAttribut = XMLDUnNoeudFils.Attributes["name"].Value;

            switch (nomDeLAttribut) {

            case "Durée" :

				switch (XMLDUnNoeudFils.InnerText) {
				case "CROCHE":	durée = (int)__SONS.DUREE.CROCHE;	__commentaire += "CROCHE ";		break;
				case "NOIRE":	durée = (int)__SONS.DUREE.NOIRE;	__commentaire += "NOIRE ";		break;
				case "BLANCHE":	durée = (int)__SONS.DUREE.BLANCHE;	__commentaire += "BLANCHE ";	break;
            	}
            	break;


			case "Instrument" :
				switch (XMLDUnNoeudFils.InnerText) {
				case "PIANO":		instrument = (int)__SONS.INSTRUMENTS.PIANO;			__commentaire += "PIANO ";		break;
				case "BANJO":		instrument = (int)__SONS.INSTRUMENTS.BANJO;			__commentaire += "BANJO ";		break;
				case "VIBRAPHONE":	instrument = (int)__SONS.INSTRUMENTS.VIBRAPHONE;	__commentaire += "VIBRAPHONE ";	break;
				case "TROMPETTE":	instrument = (int)__SONS.INSTRUMENTS.TROMPETTE;		__commentaire += "TROMPETTE ";	break;
				}
				break;


            case "Note" :

                switch (XMLDUnNoeudFils.InnerText) {
				case "DO3":			note = (int)__SONS.NOTES.DO_3;			__commentaire += "Do3 ";	break;
				case "DO3DIESE":	note = (int)__SONS.NOTES.DO_3_DIÈSE;	__commentaire += "Do#3 ";	break;
				case "RE3":			note = (int)__SONS.NOTES.RÉ_3;			__commentaire += "Ré3 ";	break;
				case "RE3DIESE":	note = (int)__SONS.NOTES.RÉ_3_DIÈSE;	__commentaire += "Ré#3 ";	break;
				case "MI3":			note = (int)__SONS.NOTES.MI_3;			__commentaire += "Mi3 ";	break;
				case "FA3":			note = (int)__SONS.NOTES.FA_3;			__commentaire += "Fa3 ";	break;
				case "FA3DIESE":	note = (int)__SONS.NOTES.FA_3_DIÈSE;	__commentaire += "Fa#3 ";	break;
				case "SOL3":		note = (int)__SONS.NOTES.SOL_3;			__commentaire += "Sol3 ";	break;
				case "SOL3DIESE":	note = (int)__SONS.NOTES.SOL_3_DIÈSE;	__commentaire += "Sol#3 ";	break;
				case "LA3":			note = (int)__SONS.NOTES.LA_3;			__commentaire += "La3 ";	break;
				case "LA3DIESE":	note = (int)__SONS.NOTES.LA_3_DIÈSE;	__commentaire += "La#3 ";	break;
				case "SI3":			note = (int)__SONS.NOTES.SI_3;			__commentaire += "Si3 ";	break;
				case "DO4":			note = (int)__SONS.NOTES.DO_4;			__commentaire += "Do4 ";	break;
				case "DO4DIESE":	note = (int)__SONS.NOTES.DO_4_DIÈSE;	__commentaire += "Do#4 ";	break;
				case "RE4":			note = (int)__SONS.NOTES.RÉ_4;			__commentaire += "Ré4 ";	break;
				case "RE4DIESE":	note = (int)__SONS.NOTES.RÉ_4_DIÈSE;	__commentaire += "Ré4# ";	break;
				case "MI4":			note = (int)__SONS.NOTES.MI_4;			__commentaire += "Mi4 ";	break;
				case "FA4":			note = (int)__SONS.NOTES.FA_4;			__commentaire += "Fa4 ";	break;
				case "FA4DIESE":	note = (int)__SONS.NOTES.FA_4_DIÈSE;	__commentaire += "Fa#4 ";	break;
				case "SOL4":		note = (int)__SONS.NOTES.SOL_4;			__commentaire += "Sol4 ";	break;
				case "SOL4DIESE":	note = (int)__SONS.NOTES.SOL_4_DIÈSE;	__commentaire += "Sol#4 ";	break;
				case "LA4":			note = (int)__SONS.NOTES.LA_4;			__commentaire += "La4 ";	break;
				case "LA4DIESE":	note = (int)__SONS.NOTES.LA_4_DIÈSE;	__commentaire += "La#4 ";	break;
				case "SI4":			note = (int)__SONS.NOTES.SI_4;			__commentaire += "Si# ";	break;				
				}
                break;

            }

        }

        __commentaire = __commentaire.Trim();
        __son = __SONS.CalculLeNomDuSon( instrument, note, durée );

	}



}
}


