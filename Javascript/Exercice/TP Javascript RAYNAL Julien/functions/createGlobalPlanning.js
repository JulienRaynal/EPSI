function createGlobalPlanningC1() {
  // for each hour
  for (let i = 0; i < 4; i++) {
    //for each day
    for (let j = 0; j < 5; j++) {
      for (let cursus of cursusArray) {
        if (cursus.hoursPerClass > 0) {
          if (i > 0) {
            if (
              i === 1 &&
              cursus.cursusName !== hourlyPlanningArray[j].cursusName
            ) {
              firstHourPlanningArray[j] = hourlyPlanningArray[j];
              hourlyPlanningArray[j] = cursus;
              cursus.hoursPerClass -= 2;
              break;
            } else if (
              i === 2 &&
              cursus.cursusName !== hourlyPlanningArray[j].cursusName &&
              cursus.cursusName !== firstHourPlanningArray[j].cursusName
            ) {
              secondHourPlanningArray[j] = hourlyPlanningArray[j];
              hourlyPlanningArray[j] = cursus;
              cursus.hoursPerClass -= 2;
              break;
            } else if (
              i === 3 &&
              cursus.cursusName !== hourlyPlanningArray[j].cursusName &&
              cursus.cursusName !== secondHourPlanningArray[j].cursusName &&
              cursus.cursusName !== firstHourPlanningArray[j].cursusName
            ) {
              thirdHourPlanningArray[j] = hourlyPlanningArray[j];
              hourlyPlanningArray[j] = cursus;
              fourthHourPlanningArray[j] = cursus;
              cursus.hoursPerClass -= 2;
              break;
            }
          } else {
            hourlyPlanningArray[j] = cursus;
            cursus.hoursPerClass -= 2;
            break;
          }
        }
      }
    }
    weeklyPlanningCursusArray.push(
      new cursusPerHour(
        dailyHours[i],
        hourlyPlanningArray[0].cursusName +
          " - " +
          hourlyPlanningArray[0].teacherCode,
        hourlyPlanningArray[1].cursusName +
          " - " +
          hourlyPlanningArray[1].teacherCode,
        hourlyPlanningArray[2].cursusName +
          " - " +
          hourlyPlanningArray[2].teacherCode,
        hourlyPlanningArray[3].cursusName +
          " - " +
          hourlyPlanningArray[3].teacherCode,
        hourlyPlanningArray[4].cursusName +
          " - " +
          hourlyPlanningArray[4].teacherCode
      )
    );
  }
}

function createGlobalPlanningC2(reps) {
  // for each hour
  for (let i = 0; i < 4; i++) {
    //for each day
    for (let j = 0; j < 5; j++) {
      for (let cursus of cursusArrayC2) {
        if (cursus.hoursPerClass > 0) {
          if (i > 0) {
            if (
              i === 1 &&
              cursus.cursusName !== hourlyPlanningArray[j].cursusName
              &&
              cursus.cursusName !==
                getRightDayOfTheWeek(j, i, reps).slice(
                  0,
                  getRightDayOfTheWeek(j, i, reps).length - 5
                )
               
            ) {
              firstHourPlanningArray[j] = hourlyPlanningArray[j];
              hourlyPlanningArray[j] = cursus;
              cursus.hoursPerClass -= 2;
              break;
            } else if (
              i === 2 &&
              cursus.cursusName !== hourlyPlanningArray[j].cursusName &&
              cursus.cursusName !== firstHourPlanningArray[j].cursusName &&
              cursus.cursusName !==
                getRightDayOfTheWeek(j, i, reps).slice(
                  0,
                  getRightDayOfTheWeek(j, i, reps).length - 5
                )
            ) {
              secondHourPlanningArray[j] = hourlyPlanningArray[j];
              hourlyPlanningArray[j] = cursus;
              cursus.hoursPerClass -= 2;
              break;
            } else if (
              i === 3 &&
              cursus.cursusName !== hourlyPlanningArray[j].cursusName &&
              cursus.cursusName !== secondHourPlanningArray[j].cursusName &&
              cursus.cursusName !== firstHourPlanningArray[j].cursusName &&
              cursus.cursusName !==
                getRightDayOfTheWeek(j, i, reps).slice(
                  0,
                  getRightDayOfTheWeek(j, i, reps).length - 5
                )
            ) {
              thirdHourPlanningArray[j] = hourlyPlanningArray[j];
              hourlyPlanningArray[j] = cursus;
              fourthHourPlanningArray[j] = cursus;
              cursus.hoursPerClass -= 2;
              break;
            }
          } else {
            if (
              dailyHours[i] === weeklyPlanningCursusArray[i * reps].hour &&
              cursus.cursusName !==
                getRightDayOfTheWeek(j, i, reps).slice(
                  0,
                  getRightDayOfTheWeek(j, i, reps).length - 5
                )
            ) {
              hourlyPlanningArray[j] = cursus;
              cursus.hoursPerClass -= 2;
              break;
            }
          }
        }
      }
    }
    weeklyPlanningCursusArrayC2.push(
      new cursusPerHour(
        dailyHours[i],
        hourlyPlanningArray[0].cursusName +
          " - " +
          hourlyPlanningArray[0].teacherCode,
        hourlyPlanningArray[1].cursusName +
          " - " +
          hourlyPlanningArray[1].teacherCode,
        hourlyPlanningArray[2].cursusName +
          " - " +
          hourlyPlanningArray[2].teacherCode,
        hourlyPlanningArray[3].cursusName +
          " - " +
          hourlyPlanningArray[3].teacherCode,
        hourlyPlanningArray[4].cursusName +
          " - " +
          hourlyPlanningArray[4].teacherCode
      )
    );
  }
}

function getRightDayOfTheWeek(day, iteration, repetition) {
  switch (day) {
    case 0:
      return weeklyPlanningCursusArray[iteration * repetition].monday;
    case 1:
      return weeklyPlanningCursusArray[iteration * repetition].tuesday;
    case 2:
      return weeklyPlanningCursusArray[iteration * repetition].wednesday;
    case 3:
      return weeklyPlanningCursusArray[iteration * repetition].thursday;
    case 4:
      return weeklyPlanningCursusArray[iteration * repetition].friday;
  }
}