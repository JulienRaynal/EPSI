import '../NE_PAS_TOUCHER/user_input.dart';

bool checkContinue() {
  int playerChoice = readInt("Do you want to continue \n1: Yes\n2: No");
  switch (playerChoice) {
    case 1:
      return true;
    case 2:
      return false;
    default:
      return true;
  }
}
