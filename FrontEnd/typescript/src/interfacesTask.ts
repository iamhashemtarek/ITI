// -- create Interface IEmplyee id,fname,lname,age,salary,address:{city,street,zCode}
// -- create class Employee Implement IEmplyee -- getSalary
// -- create class Manager extened Employee -- show Employee Data (empId){show emp data}

interface IAddress {
  city: string;
  street: string;
  zCode: number;
}

interface IEmployee {
  id: number;
  fname: string;
  lname: string;
  age: number;
  salary: number;
  address: IAddress;
}

class Employee implements IEmployee {
  constructor(
    public id: number,
    public fname: string,
    public lname: string,
    public age: number,
    public salary: number,
    public address: IAddress
  ) {
    this.id = id;
    this.fname = fname;
    this.lname = lname;
    this.age = age;
    this.salary = salary;
    this.address = address;
  }

  getSalary(): number {
    return this.salary;
  }
}

class Manager extends Employee {
  showEmployeeData(empId: number): void {
    if (this.id === empId) {
      console.log(this);
    }
  }
}

const address: IAddress = {
  city: "berket elsabaa",
  street: "bla bla",
  zCode: 111,
};

const employee = new Employee(1, "hashem", "tarek", 24, 111, address);

console.log(employee.getSalary());

