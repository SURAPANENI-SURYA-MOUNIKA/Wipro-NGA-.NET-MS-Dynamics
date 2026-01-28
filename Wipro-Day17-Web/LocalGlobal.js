let x = "I am global variable";

function testScope(){
  let y = "I am local variable";
  console.log(x);
}
testScope();