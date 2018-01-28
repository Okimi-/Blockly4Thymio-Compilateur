'use strict'; 

goog.provide('Blockly.Blocks.thymio'); 

goog.require('Blockly.Blocks'); 



Blockly.Blocks['0_1b_Evénement_QuandLeProgrammeCommence'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'C\'est la premier bloc à mettre dans un programme.' ); 
    this.appendDummyInput()
      .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-evenement-quand-le-programme-commence.png", 20, 20, "noire" ));
    this.appendDummyInput().appendField( 'quand le programme commence' );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_2_Evénement_QuandUnBoutonFlècheEstAppuyé'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'Le programme commence lorsque que l\'un des boutons flèche est appuyé.' ); 
    this.appendDummyInput()
      .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-boutons-fleches.png", 20, 20, "noire" ));
    this.appendDummyInput().appendField( 'quand un bouton flèche est appuyé' );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_5_Evénement_QuandUnCapteurAvantVoitUnObstacle'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'Le programme commence lorsque que l\'un des capteurs avant voit un obstacle.' ); 
    this.appendDummyInput()
      .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-avant-tous.png", 20, 20, "noire" ));
    this.appendDummyInput().appendField( 'quand un capteur avant voit un obstacle' );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_5_Evénement_QuandUnCapteurArrièreVoitUnObstacle'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'Le programme commence lorsque que l\'un des capteurs arrière voit un obstacle.' ); 
    this.appendDummyInput()
      .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-arriere-tous.png", 20, 20, "noire" ));
    this.appendDummyInput().appendField( 'quand un capteur arrière voit un obstacle' );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_2_Evénement_QuandUnOrdreArriveDeLaTélécommandeIR'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'Le programme commence lorsque qu\'une touche de la télécommande est appuyée. Pour la télécommande Thymio, canal&#61;0.' ); 
    this.appendDummyInput()
      .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-telecommande.png", 20, 20, "noire" ));
    this.appendDummyInput().appendField( 'quand un bouton de la télécommande est appuyé' );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_9_Evénement_QuandLeChronomètreATerminéDeCompter'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'Le programme commence lorsque que le chronomètre à terminé de compter' ); 
    this.appendDummyInput()
      .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-chronomètre.png", 20, 20, "noire" ));
    this.appendDummyInput().appendField( 'quand le chronomètre a terminé de compter' );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['1_0_Evénement_QuandUnChocEstDétecté'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'Le programme commence lorsque qu\'un choc est détecté' ); 
    this.appendDummyInput()
      .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-evenement-quand-un-choc-est-detecte.png", 20, 20, "noire" ));
    this.appendDummyInput().appendField( 'quand un choc est détecté' );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['1_0_Evénement_QuandUnSonEstDétecté'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'Le programme commence lorsque qu\'un son est détecté' ); 
    this.appendDummyInput()
      .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-evenement-quand-un-son-est-detecte.png", 20, 20, "noire" ));
    this.appendDummyInput().appendField( 'quand un son est détecté' );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_4_Paramètre_CalibreLesMoteurs_SAIValeur'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'La valeur de calibration des moteurs permet d\'ajuster la distance d\'avance demandée avec la distance réellement observée. Cette instruction ne peux être utilisé qu\'une seule fois dans un programme [valeur de 1 à 100].' ); 
    this.appendDummyInput()
        .appendField( "calibre les moteurs avec la valeur" )
        .appendField( new Blockly.FieldNumber(50, 1, 100, 1), "Valeur");
    this.setInputsInline( true );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_5_Paramètre_LAdresseDeLaTélécommandeEst_SAIAdresse'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'L\'adresse de la télécommande IR, permet de défnir quel canal de la télécommande est utilisé [valeur de 0 à 255].' ); 
    this.appendDummyInput()
        .appendField( "définis l'adresse de la télécommande à" )
        .appendField( new Blockly.FieldNumber(0, 0, 255, 1), "Adresse" );
    this.setInputsInline( true );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_9_Paramètre_InitialiseLeChronomètre_SAIValeur'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'Initialise le chronomètre [valeur de 1s à 100s].' ); 
    this.appendDummyInput()
        .appendField( "initialise le chronomètre à " )
        .appendField( new Blockly.FieldNumber(1, 1, 100, 1), "Valeur" )
        .appendField( "seconde(s)" );
    this.setInputsInline( true );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_9_Evénement_DémarrerLeChronomètre'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'Démarrer le chronomètre.' ); 
    this.appendDummyInput()
        .appendField( "démarrer le chronomètre" );
    this.setInputsInline( true );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_9_Evénement_ArrêterLeChronomètre'] = { 
  init: function() { 
    this.setColour( '#ed5565' ); 
    this.setTooltip( 'Arrêter le chronomètre.' ); 
    this.appendDummyInput()
        .appendField( "arrêter le chronomètre" );
    this.setInputsInline( true );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_1b_Mouvement_Avance'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Thymio avance tout droit.' ); 
    this.appendDummyInput().appendField( 'avance' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_1b_Mouvement_Avance_De5Centimètres'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Thymio avance de 5cm.' ); 
    this.appendDummyInput().appendField( 'avance de 5cm' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_1b_Mouvement_Avance_SELVitesse_SAIDistance'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Choisis la vitesse et renseigne le nombre de centimètre que Thymio doit parcourir [valeur de 1cm à 100cm].' ); 
    this.appendDummyInput()
      .appendField( 'avance' )
      .appendField(new Blockly.FieldDropdown(  [  [ "normalement", "NORMALEMENT" ],
                                                                     [ "rapidement", "RAPIDEMENT"],
                                                                     [ "lentement", "LENTEMENT"]  ]), "Vitesse" );
    this.appendDummyInput().appendField( "de" ); 
    this.appendDummyInput().appendField( new Blockly.FieldNumber(1, 1, 100, 1), "Distance" );
    this.appendDummyInput().appendField( "cm" );        
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_1b_Mouvement_Recule'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Thymio recule.' ); 
    this.appendDummyInput().appendField( 'recule' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_1b_Mouvement_Recule_SELVitesse_SAIDistance'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Choisis la vitesse et renseigne le nombre de centimètre que Thymio doit parcourir en reculant [valeur de 1cm à 100cm].' ); 
    this.appendDummyInput()
      .appendField( 'recule' )
      .appendField(new Blockly.FieldDropdown(  [  [ "normalement", "NORMALEMENT" ],
                                                                     [ "rapidement", "RAPIDEMENT"],
                                                                     [ "lentement", "LENTEMENT"]  ]), "Vitesse" );
    this.appendDummyInput().appendField( "de" ); 
    this.appendDummyInput().appendField( new Blockly.FieldNumber(1, 1, 100, 1), "Distance" );
    this.appendDummyInput().appendField( "cm" );        
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_1b_Mouvement_Arrête'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Thymio s\'arrête.' ); 
    this.appendDummyInput().appendField( 'arrête' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_5_Mouvement_TourneADroite'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Thymio tourne vers la droite, de 90°.' ); 
    this.appendDummyInput().appendField( 'tourne à droite ↻' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_5_Mouvement_TourneAGauche'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Thymio tourne vers la gauche, de 90°.' ); 
    this.appendDummyInput().appendField( 'tourne à gauche ↺' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_1b_Mouvement_TourneADroite_SAIAngle'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Thymio tourne vers la droite de l\'angle saisie [valeur de 0° à 360°].' ); 
    this.appendDummyInput().appendField( 'tourne à droite ↻ de' );
    this.appendDummyInput().appendField( new Blockly.FieldNumber(90, 0, 360, 1), "Angle" );
    this.appendDummyInput().appendField( 'degré' );
    this.setInputsInline(true);
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_1b_Mouvement_TourneAGauche_SAIAngle'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Thymio tourne vers la gauche de l\'angle saisie [valeur de 0° à 360°].' ); 
    this.appendDummyInput().appendField( 'tourne à gauche ↺ de' );
    this.appendDummyInput().appendField( new Blockly.FieldNumber(90, 0, 360, 1), "Angle" );
    this.appendDummyInput().appendField( 'degré' );
    this.setInputsInline(true);
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_2_Mouvement_Tourne_SELSens_SAIAngle'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Thymio tourne dans le sens sélectionné avec l\'angle saisie [valeur de 0° à 360°].' ); 
    this.appendDummyInput()
        .appendField( 'tourne à' )
        .appendField(  new Blockly.FieldDropdown(	[	[ "droite ↻", "A_DROITE" ],
            								[ "gauche ↺", "A_GAUCHE"]]), "Sens" );
    this.appendDummyInput().appendField( 'de' );
    this.appendDummyInput().appendField( new Blockly.FieldNumber(0, 0, 360, 1), "Angle" );
    this.appendDummyInput().appendField( 'degré' );
    this.setInputsInline(true);
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_6_Mouvement_VitesseDesRoues_SAIVitesseAGauche_SAIVitesseADroite'] = { 
  init: function() { 
    this.setColour( '#f59c00' ); 
    this.setTooltip( 'Définis la vitesses des roues de Thymio. La vitesse est de -100% [en arrière] à 0% [à l\'arrêt], à 100% [en avant].' ); 
    this.appendDummyInput()
      .appendField( "vitesse des roues. à gauche" )
      .appendField( new Blockly.FieldNumber(100, -100, 100, 1), "VitesseAGauche" )
      .appendField( "%. à droite" )
      .appendField( new Blockly.FieldNumber(100, -100, 100, 1), "VitesseADroite" )
      .appendField( "%." );
    this.setPreviousStatement( true, null );
    this.setNextStatement( true, null );
  } 
}; 

Blockly.Blocks['0_1b_Lumières_AllumeToutesLesLEDs_SELCouleur'] = { 
  init: function() { 
    this.setColour( '#ffce54' ); 
    this.setTooltip( 'Allume toutes les LEDs avec la couleur de ton choix.' ); 
    this.appendDummyInput().appendField( 'allume les lumières avec la couleur' );
    this.appendDummyInput().appendField(new Blockly.FieldColour( "#ff0000"), "Couleur" );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_1b_Lumières_AllumeLesLEDs_SELLED_SELCouleur'] = { 
  init: function() { 
    this.setColour( '#ffce54' ); 
    this.setTooltip( 'Allume toutes les lumières avec la couleur de ton choix.' ); 
    this.appendDummyInput().appendField( "allume" );
    this.appendDummyInput().appendField( new Blockly.FieldDropdown( [   [ "toutes les lumières", "TOUTES_LES_LEDS" ],
                                                                                                       [ "lumières du dessus", "LED_DU_DESSUS" ],
                                                                                                       [ "lumières de gauche", "LED_DE_GAUCHE" ],
                                                                                                       [ "lumières de droite", "LED_DE_DROITE" ]]), "LED" );
    this.appendDummyInput().appendField( "couleur" );
    this.appendDummyInput().appendField( new Blockly.FieldColour("#ff0000"), "Couleur" );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_1b_Lumières_AllumeToutesLesLEDsPendant1Seconde_SELCouleur'] = { 
  init: function() { 
    this.setColour( '#ffce54' ); 
    this.setTooltip( 'Allume toutes les LEDs de Thymio pendant 1 seconde, avec la couleur de ton choix.' ); 
    this.appendDummyInput().appendField( 'allume les lumières avec la couleur' );
    this.appendDummyInput().appendField(new Blockly.FieldColour( "#ff0000"), "Couleur" );
    this.appendDummyInput().appendField( 'pendant 1 seconde' );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_2_Lumières_AllumeLesLEDs_SELLED_SELCouleur_SAIDurée'] = { 
  init: function() { 
    this.setColour( '#ffce54' ); 
    this.setTooltip( 'Allume les lumières avec la couleur de ton choix, pendant un temps &#40;valeur de 1s à 60s&#41;.' ); 
    this.appendDummyInput().appendField( "allume" );
    this.appendDummyInput().appendField( new Blockly.FieldDropdown( [   [ "toutes les lumières", "TOUTES_LES_LEDS" ],
                                                                                                       [ "lumières du dessus", "LED_DU_DESSUS" ],
                                                                                                       [ "lumières de gauche", "LED_DE_GAUCHE" ],
                                                                                                       [ "lumières de droite", "LED_DE_DROITE" ]]), "LED" );
    this.appendDummyInput().appendField( "couleur" );
    this.appendDummyInput().appendField( new Blockly.FieldColour("#ff0000"), "Couleur" )
        .appendField( "pendant" )
        .appendField( new Blockly.FieldNumber(1, 1, 60, 1), "Durée" )
        .appendField( "seconde(s)" );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_6_Lumières_EteinsToutesLesLEDs'] = { 
  init: function() { 
    this.setColour( '#ffce54' ); 
    this.setTooltip( 'Eteins toutes les LEDs.' ); 
    this.appendDummyInput().appendField( 'éteins les lumières' );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_1b_Lumières_EteinsToutesLesLEDsPendant1Seconde'] = { 
  init: function() { 
    this.setColour( '#ffce54' ); 
    this.setTooltip( 'Etteins toutes les lumières de Thymio pendant 1 seconde.' ); 
    this.appendDummyInput().appendField( 'éteins toutes les lumières pendant 1 seconde' );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_1b_Sons_JoueLaNote_DO_Pendant05Seconde'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue la note de musique DO' ); 
    this.appendDummyInput().appendField( 'joue DO' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_1b_Sons_JoueLaNote_RE_Pendant05Seconde'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue la note de musique RE' ); 
    this.appendDummyInput().appendField( 'joue RE' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_1b_Sons_JoueLaNote_MI_Pendant05Seconde'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue la note de musique MI' ); 
    this.appendDummyInput().appendField( 'joue MI' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_1b_Sons_JoueLaNote_FA_Pendant05Seconde'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue la note de musique FA' ); 
    this.appendDummyInput().appendField( 'joue FA' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_1b_Sons_JoueLaNote_SOL_Pendant05Seconde'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue la note de musique SOL' ); 
    this.appendDummyInput().appendField( 'joue SOL' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_1b_Sons_JoueLaNote_LA_Pendant05Seconde'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue la note de musique LA' ); 
    this.appendDummyInput().appendField( 'joue LA' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_1b_Sons_JoueLaNote_SI_Pendant05Seconde'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue la note de musique SI' ); 
    this.appendDummyInput().appendField( 'joue SI' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_2_Sons_JoueUneNoteCroche_SELNote'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue une note croche.' ); 
    this.appendDummyInput()
      .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-note-croche.png", 20, 20, "croche" ));
    this.appendDummyInput().appendField(
      new Blockly.FieldDropdown([ ["Do₃", "DO3"],
       	                                      ["Ré₃",  "RE3"],
       	                                      ["Mi₃",  "MI3"],
       	                                      ["Fa₃",  "FA3"],
       	                                      ["Sol₃",  "SOL3"],
       	                                      ["La₃",  "LA3"],
       	                                      ["Si₃",  "SI3"],
       	                                      ["Do₄",  "DO4"],
       	                                      ["Ré₄",  "RE4"],
       	                                      ["Mi₄",  "MI4"],
       	                                      ["Fa₄",  "FA4"],
       	                                      ["Sol₄",  "SOL4"],
       	                                      ["La₄",  "LA4"],
       	                                      ["Si₄",  "SI4"],
                                               ]), "Note" );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_2_Sons_JoueUneNoteNoire_SELNote'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue une note noire.' ); 
    this.appendDummyInput()
      .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-note-noire.png", 20, 20, "noire" ));
    this.appendDummyInput().appendField(
      new Blockly.FieldDropdown([ ["Do₃", "DO3"],
       	                                      ["Ré₃",  "RE3"],
       	                                      ["Mi₃",  "MI3"],
       	                                      ["Fa₃",  "FA3"],
       	                                      ["Sol₃",  "SOL3"],
       	                                      ["La₃",  "LA3"],
       	                                      ["Si₃",  "SI3"],
       	                                      ["Do₄",  "DO4"],
       	                                      ["Ré₄",  "RE4"],
       	                                      ["Mi₄",  "MI4"],
       	                                      ["Fa₄",  "FA4"],
       	                                      ["Sol₄",  "SOL4"],
       	                                      ["La₄",  "LA4"],
       	                                      ["Si₄",  "SI4"],
                                               ]), "Note" );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_2_Sons_JoueUneNoteBlanche_SELNote'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue une note blanche.' ); 
    this.appendDummyInput()
      .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-note-blanche.png", 20, 20, "blanche" ));
    this.appendDummyInput().appendField(
      new Blockly.FieldDropdown([ ["Do₃", "DO3"],
       	                                      ["Ré₃",  "RE3"],
       	                                      ["Mi₃",  "MI3"],
       	                                      ["Fa₃",  "FA3"],
       	                                      ["Sol₃",  "SOL3"],
       	                                      ["La₃",  "LA3"],
       	                                      ["Si₃",  "SI3"],
       	                                      ["Do₄",  "DO4"],
       	                                      ["Ré₄",  "RE4"],
       	                                      ["Mi₄",  "MI4"],
       	                                      ["Fa₄",  "FA4"],
       	                                      ["Sol₄",  "SOL4"],
       	                                      ["La₄",  "LA4"],
       	                                      ["Si₄",  "SI4"],
                                               ]), "Note" );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['1_1_Sons_JoueUnInstrument_SELInstrument_SELNote_SELDurée'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue un instrument' ); 
    this.appendDummyInput()
      .appendField( 'instrument' )
      .appendField( new Blockly.FieldDropdown( [  [ "Piano",  "PIANO" ],
                                                                     [ "Banjo", "BANJO" ],
                                                                     [ "Vibraphone", "VIBRAPHONE" ],
                                                                     [ "Trompette", "TROMPETTE" ]
                                                                  ] ), "Instrument" )
      .appendField( 'note' )
      .appendField( new Blockly.FieldDropdown( [  [ "Do₃",  "DO3" ],
                                                                     [ "Do#₃", "DO3DIESE" ],
                                                                     [ "Ré₃",  "RE3" ],
                                                                     [ "Ré#₃", "RE3DIESE" ],
                                                                     [ "Mi₃",  "MI3" ],
                                                                     [ "Fa₃",  "FA3" ],
                                                                     [ "Fa#₃", "FA3DIESE" ],
                                                                     [ "Sol₃", "SOL3" ],
                                                                     [ "Sol#₃","SOL3DIESE" ],
                                                                     [ "La₃",  "LA3" ],
                                                                     [ "La#₃", "LA3DIESE" ],
                                                                     [ "Si₃",  "SI3" ],
                                                                     [ "Do₄",  "DO4" ],
                                                                     [ "Do#₄", "DO4DIESE" ],
                                                                     [ "Ré₄",  "RE4" ],
                                                                     [ "Ré#₄", "RE4DIESE" ],
                                                                     [ "Mi₄",  "MI4" ],
                                                                     [ "Fa₄",  "FA4" ],
                                                                     [ "Fa#₄", "FA4DIESE" ],
                                                                     [ "Sol₄", "SOL4" ],
                                                                     [ "Sol#₄","SOL4DIESE" ],
                                                                     [ "La₄",  "LA4" ],
                                                                     [ "La#₄", "LA4DIESE" ],
                                                                     [ "Si₄",  "SI4" ]
                                                                     ] ), "Note" )
      .appendField( 'durée' )
      .appendField( new Blockly.FieldDropdown( [  [ {"src":"Blockly4Thymio/icones/icone-note-croche.png","width":15,"height":15,"alt":"croche"}, "CROCHE" ],
                                                                     [ {"src":"Blockly4Thymio/icones/icone-note-noire.png","width":15,"height":15,"alt":"noire"}, "NOIRE" ],
                                                                     [ {"src":"Blockly4Thymio/icones/icone-note-blanche.png","width":15,"height":15,"alt":"blanche"}, "BLANCHE" ]
                                                                  ] ), "Durée" );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['1_1_Sons_JoueUnePercussion_SELNote_SELDurée'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue une percussion' ); 
    this.appendDummyInput()
      .appendField( 'percussion' )
      .appendField( new Blockly.FieldDropdown( [  [ "Bongo 1",  "DO3" ],
                                                                     [ "Bongo 2", "DO3DIESE" ],
                                                                     [ "Bongo 3",  "RE3" ],
                                                                     [ "Bongo 4", "RE3DIESE" ],
                                                                     [ "Bongo 5",  "MI3" ],
                                                                     [ "Derbouka 1",  "FA3" ],
                                                                     [ "Derbouka 2", "FA3DIESE" ],
                                                                     [ "Cloche 1", "SOL3" ],
                                                                     [ "Cloche 2","SOL3DIESE" ],
                                                                     [ "Cyballe","LA3" ],
                                                                     [ "Sifflet 1",  "SI3" ],
                                                                     [ "Sifflet 2",  "DO4" ],
                                                                     [ "Sifflet 3",  "SI4" ],
                                                                     [ "Güiro",  "RE4" ],
                                                                     [ "Woodblock 1", "RE4DIESE" ],
                                                                     [ "Wookblock 2",  "MI4" ],
                                                                     [ "Woodblock 3",  "FA4" ],
                                                                     [ "Cuica 1", "FA4DIESE" ],
                                                                     [ "Cuica 2", "SOL4" ]
                                                                     ] ), "Note" )
      .appendField( 'durée' )
      .appendField( new Blockly.FieldDropdown( [  [ {"src":"Blockly4Thymio/icones/icone-note-croche.png","width":15,"height":15,"alt":"croche"}, "CROCHE" ],
                                                                     [ {"src":"Blockly4Thymio/icones/icone-note-noire.png","width":15,"height":15,"alt":"noire"}, "NOIRE" ],
                                                                     [ {"src":"Blockly4Thymio/icones/icone-note-blanche.png","width":15,"height":15,"alt":"blanche"}, "BLANCHE" ]
                                                                  ] ), "Durée" );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_2_Sons_JoueUnSon_SELSon'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue un son' ); 
    this.appendDummyInput().appendField( 'joue le son' );
    this.appendDummyInput().appendField(
      new Blockly.FieldDropdown([ ["bonjour !",                 "SON_BONJOUR"],
       	                                   ["ho !",                         "SON_HO"],
            			      	   ["quoi ?",                      "SON_QUOI"],
                                               ["je suis pas content !",  "SON_JE_SUIS_PAS_CONTENT"],
                                               ["sirène des pompiers",   "SON_SIRENE_DES_POMPIERS"]
                                               ]), "Son" );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_4_Sons_JoueUnSonPersonnel_SELSon'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Joue un son personnel présent sur la carte micro SD. Pour plus d\'informations sur la création de fichier son : www.thymio.org/fr:thymioapi' ); 
    this.appendDummyInput().appendField( 'joue le son personnel n°' );
    this.appendDummyInput().appendField(
      new Blockly.FieldDropdown([ ["01", "SON_PERSONNEL_01"],
       	                                   ["02", "SON_PERSONNEL_02"],
       	                                   ["03", "SON_PERSONNEL_03"],
       	                                   ["04", "SON_PERSONNEL_04"],
       	                                   ["05", "SON_PERSONNEL_05"],
       	                                   ["06", "SON_PERSONNEL_06"],
       	                                   ["07", "SON_PERSONNEL_07"],
       	                                   ["08", "SON_PERSONNEL_08"],
       	                                   ["09", "SON_PERSONNEL_09"],
       	                                   ["10", "SON_PERSONNEL_10"]
                                               ]), "Son" );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_4_Sons_EnregistreUnSon_Pendant04Seconde'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Enregistre un son de 4 secondes depuis le microphone.' ); 
    this.appendDummyInput().appendField( 'Enregistre un son de 4 secondes' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_4_Sons_RelireLeSonEnregistré'] = { 
  init: function() { 
    this.setColour( '#a0d468' ); 
    this.setTooltip( 'Relecture du son enregistré par le microphone.' ); 
    this.appendDummyInput().appendField( 'Relire le son enregistré' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_1b_Contrôles_Attends1Seconde'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Thymio attend 1 seconde.' ); 
    this.appendDummyInput().appendField( 'attends 1 seconde' );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
    this.setInputsInline( true );
  } 
}; 

Blockly.Blocks['0_2_Contrôles_Attends_SAIDurée'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Thymio attend pendant le nombre de seconde saisi [valeur de 1s à 60s].' ); 
    this.appendDummyInput()
        .appendField( "attends" )
        .appendField( new Blockly.FieldNumber(1, 1, 60, 1), "Durée" )
        .appendField( "seconde(s)" );
    this.setInputsInline( true );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_7_Contrôles_Attends_ENTDurée'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Thymio attend pendant le nombre de seconde qui seront indiqués.' ); 
    this.appendDummyInput()
        .appendField( "attends" );
    this.appendValueInput( "Durée" )
        .setCheck( "Number" );
    this.appendDummyInput()
        .appendField( "seconde(s)" );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
    this.setNextStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_1b_Contrôles_RépèteToutLeTemps'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Répète tout le temps une ou plusieurs actions.' ); 
    this.appendDummyInput().appendField( "faire tout le temps" );
    this.appendStatementInput( "BlocsInternes" );
    this.setPreviousStatement( true );
  } 
}; 

Blockly.Blocks['0_1b_Contrôles_Répète_SAIBoucle'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Répète une ou plusieurs actions, du nombre de boucle saisi [valeur de 1 à 100].' ); 
    this.appendDummyInput()
        .appendField( 'faire' )
        .appendField( new Blockly.FieldNumber(3, 1, 100, 1), "NombreDeBoucle" )
        .appendField( "fois" );
    this.appendStatementInput( "BlocsInternes" )
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_6_Contrôles_Faire_TantQue_ENTCondition'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Répète une ou plusieurs actions, tant que la condition est vrai.' ); 
    this.appendStatementInput( "BlocsInternes" )
      .appendField( "faire" );
    this.appendValueInput( "Condition" )
      .setCheck( "Boolean" )
      .appendField( "tant que" );
    this.setInputsInline( true );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_7_Contrôles_TantQue_ENTCondition_Faire'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Répète une ou plusieurs actions, tant que la condition est vrai.' ); 
    this.appendValueInput( "Condition" )
      .setCheck( "Boolean" )
      .appendField( "tant que" );
    this.appendStatementInput( "BlocsInternes" )
      .appendField( "faire" );
    this.setInputsInline( true );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_2_Contrôles_Si_IlYAUnObstacleDevant_Alors'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Si il y a un obstacle devant Thymio, le groupe d\'instructions est exécuté.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-avant-tous.png", 24, 24, "" ))
        .appendField( "si il y a un obstacle devant" );
    this.appendStatementInput( "BlocsInternes" ).appendField( "faire" );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_2_Contrôles_Si_ENTCondition_Alors'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Si la condition est vrai, le groupe d\'instructions est exécuté.' ); 
    this.appendValueInput( "Condition" )
        .setCheck( "Boolean" )
        .appendField( "si" );
    this.appendStatementInput( "BlocsInternes" ).appendField( "faire" );
    this.setInputsInline( true );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_7_Contrôles_Si_ENTCondition_Faire_SinonFaire'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Si la condition est vrai, le premier groupe d\'instructions est exécuté. Si la condition est fausse, le second groupe d\'instructions est exécuté.' ); 
    this.appendValueInput( "Condition" )
        .setCheck( "Boolean" )
        .appendField( "si" );
    this.appendStatementInput( "BlocsInternes" )
        .appendField( "faire" );
    this.appendStatementInput( "BlocsInternes_Sinon" )
        .appendField( "sinon faire" );
    this.setInputsInline( true );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_6_Contrôles_SortDeLaBoucleFaire'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Sort de la boucle \'faire\'.' ); 
    this.appendDummyInput().appendField( 'sort de la boucle faire' );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_6_Contrôles_ArrêteLeProgramme'] = { 
  init: function() { 
    this.setColour( '#48cfad' ); 
    this.setTooltip( 'Arrête le programme.' ); 
    this.appendDummyInput().appendField( 'arrête le programme' );
    this.setInputsInline( true );
    this.setPreviousStatement( true, "null" );
  } 
}; 

Blockly.Blocks['0_6_Valeur_Booléen_OULogique_ENTBooleen_ENTBooleen'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( '' ); 
    this.appendValueInput("Valeur1")
      .setCheck("Boolean");
    this.appendValueInput("Valeur2")
      .setCheck("Boolean")
      .appendField("ou");
    this.setInputsInline(true);
    this.setOutput(true, "Boolean");
  } 
}; 

Blockly.Blocks['0_6_Valeur_Booléen_ETLogique_ENTBooleen_ENTBooleen'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( '' ); 
    this.appendValueInput("Valeur1")
      .setCheck("Boolean");
    this.appendValueInput("Valeur2")
      .setCheck("Boolean")
      .appendField("et");
    this.setInputsInline(true);
    this.setOutput(true, "Boolean");
  } 
}; 

Blockly.Blocks['0_6_Valeur_Booléen_NONLogique_ENTBooleen'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( '' ); 
    this.appendValueInput("Valeur1")
      .setCheck("Boolean")
      .appendField("non");
    this.setInputsInline(true);
    this.setOutput(true, "Boolean");
  } 
}; 

Blockly.Blocks['0_6_Valeur_Booléen_Bouton_AucuneFlèche'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Aucun bouton flèche n\'est appuyé.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-boutons-aucune-fleche.png", 24, 24, "" ))
        .appendField( "aucun bouton flèche n'est appuyé" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Bouton_FlècheAvant'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Le bouton flèche avant est appuyé.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-bouton-avant.png", 24, 24, "" ))
        .appendField( "le bouton flèche avant est appuyé" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Bouton_FlècheArrière'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Le bouton flèche arrière est appuyé.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-bouton-arriere.png", 24, 24, "" ))
        .appendField( "le bouton flèche arrière est appuyé" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Bouton_FlècheADroite'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Le bouton flèche à droite est appuyé.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-bouton-droite.png", 24, 24, "" ))
        .appendField( "le bouton flèche à droite est appuyé" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Bouton_FlècheAGauche'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Le bouton flèche à gauche est appuyé.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-bouton-gauche.png", 24, 24, "" ))
        .appendField( "le bouton flèche à gauche est appuyé" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_7_Valeur_Booléen_Capteur_AvantAucun'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Sur tous les capteurs avant, Thymio ne détecte aucun obstacle.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-avant-aucun.png", 24, 24, "" ))
        .appendField( "il n'y a pas d'obstacle devant" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Capteur_AvantGauche'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Thymio détecte un obstacle devant, à gauche.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-avant-gauche.png", 24, 24, "" ))
        .appendField( "il y a un obstacle devant, à gauche" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Capteur_AvantMilieuGauche'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Thymio détecte un obstacle devant, un peu à gauche.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-avant-milieu-gauche.png", 24, 24, "" ))
        .appendField( "il y a un obstacle devant, un peu à gauche" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Capteur_AvantMilieu'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Thymio détecte un obstacle droit devant.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-avant-milieu.png", 24, 24, "" ))
        .appendField( "il y a un obstacle droit devant" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Capteur_AvantMilieuDroite'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Thymio détecte un obstacle devant, un peu à droite.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-avant-milieu-droite.png", 24, 24, "" ))
        .appendField( "il y a un obstacle devant, un peu à droite" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Capteur_AvantDroite'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Thymio détecte un obstacle devant, à droite.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-avant-droite.png", 24, 24, "" ))
        .appendField( "il y a un obstacle devant, à droite" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_7_Valeur_Booléen_Capteur_ArrièreAucun'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Sur tous les capteurs arrières, Thymio ne détecte aucun obstacle.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-arriere-aucun.png", 24, 24, "" ))
        .appendField( "il n'y a pas d'obstacle derrière" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Capteur_ArrièreGauche'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Thymio détecte un obstacle derrière, à gauche.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-arriere-gauche.png", 24, 24, "" ))
        .appendField( "il y a un obstacle derrière, à gauche" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Capteur_ArrièreDroite'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Thymio détecte un obstacle derrière, à droite.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-arriere-droite.png", 24, 24, "" ))
        .appendField( "il y a un obstacle derrière, à droite" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Capteur_DessousGauche_Blanc'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Thymio voit le sol de couleur blanc, à gauche.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-dessous-gauche-blanc.png", 24, 24, "" ))
        .appendField( "le sol est blanc, à gauche" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Capteur_DessousGauche_Noir'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Thymio voit le sol de couleur noir, à gauche.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-dessous-gauche-noir.png", 24, 24, "" ))
        .appendField( "le sol est noir, à gauche" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Capteur_DessousDroite_Blanc'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Thymio voit le sol de couleur blanc, à droite.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-dessous-droite-blanc.png", 24, 24, "" ))
        .appendField( "le sol est blanc, à droite" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_2_Valeur_Booléen_Capteur_DessousDroite_Noir'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Thymio voit le sol de couleur noir, à droite.' ); 
    this.appendDummyInput()
        .appendField(new Blockly.FieldImage( "Blockly4Thymio/icones/icone-capteur-dessous-droite-noir.png", 24, 24, "" ))
        .appendField( "le sol est noir, à droite" );
    this.setInputsInline( false );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_5_Valeur_Booléen_BoutonDeLaTélécommandeEst_SELTouche'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Indique quelle est le bouton de la télécommande qui est appuyé.' ); 
    this.appendDummyInput()
        .appendField( "le bouton de la télécommande est" )
        .appendField( new Blockly.FieldDropdown( [ ["Go", "GO"],
                                                                      ["Stop", "STOP"],
                                                                      ["Avant ˄", "AVANT"],
                                                                      ["Arrière ˅", "ARRIERE"],
                                                                      ["Gauche ˂", "GAUCHE"],
                                                                      ["Droite ˃", "DROITE"],
                                                                      ["Ok", "OK"],
                                                                      ["VOL +", "PLUS"],
                                                                      ["VOL ─", "MOINS"],
                                                                      ["0", "0"],
                                                                      ["1", "1"],
                                                                      ["2", "2"],
                                                                      ["3", "3"],
                                                                      ["4", "4"],
                                                                      ["5", "5"],
                                                                      ["6", "6"],
                                                                      ["7", "7"],
                                                                      ["8", "8"],
                                                                      ["9", "9"]
                                                                   ]), "Bouton" );
    this.setOutput( true, "Boolean" );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_8_Valeur_Entier_SAIValeur'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Nombre [valeur de -1000 à 1000].' ); 
    this.appendDummyInput()
      .appendField( new Blockly.FieldNumber(1, -1000, 1000, 1), "Valeur" );
    this.setOutput(true, "Number");
  } 
}; 

Blockly.Blocks['0_8_Valeur_Entier_NombreAuHasardEntre0et7'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Sort un nombre au hasard, entre 0 et 7.' ); 
    this.appendDummyInput().appendField( "nombre au hasard entre 0 et 7" );
    this.setInputsInline( false );
    this.setOutput( true, "Number" );
  } 
}; 

Blockly.Blocks['0_8_Valeur_Entier_Opération_ENTEntier_SELOpération_ENTEntier'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Opération numérique entre deux valeurs. L\'opération % correspond au reste de la division.' ); 
    this.appendValueInput( "Valeur1" )
      .setCheck( "Number" );
    this.appendValueInput( "Valeur2" )
      .setCheck( "Number" )
      .appendField( new Blockly.FieldDropdown( [[ "+", "ADDITION" ], 
                                                                   [ "-", "SOUSTRACTION" ],
                                                                   [ "x", "MULTIPLICATION" ],
                                                                   [ "/", "DIVISION" ],
                                                                   [ "%", "MODULO" ] ]),
                                                                   "Opération" );
    /* Note : Le caractère   ne passe pas dans les FieldDropdown et est remplacé par + */
    this.setInputsInline( true );
    this.setOutput( true, "Number" );
  } 
}; 

Blockly.Blocks['0_8_Valeur_Booléen_Comparaison_ENTEntier_SELComparaion_ENTEntier'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Compare deux valeurs. Retourne VRAI si la comparaison est vrai. Retourne FAUX si la comparaison est fausse.' ); 
    this.appendValueInput( "Valeur1" )
      .setCheck( "Number" );
    this.appendValueInput( "Valeur2" )
      .setCheck( "Number" )
      .appendField(new Blockly.FieldDropdown( [[ "=", "ÉGAL" ],
                                                                  [ "≠", "DIFFÉRENT" ],
                                                                  [ ">", "PLUS_GRAND" ],
                                                                  [ "<", "PLUS_PETIT" ],
                                                                  [ "≥", "PLUS_GRAND_OU_ÉGAL"],
                                                                  [ "≤", "PLUS_PETIT_OU_ÉGAL"]]),
                                                                  "Comparaison" );
    this.setInputsInline( true );
    this.setOutput( true, "Boolean" );
  } 
}; 

Blockly.Blocks['0_8_Valeur_AfficheLaValeur_ENTEntier'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Affiche la valeur d\'une variable.' ); 
    this.appendValueInput( "Valeur" )
      .setCheck( "Number" )
      .appendField( "Affiche la valeur de" );
    this.setInputsInline( true );
    this.setPreviousStatement( true );
    this.setNextStatement( true );
  } 
}; 

Blockly.Blocks['0_9_Valeur_Entier_Température'] = { 
  init: function() { 
    this.setColour( '#5d9cec' ); 
    this.setTooltip( 'Valeur du capteur de température en degré Celsius.' ); 
    this.appendDummyInput().appendField( "température en °C" );
    this.setInputsInline( false );
    this.setOutput( true, "Number" );
  } 
}; 

Blockly.Blocks['0_8_Variables'] = { 
  init: function() { 
    this.setColour( '#8f3fb0' ); 
    this.setTooltip( '' ); 
    
  } 
}; 
