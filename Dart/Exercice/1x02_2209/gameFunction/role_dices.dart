import 'dart:math';
import '../NE_PAS_TOUCHER/user_input.dart';

int roleDices(String playerName, int turn) {
  Random random = new Random();
  int min = 1;
  int max = 6;

  int diceValue = (min + random.nextInt(max - min));

  if (turn != 1) {
    print("The bot rolled : $diceValue \n");
  } else {
    readText(
        "$playerName rolled : $diceValue \nPlease press any key to continue");
  }

  return diceValue;
}

bool hitChances(String playerName) {
  Random random = new Random();
  int min = 1;
  int max = 2;

  int diceValue = (min + random.nextInt(max - min) + 1);

  switch (diceValue) {
    case 1:
      return true;
    case 2:
      return false;
    default:
      true;
  }

  return true;
}

bool weaponHitChances(int accuracy) {
  Random random = new Random();
  int min = 0;
  int max = 100;

  int diceValue = (min + random.nextInt(max - min));

  if (diceValue > accuracy) {
    return false;
  } else {
    return true;
  }
}
