import 'package:flutter/material.dart';

class MainView extends StatefulWidget {
  @override
  _MainViewState createState() => _MainViewState();
}

class _MainViewState extends State<MainView> {
  Widget stars = Row(
    children: [
      Icon(Icons.star),
      Icon(Icons.star),
      Icon(Icons.star),
      Icon(Icons.star),
    ],
  );

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
          child: Column(
        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          Image.network(
              "https://cdn.vox-cdn.com/thumbor/JiX2dp3_z6nT2k0LXu53-0glB84=/0x0:3840x2160/1220x813/filters:focal(1613x773:2227x1387):format(webp)/cdn.vox-cdn.com/uploads/chorus_image/image/67556013/Cyberpunk_2077_screen_10.0.jpg"),
          Text("Neo Tokyo"),
          Expanded(
              child: Center(
            child: Text(
                "We all love neoTokyo, hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh"),
          )),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceAround,
            children: [stars, Text("170 reviews")],
          ),
          Spacer(),
        ],
      )),
    );
  }
}
