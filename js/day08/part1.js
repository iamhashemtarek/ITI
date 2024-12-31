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