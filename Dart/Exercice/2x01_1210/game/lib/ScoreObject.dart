class ScoreObject {
  int _score;
  String _playerName;

  set score(int value) {
    _score = value;
  }

  int get score {
    return _score;
  }

  set playerName(String value) {
    _playerName = value;
  }

  get playerName {
    return _playerName;
  }

  ScoreObject(this._score, this._playerName);
}
