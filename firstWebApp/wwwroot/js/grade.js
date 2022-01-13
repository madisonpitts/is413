$("#calcbutton").click(function () {
  
    var assignment = $("#assignment").val();
    var groupproject = $("#groupproject").val();
    var quizzes = $("#quizzes").val();
    var exams = $("#exams").val();
    var intex = $("#intex").val();

    var assignmentweight = .55 * assignment;
    var projectweight = .05 * groupproject;
    var quizweight = .10 * quizzes;
    var examweight = .20 * exams;
    var intexweight = .10 * intex;
    var numericgrade = parseFloat(assignmentweight) + parseFloat(projectweight) + parseFloat(quizweight) + parseFloat(examweight) + parseFloat(intexweight);



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

    alert("You will receive a " + numericgrade + "% in the class which results in a " + lettergrade)
})