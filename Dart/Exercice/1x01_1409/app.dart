import 'NE_PAS_TOUCHER/user_input.dart';
import "./exercices/exo-1.dart";
import "./exercices/exo-2.dart";

void main() {
  print("Which file do you want to read ?");
  int exerciceToLaunch = readInt("1)exercice 1 \n2)exercice 2");

  switch (exerciceToLaunch) {
    case 1:
      main1();
      break;
    case 2:
      main2();
      break;
  }
}
