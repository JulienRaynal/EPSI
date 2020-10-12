function missingTeacher(codeFormateur) {
    resetCursusArray();

    for(let i = 0; i < cursusArray.length; i++) {
        if (cursusArray[i].teacherCode == codeFormateur) {
            cursusArray.splice(i, 1);
        }
    }
    for(let i = 0; i < cursusArrayC2.length; i++) {
        if (cursusArrayC2[i].teacherCode == codeFormateur) {
            cursusArrayC2.splice(i, 1);
        }
    }
    for (let i = 0; i < teachers.length; i++) {
        if (teachers[i] == codeFormateur) {
            teachers.splice(i, 1);
        }
    }

    calledFunctions.push(missingTeacher);
    main();
}