function displayTeacherPlanning(teacherToKeep) {
    startingDate = new Date("2020-09-02");
  let teacherPlanningArray = new Array(0);

  for (let i = 0; i < weeklyPlanningCursusArrayC2.length; i++) {
      if ((i + 1) % 4 === 0 || i === 31) {
        console.log(
            `Planning du ${addDays(i === 0 ? 0 : 3)} au ${addDays(5)} / formateur : ${teacherToKeep}`
          );
      }
    for (let j = 0; j < 5; j++) {
      getRightDayOfTheWeekForTeacherC2(i, j, teacherToKeep);
    }
    teacherPlanningArray.push(weeklyPlanningCursusArrayC2[i]);

    if ((i > 0 && (i + 1) % 4 === 0) || i === 31) {
      let transformedWeeklyPlanning = teacherPlanningArray.reduce(
        (acc, { hour, ...x }) => {
          acc[hour] = x;
          return acc;
        },
        {}
      );

      console.table(transformedWeeklyPlanning);
    }
  }
}

function getRightDayOfTheWeekForTeacherC2(iteration, repetition, teacherToKeep) {
  switch (repetition) {
    case 0:
        if (weeklyPlanningCursusArrayC2[iteration].monday.slice(weeklyPlanningCursusArrayC2[iteration].monday.length - 2, weeklyPlanningCursusArrayC2[iteration].monday.length) != teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].monday = " ";
        } if (weeklyPlanningCursusArray[iteration].monday.slice(weeklyPlanningCursusArray[iteration].monday.length - 2, weeklyPlanningCursusArray[iteration].monday.length) == teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].monday = weeklyPlanningCursusArray[iteration].monday.slice(0, weeklyPlanningCursusArray[iteration].monday.length - 4) + " - C1";
        } else if (weeklyPlanningCursusArrayC2[iteration].monday.slice(weeklyPlanningCursusArrayC2[iteration].monday.length - 2, weeklyPlanningCursusArrayC2[iteration].monday.length) == teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].monday = weeklyPlanningCursusArrayC2[iteration].monday.slice(0, weeklyPlanningCursusArrayC2[iteration].monday.length - 4) + " - C2";
        };
        break;
    case 1:
        if (weeklyPlanningCursusArrayC2[iteration].tuesday.slice(weeklyPlanningCursusArrayC2[iteration].tuesday.length - 2, weeklyPlanningCursusArrayC2[iteration].tuesday.length) != teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].tuesday = " ";
        } if (weeklyPlanningCursusArray[iteration].tuesday.slice(weeklyPlanningCursusArray[iteration].tuesday.length - 2, weeklyPlanningCursusArray[iteration].tuesday.length) == teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].tuesday = weeklyPlanningCursusArray[iteration].tuesday.slice(0, weeklyPlanningCursusArray[iteration].tuesday.length - 4) + " - C1";
        } else if (weeklyPlanningCursusArrayC2[iteration].tuesday.slice(weeklyPlanningCursusArrayC2[iteration].tuesday.length - 2, weeklyPlanningCursusArrayC2[iteration].tuesday.length) == teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].tuesday = weeklyPlanningCursusArrayC2[iteration].tuesday.slice(0, weeklyPlanningCursusArrayC2[iteration].tuesday.length - 4) + " - C2";
        };
        break;
    case 2:
        if (weeklyPlanningCursusArrayC2[iteration].wednesday.slice(weeklyPlanningCursusArrayC2[iteration].wednesday.length - 2, weeklyPlanningCursusArrayC2[iteration].wednesday.length) != teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].wednesday = " ";
        } if (weeklyPlanningCursusArray[iteration].wednesday.slice(weeklyPlanningCursusArray[iteration].wednesday.length - 2, weeklyPlanningCursusArray[iteration].wednesday.length) == teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].wednesday = weeklyPlanningCursusArray[iteration].wednesday.slice(0, weeklyPlanningCursusArray[iteration].wednesday.length - 4) + " - C1";
        }else if (weeklyPlanningCursusArrayC2[iteration].wednesday.slice(weeklyPlanningCursusArrayC2[iteration].wednesday.length - 2, weeklyPlanningCursusArrayC2[iteration].wednesday.length) == teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].wednesday = weeklyPlanningCursusArrayC2[iteration].wednesday.slice(0, weeklyPlanningCursusArrayC2[iteration].wednesday.length - 4) + " - C2";
        };
        break;
    case 3:
        if (weeklyPlanningCursusArrayC2[iteration].thursday.slice(weeklyPlanningCursusArrayC2[iteration].thursday.length - 2, weeklyPlanningCursusArrayC2[iteration].thursday.length) != teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].thursday = " ";
        } if (weeklyPlanningCursusArray[iteration].thursday.slice(weeklyPlanningCursusArray[iteration].thursday.length - 2, weeklyPlanningCursusArray[iteration].thursday.length) == teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].thursday = weeklyPlanningCursusArray[iteration].thursday.slice(0, weeklyPlanningCursusArray[iteration].thursday.length - 4) + " - C1";
        } else  if (weeklyPlanningCursusArrayC2[iteration].thursday.slice(weeklyPlanningCursusArrayC2[iteration].thursday.length - 2, weeklyPlanningCursusArrayC2[iteration].thursday.length) == teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].thursday = weeklyPlanningCursusArrayC2[iteration].thursday.slice(0, weeklyPlanningCursusArrayC2[iteration].thursday.length - 4) + "- C2";
        };
        break;
    case 4:
        if (weeklyPlanningCursusArrayC2[iteration].friday.slice(weeklyPlanningCursusArrayC2[iteration].friday.length - 2, weeklyPlanningCursusArrayC2[iteration].friday.length) != teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].friday = " ";
        }  if (weeklyPlanningCursusArray[iteration].friday.slice(weeklyPlanningCursusArray[iteration].friday.length - 2, weeklyPlanningCursusArray[iteration].friday.length) == teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].friday = weeklyPlanningCursusArray[iteration].friday.slice(0,  weeklyPlanningCursusArray[iteration].friday.length - 4) + " - C1";
        } else if (weeklyPlanningCursusArrayC2[iteration].friday.slice(weeklyPlanningCursusArrayC2[iteration].friday.length - 2, weeklyPlanningCursusArrayC2[iteration].friday.length) == teacherToKeep){
            weeklyPlanningCursusArrayC2[iteration].friday = weeklyPlanningCursusArrayC2[iteration].friday.slice(0,  weeklyPlanningCursusArrayC2[iteration].friday.length - 4) + " - C2";
        };
        break;
  }
}