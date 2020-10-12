import '../NE_PAS_TOUCHER/user_input.dart';
import 'bot_class.dart';
import 'fighter.dart';
import 'weapon_class.dart';
import '../gameFunction/role_dices.dart';

class Player extends Fighter {
  String _name;
  Weapon _weapon;

  String displayPlayerInfo() {
    return "$name \nStrength : ${strength} \nHealth : $health%";
  }

  //propriété calculé
  String get name {
    return _name;
  }

  set name(String newName) {
    if (newName.length > 0) {
      _name = newName;
    }
  }

  Weapon get weapon => _weapon;
  set weapon(Weapon weapon) {
    _weapon = weapon;
  }

  //Attack Functions
  attackBot(List<Bot> botList, int damages) {
    int botsLeft = 0;
    for (Bot bot in botList) {
      if (bot.health > 0) {
        botsLeft += 1;
      }
    }
    int botToAttack =
        readInt("There's ${botsLeft} left, which one will you attack ?") - 1;
    attackSelection();
    if (botList[botToAttack].health <= 0) {
      do {
        botToAttack += 1;
      } while (botList[botToAttack].health <= 0);
      botList[botToAttack].health -= strength * damages;
    } else {
      botList[botToAttack].health -= strength * damages;
    }
    print("bot health : ${botList[botToAttack].health}%");
  }

  double attackSelection() {
    double attackDamages;
    int chosenAttack = readInt(
        "Choose an attack \n1: Normal attack \n2: Strong attack (50% chances to miss) \n3: Wait to heal health");

    switch (chosenAttack) {
      case 1:
        if (weaponHitChances(weapon.weaponAccuracy) != true) {
          print("$name missed the bot");
        } else {
          attackDamages = strength * weapon.weaponStrength;
          print("$name hit the bot");
        }
        break;
      case 2:
        if (hitChances(name) == true &&
            weaponHitChances(weapon.weaponAccuracy) == true) {
          attackDamages = strength * weapon.weaponStrength * 2;
          print("$name hit the bot with his full strength");
        } else {
          attackDamages = 0;
          print("$name attack missed");
        }
        break;
      case 3:
        attackDamages = 0;
        print("$name health restored for 25% of his total health");
        health += 25;
        break;
    }

    return attackDamages;
  }

  Player(String nameSetter,
      {double strengthSetter = 1, double healthSetter = 100})
      : super(strengthSetter, healthSetter) {
    name = nameSetter;
    _weapon = new Weapon("default sword", 1, 100);
  }
  // Player(this._name, {this._health = 0, this._strength= 100});
}
