export default class User{
    id: number;
    firstName: string;
    lastName: string;
    city: string;
    age: number;

    constructor(id: number, firstName: string, lastName:string, city: string, age: number){
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.city = city;
        this.age = age;
    }
}