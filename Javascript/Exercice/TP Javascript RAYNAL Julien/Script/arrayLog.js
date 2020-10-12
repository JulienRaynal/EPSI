let startingDate = new Date("2020-09-02");
const dailyHours = ["8-10h", "10-12h", "14-16h", "16-18h"];
const classes = ["C1", "C2"];
const teachers = ["P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8"];
const days = ["monday", "tuesday", "wednesday", "thursday", "friday"];
let calledFunctions = [];

let weeklyPlanningCursusArray = new Array();
let weeklyPlanningCursusArrayC2 = new Array();

let hourlyPlanningArray = new Array();

let firstHourPlanningArray = new Array();
let secondHourPlanningArray = new Array();
let thirdHourPlanningArray = new Array();
let fourthHourPlanningArray = new Array();

let sortedCursusLimitDateArray = new Array();
let sortedCursusWithoutLimitDateArray = new Array();

let sortedCursusLimitDateArrayC2 = new Array();
let sortedCursusWithoutLimitDateArrayC2 = new Array();

class Cursus {
  constructor(cursusName, teacherCode, hoursPerClass, limiteDate = null) {
    this.cursusName = cursusName;
    this.teacherCode = teacherCode;
    this.hoursPerClass = hoursPerClass;
    this.limiteDate = limiteDate;
  }
  setHours(hours) {
    this.hoursPerClass -= hours;
  }
}

function resetCursusArray() {
  cursusArray= [];
  cursusArray = [
    new Cursus("R1", "P1", 20, new Date("2020-09-20")),
    new Cursus("SE1", "P2", 80, new Date("2020-10-01")),
    new Cursus("MO1", "P3", 30, new Date("2020-09-30")),
    new Cursus("PK5", "P4", 60),
    new Cursus("NI8", "P5", 10, new Date("2020-09-15")),
    new Cursus("BO8", "P1", 8),
    new Cursus("BU1", "P2", 14, new Date("2020-09-30")),
    new Cursus("AF4", "P1", 50),
    new Cursus("AD6", "P5", 48),
    new Cursus("GR5", "P7", 36),
    new Cursus("TR7", "P8", 30),
    new Cursus("FG8", "P6", 26),
    new Cursus("BG5", "P5", 18),
  ];
  
  cursusArrayC2 = [];
  cursusArrayC2 = [
    new Cursus("R1", "P1", 20, new Date("2020-09-20")),
    new Cursus("SE1", "P2", 80, new Date("2020-10-01")),
    new Cursus("MO1", "P3", 30, new Date("2020-09-30")),
    new Cursus("PK5", "P4", 60),
    new Cursus("NI8", "P5", 10, new Date("2020-09-15")),
    new Cursus("BO8", "P1", 8),
    new Cursus("BU1", "P2", 14, new Date("2020-09-30")),
    new Cursus("AF4", "P1", 50),
    new Cursus("AD6", "P5", 48),
    new Cursus("GR5", "P7", 36),
    new Cursus("TR7", "P8", 30),
    new Cursus("FG8", "P6", 26),
    new Cursus("BG5", "P5", 18),
  ];
}
let cursusArray = [
  new Cursus("R1", "P1", 20, new Date("2020-09-20")),
  new Cursus("SE1", "P2", 80, new Date("2020-10-01")),
  new Cursus("MO1", "P3", 30, new Date("2020-09-30")),
  new Cursus("PK5", "P4", 60),
  new Cursus("NI8", "P5", 10, new Date("2020-09-15")),
  new Cursus("BO8", "P1", 8),
  new Cursus("BU1", "P2", 14, new Date("2020-09-30")),
  new Cursus("AF4", "P1", 50),
  new Cursus("AD6", "P5", 48),
  new Cursus("GR5", "P7", 36),
  new Cursus("TR7", "P8", 30),
  new Cursus("FG8", "P6", 26),
  new Cursus("BG5", "P5", 18),
];

let cursusArrayC2 = [
  new Cursus("R1", "P1", 20, new Date("2020-09-20")),
  new Cursus("SE1", "P2", 80, new Date("2020-10-01")),
  new Cursus("MO1", "P3", 30, new Date("2020-09-30")),
  new Cursus("PK5", "P4", 60),
  new Cursus("NI8", "P5", 10, new Date("2020-09-15")),
  new Cursus("BO8", "P1", 8),
  new Cursus("BU1", "P2", 14, new Date("2020-09-30")),
  new Cursus("AF4", "P1", 50),
  new Cursus("AD6", "P5", 48),
  new Cursus("GR5", "P7", 36),
  new Cursus("TR7", "P8", 30),
  new Cursus("FG8", "P6", 26),
  new Cursus("BG5", "P5", 18),
];

class cursusPerHour {
  constructor(hour, monday, tuesday, wednesday, thursday, friday) {
    this.hour = hour;
    this.monday = monday;
    this.tuesday = tuesday;
    this.wednesday = wednesday;
    this.thursday = thursday;
    this.friday = friday;
  }
}
function sortCursus() {
  sortedCursusLimitDateArray = new Array();
  sortedCursusWithoutLimitDateArray = new Array();

  sortedCursusLimitDateArrayC2 = new Array();
  sortedCursusWithoutLimitDateArrayC2 = new Array();

  cursusArray.sort((a, b) => b.hoursPerClass - a.hoursPerClass);

  sortArrayWithDatesLimit(cursusArray, sortedCursusLimitDateArray);
  sortArrayWithoutDatesLimit(cursusArray, sortedCursusWithoutLimitDateArray);

  sortArrayWithDatesLimit(cursusArrayC2, sortedCursusLimitDateArrayC2);
  sortArrayWithoutDatesLimit(
    cursusArrayC2,
    sortedCursusWithoutLimitDateArrayC2
  );

  cursusArray = sortedCursusLimitDateArray.concat(
    sortedCursusWithoutLimitDateArray
  );

  cursusArrayC2 = sortedCursusLimitDateArrayC2.concat(
    sortedCursusWithoutLimitDateArrayC2
  );
}

function cleanCursus() {
  weeklyPlanningCursusArray = new Array();
  weeklyPlanningCursusArrayC2 = new Array();

  hourlyPlanningArray = new Array();

  firstHourPlanningArray = new Array();
  secondHourPlanningArray = new Array();
  thirdHourPlanningArray = new Array();
  fourthHourPlanningArray = new Array();
}

function sortArrayWithDatesLimit(givenArray, sortedArray) {
  for (let i = 0; i < givenArray.length; i++) {
    if (givenArray[i].limiteDate !== null) {
      sortedArray.push(givenArray[i]);
    }
  }
  sortedArray.sort((a, b) => b.hoursPerClass - a.hoursPerClass);
}

function sortArrayWithoutDatesLimit(givenArray, sortedArray) {
  for (let i = 0; i < givenArray.length; i++) {
    if (givenArray[i].limiteDate === null) {
      sortedArray.push(givenArray[i]);
    }
  }
  sortedArray.sort((a, b) => b.hoursPerClass - a.hoursPerClass);
}

let class1Array = new Array();
let class2Array = new Array();

let formattedDate = startingDate
  .toLocaleDateString("en-GB", {
    day: "numeric",
    month: "numeric",
  })
  .replace(/ /g, "/");

function addDays(daysToAdd) {
  startingDate.setDate(startingDate.getDate() + daysToAdd);
  return (formattedDate = startingDate
    .toLocaleDateString("en-GB", {
      day: "numeric",
      month: "numeric",
    })
    .replace(/ /g, "/"));
}

function planningClass1() {
  startingDate = new Date("2020-09-02");
  for (let i = 0; i < 8; i++) {
    console.log(
      `Planning du ${addDays(i === 0 ? 0 : 3)} au ${addDays(5)} / classe : C1`
    );
    createGlobalPlanningC1(
      cursusArray,
      hourlyPlanningArray,
      firstHourPlanningArray,
      secondHourPlanningArray,
      thirdHourPlanningArray,
      weeklyPlanningCursusArray
    );

    let transformedWeeklyPlanning = weeklyPlanningCursusArray.reduce(
      (acc, { hour, ...x }) => {
        acc[hour] = x;
        return acc;
      },
      {}
    );

    console.table(transformedWeeklyPlanning);
  }
}

function planningClass2() {
  startingDate = new Date("2020-09-02");
  for (let i = 0; i < 8; i++) {
    console.log(
      `Planning du ${addDays(i === 0 ? 0 : 3)} au ${addDays(5)} / classe : C2`
    );
    createGlobalPlanningC2(i);

    console.log(weeklyPlanningCursusArrayC2);

    let transformedWeeklyPlanning = weeklyPlanningCursusArrayC2.reduce(
      (acc, { hour, ...x }) => {
        acc[hour] = x;
        return acc;
      },
      {}
    );

    console.table(transformedWeeklyPlanning);
  }
}


function main() {
  cleanCursus();
  sortCursus();
  planningClass1();
  planningClass2();
  displayTeacherPlanning("P1");
}

main();

missingTeacher("P1");

SupprimerCour("R1");


function SupprimerCour(cursusNameDelete) {
  resetCursusArray();

  for(let i = 0; i < cursusArray.length; i++) {
      if (cursusArray[i].cursusName == cursusNameDelete) {
          cursusArray.splice(i, 1);
      }
  }
  for(let i = 0; i < cursusArrayC2.length; i++) {
      if (cursusArrayC2[i].cursusName == cursusNameDelete) {
          cursusArrayC2.splice(i, 1);
      }
  }
  main();

  // marche mais problème : faut sauvegarder les params d'une manière ou d'un autre  
  calledFunctions.push(ajoutCour);
  calledFunctions[0]("C1", "squalala", 20, new Date("2020-09-20"));
}  

function ajoutCour(nomCours, nomProfesseur, nbHeure, date) {
  resetCursusArray();
  
  cursusArray.push(new Cursus(nomCours, nomProfesseur, nbHeure, date));
  cursusArrayC2.push(new Cursus(nomCours, nomProfesseur, nbHeure, date));


}