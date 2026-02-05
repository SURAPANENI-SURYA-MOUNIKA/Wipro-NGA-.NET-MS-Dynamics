// oops.ts
// Complete demonstration of Object-Oriented Programming concepts in TypeScript

// ────────────────────────────────────────────────
// 1. Base Class
// ────────────────────────────────────────────────
class Person {
    private _name: string;
    protected _age: number;
    public readonly country: string = "India";

    constructor(name: string, age: number) {
        this._name = name;
        this._age = age;
    }

    public introduce(): void {
        console.log(`Hello, my name is ${this._name} and I am ${this._age} years old.`);
    }

    public get name(): string {
        return this._name;
    }

    public set name(newName: string) {
        if (newName.trim().length >= 2) {
            this._name = newName.trim();
        } else {
            console.warn("Name must be at least 2 characters long.");
        }
    }

    public showCountry(): void {
        console.log(`Country: ${this.country}`);
    }
}

// ────────────────────────────────────────────────
// 2. Inheritance
// ────────────────────────────────────────────────
class Employee extends Person {
    private employeeId: number;
    public department: string;

    constructor(name: string, age: number, employeeId: number, department: string = "General") {
        super(name, age);
        this.employeeId = employeeId;
        this.department = department;
    }

    public introduce(): void {
        console.log(
            `Hi, I'm ${this.name}, ${this._age} years old, ` +
            `Employee ID: ${this.employeeId}, Department: ${this.department}`
        );
    }

    public work(): void {
        console.log(`${this.name} (ID: ${this.employeeId}) is working in ${this.department}`);
    }
}

// ────────────────────────────────────────────────
// 3. Interface
// ────────────────────────────────────────────────
interface ManagerResponsibilities {
    manageTeam(): void;
    conductReview(employeeName: string): void;
}

// ────────────────────────────────────────────────
// 4. Class with inheritance + interface
// ────────────────────────────────────────────────
class Manager extends Employee implements ManagerResponsibilities {
    constructor(name: string, age: number, employeeId: number, department: string) {
        super(name, age, employeeId, department);
    }

    public manageTeam(): void {
        console.log(`${this.name} is managing the ${this.department} team.`);
    }

    public conductReview(employeeName: string): void {
        console.log(`${this.name} is conducting review for ${employeeName}.`);
    }

    public introduce(): void {
        super.introduce();
        console.log("→ Also serving as a Manager.");
    }
}

// ────────────────────────────────────────────────
// Demo / Usage
// ────────────────────────────────────────────────

console.log("=== Person ===");
const p1 = new Person("Alice", 30);
p1.introduce();
p1.showCountry();

console.log("\n=== Employee ===");
const e1 = new Employee("Bob", 28, 101, "Development");
e1.introduce();
e1.work();

console.log("\n=== Manager ===");
const m1 = new Manager("Charlie", 42, 5001, "Engineering");
m1.introduce();
m1.work();
m1.manageTeam();
m1.conductReview("Bob");

// Getter / Setter demo
console.log("\nName before:", m1.name);
m1.name = "Charles";
console.log("Name after:", m1.name);