import User from "./user.ts";

export default class Employee extends User {
    salary: number;
    
    constructor(id: number, firstName: string, lastName: string, city: string, age: number, salary: number) {
        super(id, firstName, lastName, city, age);
        this.salary = salary;
    }
}