var x = "Hello world";
console.log(x);

let number1 = 10; 
let number2 = 3.14;
console.log(typeof number1, typeof number2);

const string1 = "Hello";
const b1 = true;
console.log(typeof b1, b1);
const n1 = null;
console.log(typeof n1, n1);
let u1;
console.log(typeof u1, u1);
let array1 = [1, "Ahmet", true, null, {}];
console.log(typeof array1, array1, array1[2]);

let o1 = {
    name: "ahmet",
    age: 25,
    isStudent: true
}

console.log(typeof o1, o1.name, o1);

let date = new Date();
console.log(typeof date, date);

let func = function(){
    console.log("fn");
}

func();

let arrowFunc = () => {
    console.log("arrow fn");
}
arrowFunc();

function normalFn(){
    console.log("normal fn");
}

normalFn();