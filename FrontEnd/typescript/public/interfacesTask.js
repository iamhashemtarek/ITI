"use strict";
// -- create Interface IEmplyee id,fname,lname,age,salary,address:{city,street,zCode}
// -- create class Employee Implement IEmplyee -- getSalary
// -- create class Manager extened Employee -- show Employee Data (empId){show emp data}
class Employee {
    constructor(id, fname, lname, age, salary, address) {
        this.id = id;
        this.fname = fname;
        this.lname = lname;
        this.age = age;
        this.salary = salary;
        this.address = address;
        this.id = id;
        this.fname = fname;
        this.lname = lname;
        this.age = age;
        this.salary = salary;
        this.address = address;
    }
    getSalary() {
        return this.salary;
    }
}
class Manager extends Employee {
    showEmployeeData(empId) {
        if (this.id === empId) {
            console.log(this);
        }
    }
}
const address = {
    city: "berket elsabaa",
    street: "bla bla",
    zCode: 111,
};
const employee = new Employee(1, "hashem", "tarek", 24, 111, address);
console.log(employee.getSalary());
