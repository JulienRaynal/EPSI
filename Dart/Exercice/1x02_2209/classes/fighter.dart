import 'player_class.dart';

class Fighter {
  double _strength;
  double _health;

  double get strength => _strength;
  set strength(double value) {
    if (value > 0) {
      _strength = value;
    } else {
      _strength = 1;
    }
  }

  double get health => _health;
  set health(double value) {
    if (_health != null) {
      if (value >= 0 && value <= 100) {
        _health = value;
      } else if (value < 0) {
        _health = 0;
      } else if (value > 100) {
        _health = 100;
      }
    } else {
      _health = value;
    }
  }

  Fighter(double force, double newHealth) {
    strength = force;
    health = newHealth;
  }
}
