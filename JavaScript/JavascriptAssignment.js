// Problem 1
let salaries = {
  John: 100,
  Ann: 160,
  Pete: 130
}
let sum = 0;
for (let key in salaries) {
  sum += salaries[key];
}

console.log(sum);


// Problem 2
let menu = {
  width: 200,
  height: 300,
  title: "My menu"};

function multiplyNumeric(menu){
  for (let key in menu){
    if (typeof menu[key]=="number"){
      menu[key] *=2;
    }
  }
};
multiplyNumeric(menu);
console.log(menu);

//Problem 3
function checkEmailId(str){
  var validFormat=/@\w+([\.-]?\w+)*\./;
  if (str.match(validFormat)){
    return true
  }
  else{
    return false
  }
}
console.log(checkEmailId("abc.hfgh@gator.uhd.edu"));
console.log(checkEmailId("abc@gmail.com"));
console.log(checkEmailId("abc.hfgh@gator"));

//Problem 4
function truncate(str, maxlength){
  if (str.length > maxlength){
    return str.slice(0, maxlength - 1) + '…'
  }
  else{
    return str
  }
}
console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));

//Problem 5
var names = [ 'James','Brennie'];
console.log(names);

names.push('Robert');
console.log(names);

var len = names.length;
if (len%2==1){;
  names[Math.floor(len/2)]='Calvin';
}
console.log(names);

console.log(names.shift())
console.log(names);

names.unshift('Rose','Regal');
console.log(names);

