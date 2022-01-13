$("#calcbutton").click(function () {
  //retrieving values from inputs and assigning them values
    var assignment = $("#assignment").val();
    var groupproject = $("#groupproject").val();
    var quizzes = $("#quizzes").val();
    var exams = $("#exams").val();
    var intex = $("#intex").val();
    //calculating the grade weight based off of the class weight from the syllabus
    var assignmentweight = .55 * assignment;
    var projectweight = .05 * groupproject;
    var quizweight = .10 * quizzes;
    var examweight = .20 * exams;
    var intexweight = .10 * intex;
    //adding them all together to get the final grade
    var numericgrade = parseFloat(assignmentweight) + parseFloat(projectweight) + parseFloat(quizweight) + parseFloat(examweight) + parseFloat(intexweight);


    //if statement to figure out the letter grade
    if (numericgrade >= 94) {
        var lettergrade = "A";
    } else if (numericgrade >= 90) {
        var lettergrade = "A-";
    } else if (numericgrade >= 87) {
        var lettergrade = "B+";
    } else if (numericgrade >= 84) {
        var lettergrade = "B";
    } else if (numericgrade >= 80) {
        var lettergrade = "B-";
    } else if (numericgrade >= 77) {
        var lettergrade = "C+";
    } else if (numericgrade >= 74) {
        var lettergrade = "C";
    } else if (numericgrade >= 70) {
        var lettergrade = "C-";
    } else if (numericgrade >= 67) {
        var lettergrade = "D+";
    } else if (numericgrade >= 64) {
        var lettergrade = "D";
    } else if (numericgrade >= 60) {
        var lettergrade = "D-";
    } else {
        var lettergrade = "E";
    }
    //alert to tell the user what the grade would be
    alert("You will receive a " + numericgrade + "% in the class which results in a " + lettergrade)
})