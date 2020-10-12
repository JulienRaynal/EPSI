import 'dart:math';

import "./gameFunction/role_dices.dart";
import "./gameFunction/create_objects.dart";
import './gameFunction/get_bots_health.dart';
import "./gameFunction/victory.dart";
import "./gameFunction/check_continue.dart";
import "./classes/bot_class.dart";
import "./classes/player_class.dart";

void main() {
  int gameLevel = 1;
  Player player = createPlayer();
  bool confirmContinue = true;

  do {
    List botList = new List<Bot>();
    for (int i = 0; i < gameLevel; i++) {
      Bot bot = createBot(player, gameLevel);
      botList.add(bot);
    }

    int numberOfPlayers = 2;
    Random random = new Random();
    int turn = (1 + random.nextInt(numberOfPlayers));
    print(turn);

    do {
      if (turn == 1) {
        int damages = roleDices(player.name, turn);
        player.attackBot(botList, damages);
        turn = 2;
      } else {
        int damages = roleDices(player.name, turn);
        for (int i = 0; i < botList.length; i++) {
          botList[i].attackPlayer(player, damages);
        }
        turn = 1;
      }
      // turn = (1 + random.nextInt(numberOfPlayers));
    } while (checkBotHealth(botList) > 0 && player.health > 0);
    if (player.health > 0) {
      playerVictory(player, botList, gameLevel);
    }

    confirmContinue = checkContinue();
  } while (confirmContinue == true);
}
