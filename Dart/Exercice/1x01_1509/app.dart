import 'dart:io';

import 'NE_PAS_TOUCHER/user_input.dart';
import "Values/PI.dart";

void main() {
  print("Exercice 6");
  pyramide();
}

afficherEspaces(int nombreEspaces) {
  for (int i = 0; i < nombreEspaces; i++) {
    stdout.write(" ");
  }
}

int obtenirUniteDuNombre(int nbre) {
 if (nbre >= 10) {
     do {
       nbre %= 10;
    } while (nbre > 10);
  }
  return(nbre);
}

afficherNombreCroissant(int nbre) {
  for (int i = nbre; i < nbre * 2 - 1; i++) {
    stdout.write(obtenirUniteDuNombre(i));
  }
}

afficherNombreDecroissant(int nbre) {
  for (int i = 2 * nbre - 1; i > nbre - 1; i--) {
    stdout.write(obtenirUniteDuNombre(i));   
  } 
}

pyramide() {
  int nbre = readInt("Veuillez saissir un chiffre");
  for (int i = 0; i <= nbre; i++) {
    afficherEspaces(nbre - i);
    afficherNombreCroissant(i);
    afficherNombreDecroissant(i);
    print("");
  }
}