import '../NE_PAS_TOUCHER/user_input.dart';
import '../classes/player_class.dart';
import '../classes/bot_class.dart';
import '../classes/weapon_class.dart';
import '../classes/weapon_list_manager.dart';

playerVictory(Player player, List<Bot> botList, int difficultyLevel) {
  WeaponListManager weaponManager = new WeaponListManager();
  double botStrength = 0;
  for (Bot bot in botList) {
    botStrength += bot.strength;
  }
  player.health += 50;
  player.strength *= (1.5 + botStrength) * difficultyLevel;
  print(
      "Congratulation your player healed 50 health and his strength is now ${player.strength}");
  weaponManager.newWeapon(player);
}
