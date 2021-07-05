import 'dart:async';
import 'package:flutter/material.dart';

import 'ScoreObject.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  bool _gameStarted = false;
  int _score = 0;
  int _bestScore = 0;
  String _bestPlayerName = "";
  String _currentPlayerName = "";
  Timer _timer;
  String _name;
  List<ScoreObject> _globalScores = new List();

  void startGame() {
    setState(() {
      if (_gameStarted == false) {
        _gameStarted = true;
        _score = 0;
        _timer = Timer(Duration(seconds: 10), _endGame);
      }
    });
  }

  void addScore() {
    setState(() {
      _score += 1;
    });
  }

  void _endGame() {
    setState(() {
      _gameStarted = false;
      if (_score > _bestScore) {
        _bestScore = _score;
        _bestPlayerName = _currentPlayerName;
      }
      ScoreObject newScore = new ScoreObject(_score, _currentPlayerName);
      _globalScores.add(newScore);
    });
  }

  void _nameUpdate(String value) {
    setState(() {
      _currentPlayerName = value;
    });
  }

  String _validateString() {
    if (_currentPlayerName.length == 0) {
      return "Name should be input before starting the game";
    }
    return null;
  }

  Widget _scoreListBuilder(BuildContext context, int count) {
    return Text("${_globalScores[0].playerName} : ${_globalScores[0].score}");
  }

  List<Widget> returnDisplay() {
    List<Widget> widgetToReturn = new List();
    if (_gameStarted) {
      widgetToReturn.add(Text("Score : $_score"));
      widgetToReturn
          .add(ElevatedButton(onPressed: addScore, child: Text("+1")));
      widgetToReturn.add(Text(_currentPlayerName));
    } else {
      widgetToReturn.add(Text("Press start to start the game"));
      widgetToReturn.add(Text("Your score : $_score"));
      widgetToReturn
          .add(Text("Current best score : $_bestScore by $_bestPlayerName"));
      widgetToReturn.add(TextFormField(
        autocorrect: false,
        autofillHints: [AutofillHints.name],
        onChanged: _nameUpdate,
        decoration: InputDecoration(
            hintText: "Player name", errorText: _validateString()),
      ));
      widgetToReturn.add(Expanded(
          child: ListView.builder(
              itemBuilder: _scoreListBuilder,
              itemCount: _globalScores.length)));
    }

    return widgetToReturn;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            Column(
              children: [
                ...?returnDisplay(),
              ],
            ),
            Row(children: [
              Expanded(
                  child: ElevatedButton(
                      onPressed: startGame, child: Text("start"))),
            ])
          ],
        ),
      ),
    );
  }
}
