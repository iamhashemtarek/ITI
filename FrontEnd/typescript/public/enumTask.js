"use strict";
// -- enum -- week days -- create function (day)==> {if(this day is a weekend or not)}
var WeekDays;
(function (WeekDays) {
    WeekDays["Saturday"] = "Saturday";
    WeekDays["Sunday"] = "Sunday";
    WeekDays["Monday"] = "Monday";
    WeekDays["Tuesday"] = "Tuesday";
    WeekDays["Wednesday"] = "Wednesday";
    WeekDays["Thursday"] = "Thursday";
    WeekDays["Friday"] = "Friday";
})(WeekDays || (WeekDays = {}));
function checkWeekend(day) {
    if (day === WeekDays.Friday || day === WeekDays.Saturday) {
        console.log(`It's a weekend`);
    }
    else {
        console.log(`It's not a weekend`);
    }
}
