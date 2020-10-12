import '../NE_PAS_TOUCHER/user_input.dart';

void main2() {
  print("Welcome");
  String playerName = readText("Please input your name");
  int optionSelection =
      readInt("1) Start the game \n2)Preferences \n3)Exit the game");

  if (optionSelection < 1 || optionSelection > 3) {
    do {
      optionSelection =
          readInt("1) Start the game \n2)Preferences \n3)Exit the game");
    } while (optionSelection < 1 || optionSelection > 3);
  }

  printStartGame(String playerName) {
    print("$playerName started the game");
  }

  printShowingTheReferenceMenu(String playerName) {
    print("Showing the preferences menu to $playerName");
  }

  printExitGame(String playerName) {
    print("$playerName exited the game");
  }

  switch (optionSelection) {
    case 1:
      printStartGame(playerName);
      break;
    case 2:
      printShowingTheReferenceMenu(playerName);
      break;
    case 3:
      printExitGame(playerName);
      break;
  }
}
