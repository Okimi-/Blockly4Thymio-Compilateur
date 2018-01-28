
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



public class FrameworkASEBA {
	
	public static String	version_0_2_1() {
		return @"<!DOCTYPE aesl-source>
<network>


<!--list of global events--> 


<!--list of constants-->
<constant value=""0"" name=""ETAT_ARRET""/>
<constant value=""1"" name=""ETAT_EN_MARCHE""/>
<constant value=""2500"" name=""COEUR_QUI_BAT""/>
<constant value=""10"" name=""FREQUENCE_TIMER""/>


<!--show keywords state-->
<keywords flag=""false""/>


<!--node thymio-II-->
<node nodeId=""1"" name=""thymio-II"">


#    ___  __         __    __     ____________              _
#   / _ )/ /__  ____/ /__ / /_ __/ / /_  __/ /  __ ____ _  (_)__
#  / _  / / _ \/ __/  '_// / // /_  _// / / _ \/ // /  ' \/ / _ \
# /____/_/\___/\__/_/\_\/_/\_, / /_/ /_/ /_//_/\_, /_/_/_/_/\___/
#                         /___/               /___/ 
#        Programme AESL pour Thymio II - Version ### VERSION ###
# généré automatiquement par Blockly4THymio www.blockly4thymio.net
#     Blockly4Thymio - © 2018 Okimi (contact at okimi dot net)

# ----------------------------------
# DECLARATION DES VARIABLES GLOBALES
# ----------------------------------

var __chronometre = 1000
var __coeurQuiBat = 0
var __compteur
var __etat
var __lectureDUnSon = 0
var __temp
var __variableAAfficher

# Variable pour les nombres aléatoires
var __nombreAleatoire

# Variables pour les LEDs
var __led.rouge
var __led.vert
var __led.bleu
var __led.cercle[8]

# Variable pour les sons
var __son

# Variables pour l'odométrie
var __odo.degre
var __odo.delta
var __odo.temp
var __odo.theta = 0
var __odo.x = 0			# 500 pour ~100mm (précision à 0,2mm)


### VARIABLES ###


# -----------
# APPLICATION
# -----------
# Efface la précédente commande (éventuellement en mémoire)
rc5.address = 0
rc5.command = 0
# Initialise le(s) séquenceur(s)
### ETAT AU LANCEMENT ###
# Initialise le timer du séquenceur sur 10ms (100Hz)
timer.period[0] = FREQUENCE_TIMER
# Initialise la sensibilité du micro
mic.threshold = 250


# ---------------------------
# DECLARATIONS DES PROCEDURES
# ---------------------------

# Allume les LEDs du cercle
sub __AllumeLeCercleDeLEDs
  call leds.circle(__led.cercle[0],__led.cercle[1],__led.cercle[2],__led.cercle[3],__led.cercle[4],__led.cercle[5],__led.cercle[6],__led.cercle[7])


# Eteins toutes les LEDs du cercle
sub __EteinsLeCercleDeLEDs
  __led.cercle[0]=0
  __led.cercle[1]=0
  __led.cercle[2]=0
  __led.cercle[3]=0
  __led.cercle[4]=0
  __led.cercle[5]=0
  __led.cercle[6]=0
  __led.cercle[7]=0
  callsub __AllumeLeCercleDeLEDs


# Affiche une variable sur le cercle de LEDs
sub __AfficheUneVariable
  callsub __EteinsLeCercleDeLEDs
  if __variableAAfficher>0 and __variableAAfficher&lt;=8 then
    __compteur=0
  	while __compteur&lt;__variableAAfficher do
      __led.cercle[__compteur]=31
      __compteur++
    end
    callsub __AllumeLeCercleDeLEDs
  end


# Allume toutes les LEDs (bottom.left, bottom.right et top)
sub	__AllumeLesLEDs
  call leds.bottom.left( __led.rouge, __led.vert, __led.bleu )
  call leds.bottom.right( __led.rouge, __led.vert, __led.bleu )
  call leds.top( __led.rouge, __led.vert, __led.bleu )


# Arrête les moteurs
sub	__ArreteLesMoteurs
  motor.left.target = 0
  motor.right.target = 0
  __odo.x = 0
  __odo.degre = 0
  __odo.theta = 0


sub __ExecuteLeProgramme
  ### EVENEMENT AU LANCEMENT ###


sub __ArreteLeProgramme
  # Arrête les moteurs
  callsub __ArreteLesMoteurs
  # Eteins toutes les LEDs
  call leds.buttons(0,0,0,0)
  call leds.circle( 0, 0, 0, 0, 0, 0, 0, 0 ) 
  call leds.sound(0)
  call leds.temperature(0,0)
  __led.rouge = 0
  __led.vert = 0
  __led.bleu = 0
  callsub __AllumeLesLEDs
  callsub __EteinsLeCercleDeLEDs


sub __JoueUnSon
  __lectureDUnSon = 1
  call sound.play(__son)


# ----------
# SEQUENCEUR
# ----------

sub __Sequenceur
### SEQUENCEUR ###



# ---------------------------
# DECLARATIONS DES EVENEMENTS
# ---------------------------

onevent timer1
### EVENEMENT CHRONOMETRE ###


onevent buttons
### EVENEMENT BOUTON FLECHE ###


onevent prox
### EVENEMENT CAPTEUR DISTANCE ###


onevent tap
### EVENEMENT CHOC ###


onevent mic
### EVENEMENT SON ###


# Avec le bouton central, l'utilisateur lance ou arrête le programme
# ------------------------------------------------------------------
onevent button.center
  if button.center == 1 then
    # Si le bouton central est appuyé
    if __etat == ETAT_ARRET then
      __etat = ETAT_EN_MARCHE
      # Relance le programme
      callsub __ExecuteLeProgramme
    else
	  timer.period[1]=0					# Arrête le chronomètre (si celui-ci a été lancé)
	  __etat = ETAT_ARRET
    end
  end


# Evénement déclenché par le timer pour le séquenceur
# ---------------------------------------------------
onevent timer0
  if __etat == ETAT_EN_MARCHE then
    # La LED de la flèche avant clignote, le programme s'execute
    __coeurQuiBat+=(COEUR_QUI_BAT/FREQUENCE_TIMER)
    call math.sin(__temp,__coeurQuiBat)
    call leds.buttons( abs(__temp)>>12, 0, 0, 0 )
    # Appel le séquenceur
    callsub __Sequenceur
  else
    # le programme va s'arrêter, la LED de la flèche avant s'éteint
    __coeurQuiBat=0
    # Arrête tous les accurateurs
    callsub __ArreteLeProgramme
  end
  
  
# Evénement déclenché lors de la réception d'une commande
# rc5 de la télécommande infrarouge
# -------------------------------------------------------

onevent rc5
### EVENEMENT COMMANDE INFRAROUGE ###
  
  
# Evénement déclenché à la fin de la lecture d'un fichier son
# -----------------------------------------------------------
onevent	sound.finished
  __lectureDUnSon=0



# Evénement moteur, appelé toutes les 10ms (100Hz)
# ------------------------------------------------
onevent	motor
  # Calcul du déplacement et de la rotation par odométrie.
  # Code basé sur le fichier thymio_motion.aels de David Sherman
  # A lire aussi : https://fr.wikipedia.org/wiki/Odom%C3%A9trie
  if motor.right.target == 0 and motor.left.target == 0 then
	__odo.x = 0
	__odo.degre = 0
	__odo.theta = 0
  else    
    call math.muldiv(__odo.temp, (motor.right.target - motor.left.target), 3406, 10000)		# dΘ = (différence de vitesse des roues * 3406) / 10000
    __odo.theta += __odo.temp																# Θ = Θ+dΘ
    __odo.degre = __odo.theta / 170															# Convertis θ en angle (en degré)
    call math.cos(__odo.temp,__odo.theta)													# = cosΘ
    __odo.delta = (motor.right.target + motor.left.target) / 2								# Δ = moyenne des vitesses des roues
    call math.muldiv(__odo.temp, __odo.delta,__odo.temp, 32767)								# = (Δ*cosΘ ) / PI
    __odo.x += __odo.temp/45
  end

</node>


</network>";

	}


}

