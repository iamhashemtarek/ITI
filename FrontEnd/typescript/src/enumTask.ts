// -- enum -- week days -- create function (day)==> {if(this day is a weekend or not)}


enum WeekDays {
    Saturday = "Saturday",
    Sunday = "Sunday",
    Monday = "Monday",
    Tuesday = "Tuesday",
    Wednesday = "Wednesday",
    Thursday = "Thursday",
    Friday = "Friday",
    }

function checkWeekend(day: WeekDays): void {
    if (day === WeekDays.Friday || day === WeekDays.Saturday) {
        console.log(`It's a weekend`);
    } else {
        console.log(`It's not a weekend`);
    }
}

