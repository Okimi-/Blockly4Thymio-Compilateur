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

Copyright Okimi 2018 (contact at okimi dot net)

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
using	System.IO;
using	System.Reflection;
using	System.Windows.Forms;



namespace 		Blockly4Thymio {
static	class 	ProgrammePrincipal {

	/// <summary>
	/// Point d'entrée principal de l'application.
	/// </summary>
	[STAThread]
	static void Main( string[] _args ) {

		// Initialisations
		// ---------------

		Compilateur.version = "1.3";


		#if (WINDOWS && NOT_NET_30)
		#error La compilation sous Windows doit être réalisée pour le framework .NET 3.0. Modifiez dans les options du projet, rubrique Construire->Général->Target framework = Mono / .NET 3.0
		#endif
		#if (LINUX && NOT_NET_45)
		#error La compilation sous Linux doit être réalisée pour le framework .NET 4.5. Modifiez dans les options du projet, rubrique Construire->Général->Target framework = Mono / .NET 4.5
		#endif

		// Nom du fichier programme.b4t à tester
		// -------------------------------------
		#if (DEBUG && WINDOWS)
		Compilateur.nomDuFichierB4T = @"C:\Users\Okimi\Downloads\programme.b4t";
		#endif
		#if (DEBUG && LINUX)
		Compilateur.nomDuFichierB4T = @"/home/okimi/Téléchargements/programme.b4t";
		#endif
		#if (!DEBUG)
		Compilateur.nomDuFichierB4T = "";
		if ( _args != null )
			if ( _args.Length != 0 )
				Compilateur.nomDuFichierB4T = _args[0];
		#endif


		// Affichage des commentaires dans le fichier .aesl
		// ------------------------------------------------
		#if (DEBUG)
		Compilateur.afficherLesCommentaires = true;
		#else
		Compilateur.afficherLesCommentaires = false;
		#endif
		
		
		// Affiche les messages d'information
		#if (DEBUG)
		Compilateur.afficheLesMessagesDInformation = true;
		#else
		Compilateur.afficheLesMessagesDInformation = false;
		#endif


		// Affichage des messages d'erreur
		// -------------------------------
		Compilateur.afficheLesMessagesDErreur = true;


		// Arrête le robot si tous les séquenceurs sont terminés
		// -----------------------------------------------------
		Compilateur.arrêtDuRobotALaFinDesSéquenceurs = true;


		// Optimisation du code Aseba généré
		// ---------------------------------
		#if (DEBUG)
		Compilateur.optimisationDuSéquenceur = true;
		//Compilateur.optimisationDuSéquenceur = false;
		#else
		Compilateur.optimisationDuSéquenceur = true;
		#endif
		

		// Transfert le fichier .aesl via asebamassloader.exe
		// --------------------------------------------------
		#if (DEBUG)
		Compilateur.transfertDuFichierAESL = true;
		//Compilateur.transfertDuFichierAESL = false;
		#endif
		#if (!DEBUG)
		Compilateur.transfertDuFichierAESL = true;
		#endif


		// Emplacement de programme de transfert asebahttp.exe
		// ---------------------------------------------------
		#if (DEBUG && WINDOWS)
		Compilateur.nomDuFichierASEBAHTTP = @"C:\Blockly4Thymio.v1.2\asebahttp\asebahttp.exe";
		#endif
		#if (!DEBUG && WINDOWS)
		Compilateur.nomDuFichierASEBAHTTP =  Path.GetDirectoryName(Application.ExecutablePath) + @"\asebahttp\asebahttp.exe";
		#endif
		#if (LINUX)
		Compilateur.nomDuFichierASEBAHTTP = @"/usr/bin/blockly4thymio-asebahttp";
		#endif
		

		// Lance automatiquement le programme sur le Thymio à la fin du transfert
		// ----------------------------------------------------------------------
		Compilateur.lancementAutomatique = true;


		// Fermeture automatique de la fenêtre à la fin des traitements
		// ------------------------------------------------------------
		#if (DEBUG)		
		Compilateur.fermetureDeLaFenêtreALaFin = true;
		//Compilateur.fermetureDeLaFenêtreALaFin = false;
		#endif
		#if (!DEBUG)
		Compilateur.fermetureDeLaFenêtreALaFin = true;
		#endif


		// Traitements
		// -----------

		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run( new FEN_Principale( _args ) );

	}

}
}


