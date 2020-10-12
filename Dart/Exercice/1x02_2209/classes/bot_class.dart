import "./player_class.dart";
import 'fighter.dart';

class Bot extends Fighter {
  //propriété calculé

  String displayBotInfos() {
    return "BOT \nStrength : ${strength} \nHealth : $health%";
  }

  attackPlayer(Player player, int damages) {
    player.health -= strength * damages;
    print("${player.name} health : ${player.health}%");
  }

  Bot(double strengthSetter, {double healthSetter = 100})
      : super(strengthSetter, healthSetter) {}
}
