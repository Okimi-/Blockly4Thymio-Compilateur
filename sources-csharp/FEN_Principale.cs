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



// Désactive les messages sur les variables unitilisées
#pragma warning disable 0414



using System;
using	System.Drawing;
using	System.Reflection;
using	System.Windows.Forms;



namespace	Blockly4Thymio {
public		partial	class	FEN_Principale : Form {

	// Déclarations
	// ------------

	static	Timer	temporisationDAttente;
	static	Timer	temporisationDeCompilation;

	string[] args;
	

	// Constructeur de la fenêtre
    // --------------------------
	public FEN_Principale( string[] _args ) {
		args = _args;
		InitializeComponent();
		this.Text = this.Text.Replace( "<VERSION>", Compilateur.version );	
	}
	
	
	public	void	AjouteUnMessage( String _texte ) {
		TEXT_Messages.Text += _texte + "\n";
		TEXT_Messages.Refresh();
	}
	
	
	public	void	EffaceLesMessages() {
		TEXT_Messages.Text = "";
		TEXT_Messages.Refresh();
	}
	
	/// <summary>
	/// Evénement déclenché à l'initialisation de la fenêtre principale
	/// </summary>
	private	void FEN_Principale_Load( object sender, EventArgs e ) {

		// Astucce pas très propre pour lancer la compilation dans un autre thread
		temporisationDeCompilation = new Timer();
		temporisationDeCompilation.Interval = 500;
		temporisationDeCompilation.Tick+= new EventHandler( ThreadDeCompilation );
		temporisationDeCompilation.Start();

	}


	/// <summary>
	/// Thread séparé pour la compilation
	/// </summary>
	private	void	ThreadDeCompilation( object _sender, EventArgs _e ) {

		temporisationDeCompilation.Stop();

		// Affiche l'aide si aucun fichier .b4t n'est envoyé
		if ( Compilateur.nomDuFichierB4T == "" ) {
			Compilateur.AfficheLAide(this.TEXT_Messages);
			return;
		}

		// Affiche le texte d'entête
		Compilateur.AfficheLEntête(this.TEXT_Messages);

		// Affiche le nom du fichier
		AjouteUnMessage( String.Format( Messages.Message( (int)Messages.TYPE.FICHIER ), Compilateur.nomDuFichierB4T  ) + "\n" );

	
		// Lance la compilation.
		// Si la compilation s'est bien déroulée, le programme se ferme automatiquement
		if (Compilateur.Compile(this)) {
			// Message : Transfert terminé
			AjouteUnMessage( "\n" + Messages.Message( (int)Messages.TYPE.COMPILATION_ET_TRANSFERT_TERMINÉ ) );
			if (Compilateur.fermetureDeLaFenêtreALaFin) {
				#if (DEBUG)
				Application.Exit();
				#else
				FermeLaFenêtreAprès2Secondes();
				#endif
			}
		}

	}


	private	void	FermeLaFenêtreAprès2Secondes() {
		temporisationDAttente = new Timer();
		temporisationDAttente.Interval = 2000;
		temporisationDAttente.Tick+= new EventHandler( Evénement_FermeLaFenêtreAprès2Secondes );
		temporisationDAttente.Start();
	}


	private	void	Evénement_FermeLaFenêtreAprès2Secondes( object sender, EventArgs e  ) {
		temporisationDAttente.Stop();
		Application.Exit();
	}


	public	void	AfficheUnMessageDErreur( String _message ) {
		EffaceLesMessages();
		this.BackColor = Color.Red;
		this.TEXT_Messages.BackColor = Color.Red;
		AjouteUnMessage( "\n" + _message + "\n\n" );		
	}

	public	void	AfficheUnMessageDInformation( String _message ) {
		EffaceLesMessages();
		this.BackColor = Color.DarkOrange;
		this.TEXT_Messages.BackColor = Color.DarkOrange;
		AjouteUnMessage( "\n" + _message + "\n\n" );
	}


}
}


