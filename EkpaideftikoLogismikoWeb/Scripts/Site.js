if (typeof usetimer !== 'undefined') {
    SetTimerText();
    console.log("timer");
    var timer = setInterval(TimerTick, 1000);
}

$(".main-menu-action").click(function () {
    var action = this.getAttribute("action");
    window.location.href = "/" + action + "/" + action;
});

$(".unit").click(function () {
    window.location.href = "/Units/Unit/" + this.id;
});

$(".person").click(function () {
    var id = this.id;
    $.ajax({
        url: '/Units/Info',
        data: {
            person: id,
            format: 'json'
        },
        error: function () {
            
        },
        dataType: 'json',
        success: function (data) {
            $('#name').html(data.name);
            $('#img').attr('src', "/Content/Images/People/" + id + ".jpg");
            $('#birthdate').html(data.birthdate);
            $('#birthplace').html(data.birthplace);
            $('#deathdate').html(data.deathdate);
            $('#deathplace').html(data.deathplace);
            $('#desc').html(data.desc);
        },
        type: 'POST'
    });
    $("#detailsModal").modal('toggle');
});

$("#questionSubmit").click(function () {
    CheckAnswer();
    ResetTimer();
    RenderQuestion();
})

$("#restart").click(function () {
    location.reload();
});

function RenderQuestion() {
    i++;
    if (i == totalQuestions) {
        clearInterval(timer);
        $("#questionForm").hide();
        $("#score").html('Επιτυχία: ' + parseInt(correctAnswers / totalQuestions * 100) + '%');
        $("#end").css('visibility', 'visible');
    }
    else {
        $("#questionCounter").html("Ερώτηση " + (i + 1) + "/" + totalQuestions);
        $("#questionText").html(questions[i].Text);
        var answers = questions[i].Answers;
        $("#answer0Label").html(answers[0].Text);
        $("#answer1Label").html(answers[1].Text);
        $("#answer2Label").html(answers[2].Text);
        $("#answer3Label").html(answers[3].Text);
    }
}

function CheckAnswer() {
    var answer = $('input[name="answer"]:checked').val();
    if (typeof answer !== 'undefined') {
        if (questions[i].Answers[parseInt(answer)].Value) {
            correctAnswers++;
        }
    }
}

function TimerTick() {
    time--;
    SetTimerText();
    if (time == 0) {
        ResetTimer();
        RenderQuestion();
    }
}

function SetTimerText() {
    if (time == 60) {
        $('#timer').html('01:00');
    }
    else if (time > 9) {
        $('#timer').html('00:' + time);
    }
    else if (time > -1) {
        $('#timer').html('00:0' + time);
    }
}

function ResetTimer() {
    time = 30;
    SetTimerText();
}