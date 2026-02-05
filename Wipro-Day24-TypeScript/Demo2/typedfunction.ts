// OPtional parameter just like in JavaScript we can have optional parameters in TypeScript functions
function introduce(name: string, age?: number): string {
    if (age) {
        return `Hello, ${name}! You are ${age} years old.`;
    } else {
        return `Hello, ${name}!`;
    }
}
// use case of optinal prameter is  while calling a function we may or may not provide that parameter
console.log(introduce("Alice", 25));
console.log(introduce("Bob")); // without age parameter
// Default parameter
function multiply(a: number, b: number = 2): number {
    return a * b;
}