let a = document.getElementById("val1")
let b = document.getElementById("val2")
let p = document.getElementById("result")
let btn = document.getElementById("btn")

btn.onclick= ()=>{
    let num1 = parseFloat(a.value)
    let num2 = parseFloat(b.value)
    p.value = `sum is ${num1+num2}`;
};