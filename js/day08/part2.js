// function Person(name) {
//   this.name = name;
// }
// function Student(name, school) {
//   Person.call(this, name);
//   this.school = school;
// }
// let Student0 = new Student("hashem", "sadat");
// // console.log(Student0.school);
// // console.log(Student0.name);

// Person.prototype.greet = function () {
//   console.log(my name is ${this.name});
// };

// Student.prototype = Object.create(Person.prototype);
// Student.prototype.constructor = Student;
// Student.prototype.greet = function () {
//   console.log(`my name is ${this.name} and my school is ${this.school}`);
// };
// let person1 = new Person("ahmed");
// let Student1 = new Student("hashem", "sadat");
// console.log(person1.greet());
// console.log(Student1.greet());

function Person(name, age) {
  this.name = name;
  this.age = age;
}
Person.compareAge = function (person1, person2) {
  if (person1.age > person2.age) {
    console.log(`${person1.name} is older than ${person2.name}`);
  } else if (person1.age < person2.age) {
    console.log(`${person2.name} is older than ${person1.name}`);
  } else {
    console.log(`${person1.name} is the same age as ${person2.name}`);
  }
};

person1 = new Person("hashem", 30);
person2 = new Person("ahmed", 30);
Person.compareAge(person1, person2);

function Person(name, id) {
  this.name = name;
  var _id = id;
  this.getId = function () {
    return _id;
  };
}

let person1 = new Person("hashem", 75299);
console.log(person1.id);
console.log(person1.getId());


