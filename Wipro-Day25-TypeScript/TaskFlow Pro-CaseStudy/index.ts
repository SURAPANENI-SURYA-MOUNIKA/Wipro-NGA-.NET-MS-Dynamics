interface Task {
  id: number;
  title: string;
  completed: boolean;
}

function createTask(id: number, title: string): Task {
  return {
    id,
    title,
    completed: false
  };
}

function completeTask(task: Task): Task {
  return { ...task, completed: true };
}

const task1 = createTask(1, "Initialize TypeScript tooling");
const task2 = completeTask(task1);

console.log("Task Created:", task1);
console.log("Task Completed:", task2);
