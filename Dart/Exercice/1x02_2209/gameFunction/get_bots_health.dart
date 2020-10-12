import '../classes/bot_class.dart';

checkBotHealth(List<Bot> botList) {
  double botTotalHealthLeft = 0;
  for (int i = 0; i < botList.length; i++) {
    botTotalHealthLeft += botList[i].health;
  }
  // for (Bot bot in botList) {
  //   botTotalHealthLeft += bot.health;
  // }
  return botTotalHealthLeft;
}
