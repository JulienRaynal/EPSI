import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  int _number = 0;
  void add() {
    setState(() {
      _number += 1;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SafeArea(
      child: Column(
        children: [
          Text("issou : $_number"),
          IconButton(icon: Icon(Icons.plus_one), onPressed: add)
        ],
      ),
    ));
  }
}
