import '../NE_PAS_TOUCHER/user_input.dart';

void main1() {
  print("Welcome, Please choose an action");
  final int optionSelection =
      readInt("1) Start the game \n2)Preferences \n3)Exit the game");

  switch (optionSelection) {
    case 1:
      print("Starting the game");
      break;
    case 2:
      print("Showing the preferences menu");
      break;
    case 3:
      print("Exiting the game");
      break;
  }
}
