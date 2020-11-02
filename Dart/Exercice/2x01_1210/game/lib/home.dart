import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  bool _display = false;
  bool _gameStarted = false;
  int _score = 0;

  void displayGame() {
    setState(() {
      _display = !_display;
    });
  }

  void startGame() {
    setState(() {
      _gameStarted = true;
    });
  }

  void addScore() {
    setState(() {
      _score += 1;
    });
  }

  List<Widget> returnDisplay() {
    List<Widget> widgetToReturn = new List();
    if (_display) {
      if (_gameStarted) {
        widgetToReturn.add(Text("Score : $_score"));
        widgetToReturn
            .add(ElevatedButton(onPressed: addScore, child: Text("+1")));
      } else {
        widgetToReturn.add(Text("Press start to start the game"));
        widgetToReturn
            .add(ElevatedButton(onPressed: startGame, child: Text("start")));
      }
    } else {
      return null;
    }

    return widgetToReturn;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            ...?returnDisplay(),
            ElevatedButton(
                onPressed: displayGame, child: Text("display / hide the game"))
          ],
        ),
      ),
    );
  }
}
