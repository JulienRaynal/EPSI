import '../NE_PAS_TOUCHER/user_input.dart';

void main2() {
  print("Welcome, Please choose an action");
  int optionSelection =
      readInt("1) Start the game \n2)Preferences \n3)Exit the game");

  if (optionSelection < 1 || optionSelection > 3) {
    do {
      optionSelection =
          readInt("1) Start the game \n2)Preferences \n3)Exit the game");
    } while (optionSelection < 1 || optionSelection > 3);
  }

  printStartGame() {
    print("Starting the game");
  }

  printShowingTheReferenceMenu() {
    print("Showing the preferences menu");
  }

  printExitGame() {
    print("Exiting the game");
  }

  switch (optionSelection) {
    case 1:
      printStartGame();
      break;
    case 2:
      printShowingTheReferenceMenu();
      break;
    case 3:
      printExitGame();
      break;
  }
}
