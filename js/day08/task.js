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

// function Person(name, age) {
//   this.name = name;
//   this.age = age;
// }
// Person.compareAge = function (person1, person2) {
//   if (person1.age > person2.age) {
//     console.log(`${person1.name} is older than ${person2.name}`);
//   } else if (person1.age < person2.age) {
//     console.log(`${person2.name} is older than ${person1.name}`);
//   } else {
//     console.log(`${person1.name} is the same age as ${person2.name}`);
//   }
// };

// person1 = new Person("hashem", 30);
// person2 = new Person("ahmed", 30);
// Person.compareAge(person1, person2);

// function Person(name, id) {
//   this.name = name;
//   var _id = id;
//   this.getId = function () {
//     return _id;
//   };
// }

// let person1 = new Person("hashem", 75299);
// console.log(person1.id);
// console.log(person1.getId());

// function Person(name, age) {
//   this.name = name;
//   this.age = age;
//   this.greet = function () {
//     console.log(`hello ,${this.name`});
//   };
// }
// let person1 = new Person("hashem", 27);
// console.log(person1.name);
// console.log(person1.age);
// person1.greet();

// function Person(name, age) {
//   this.name = name;
//   this.age = age;
// }
// Person.prototype.greet = function () {
//   console.log(`my name is ${this.name`});
// };

// let person1 = new Person("hashem", 27);
// let person2 = new Person("ahmed", 27);
// person1.greet();
// person2.greet();

function CreateUser(configuration) {
    let { type, name } = configuration;
    if (type == "Admin") {
      return {
        name,
        manageUsers: function () {
          console.log(`${this.name} is managing users`);
        },
      };
    } else if (type == "Guest") {
      return {
        name,
        viewContent: function () {
          console.log(`${this.name} is viewing content`);
        },
      };
    }
  }
  
  var adminUser = CreateUser({ type: "Admin", name: "Alice" });
  adminUser.manageUsers();
  var guestUser = CreateUser({ type: "Guest", name: "Bob" });
  guestUser.viewContent();