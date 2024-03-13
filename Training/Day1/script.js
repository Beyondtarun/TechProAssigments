// let a = document.getElementById("val1")
// let b = document.getElementById("val2")
// let p = document.getElementById("result")
// let btn = document.getElementById("btn")

// btn.onclick= ()=>{
//     let num1 = parseFloat(a.value)
//     let num2 = parseFloat(b.value)
//     p.value = `sum is ${num1+num2}`;
// };

// let color = document.getElementById("color").value;
// let box = document.getElementById("box")
// let colorInput = color.value;
// let a =[];
// let str="";

let btn = document.getElementById("btn");

// btn.onclick = () => {
//   // let str="";
//   let color = document.getElementById("color").value;
//   let box = document.getElementById("box");
//   let a = [];
//   let str = "";
//   // for(let i =colorInput.length-1 ; i>=0;i--){
//   //   str=str+colorInput.charAt(i);
//   // }
//   for (let i = 0; i < color.length; i++) {
//     a[i] = color.charAt(i);
//   }

//   for (let i = a.length - 1; i >= 0; i--) {
//     str = str + a[i];
//   }

//   box.innerHTML = str;
// };

btn.onclick = () => {
  let color = document.getElementById("color").value;
  let str = "";
  let a = color.split(" ");
  for (let i = 0; i < a.length; i++) {
    a[i]=a[i].charAt(0).toUpperCase() + a[i].slice(1);
    str = str + " " + a[i];
  }

  document.getElementById("box").innerHTML = str;
};
