class Weapon {
  String _weaponName;
  int _weaponStrength;
  int _weaponAccuracy;

  String get weaponName {
    return _weaponName;
  }

  set weaponName(String name) {
    _weaponName = name;
  }

  int get weaponStrength {
    return _weaponStrength;
  }

  set weaponStrength(int strength) {
    _weaponStrength = strength;
  }

  int get weaponAccuracy {
    return _weaponAccuracy;
  }

  set weaponAccuracy(int accuracy) {
    _weaponAccuracy = accuracy;
  }

  Weapon(String name, int strength, int accuracy) {
    weaponName = name;
    weaponStrength = strength;
    weaponAccuracy = accuracy;
  }
}
