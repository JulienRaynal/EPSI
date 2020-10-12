import '../NE_PAS_TOUCHER/user_input.dart';
import './weapon_class.dart';
import './player_class.dart';

class WeaponListManager {
  List<Weapon> _weaponList = [
    new Weapon("Tabouret", 1, 100),
    new Weapon("Durandil l'épée en mytril", 5, 50),
    new Weapon("Squalala", 100, 100),
  ];

  newWeapon(Player player) {
    for (Weapon weapon in _weaponList) {
      if (weapon.weaponStrength < player.weapon.weaponStrength) {
        continue;
      } else {
        int replaceWeapon = readInt(
            "You find a weapon with the following stats \nname: Durendal, strength: 2, accuracy: 100 \nCurrent Weapon \nname: ${player.weapon.weaponName} strenght: ${player.weapon.weaponStrength} accuracy: ${player.weapon.weaponAccuracy} \n\nDo you want to take the new weapon ?\n1: yes \n2: no");
        if (replaceWeapon != 1) {
          print("You didn't change your weapon");
          break;
        } else {
          player.weapon = weapon;
          print("Congratulation, you now own ${weapon.weaponName}");
          break;
        }
      }
    }
  }
}
