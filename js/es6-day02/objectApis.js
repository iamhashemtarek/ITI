const displayCourseInfo = (course) => {
    const defaults = {
        name: 'N/A',
        duration: 'N/A',
        owner: 'N/A'
    }

    Object.assign(defaults, course);

    console.log(defaults);
}

displayCourseInfo({
    name: 'OOP',
    duration: 20
})
