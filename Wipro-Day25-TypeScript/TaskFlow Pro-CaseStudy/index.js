"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function createTask(id, title) {
    return {
        id,
        title,
        completed: false
    };
}
function completeTask(task) {
    return { ...task, completed: true };
}
const task1 = createTask(1, "Initialize TypeScript tooling");
const task2 = completeTask(task1);
console.log("Task Created:", task1);
console.log("Task Completed:", task2);
//# sourceMappingURL=index.js.map