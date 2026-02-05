// importdemo.ts

import { Calculator } from './classCalculator';   // ← matches exported class name

const num1 = 15;
const num2 = 3;

console.log(`Addition:       ${Calculator.add(num1, num2)}`);
console.log(`Subtraction:    ${Calculator.subtract(num1, num2)}`);
console.log(`Multiplication: ${Calculator.multiply(num1, num2)}`);
console.log(`Division:       ${Calculator.divide(num1, num2)}`);

console.log("\n--- Testing division by zero ---");
try {
    console.log(Calculator.divide(10, 0));   // ← must use Calculator. (capital C)
} catch (error) {
    console.log("Error caught:", (error as Error).message);
}