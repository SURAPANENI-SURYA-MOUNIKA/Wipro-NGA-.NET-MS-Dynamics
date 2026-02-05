// TypeScript allows explicit typing.
let message: string = "Hello, TypeScript!"; 
// In above line, we declare a variable 'message' of type 'string' and assign it a value.
console.log(message);
let age  = 30; // TypeScript infers the type as number
console.log(`I am ${age} years old.`);
let isActive: boolean = true;
if (isActive) { 
    console.log("The user is active.");
} else {
    console.log("The user is not active.");
}