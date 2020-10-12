import '../NE_PAS_TOUCHER/user_input.dart';

import "../classes/bot_class.dart";
import "../classes/player_class.dart";

Player createPlayer() {
  final String playerName = readText("Please enter your name");
  final double playerStrength = 1;
  final double playerHealth = 100;

  Player player = new Player(playerName,
      strengthSetter: playerStrength, healthSetter: playerHealth);
  return player;
}

Bot createBot(Player player, int gameLevel) {
  final double strength = gameLevel * (0.75 * player.strength);
  Bot bot = new Bot(strength);
  return bot;
}
