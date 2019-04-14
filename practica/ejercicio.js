//1
console.log("ejercicio 1");
var anio = 2015;
console.log(anio);

//2
console.log("ejercicio 2");
var nombre = "luis";
console.log(nombre);

//3 
console.log("ejercicio 3");
var ids = [10,20,30];
console.log(ids);

//4 
console.log("ejercicio 4");
var nombres = ['A','B','C'];
console.log(nombres);

//6
console.log("ejercicio 6");
var  producto = {"id":100,"nombre":"EFG"};
console.log(producto);

//7
console.log("ejercicio 7");
for (var i = 0; i < 11; i++) {
    console.log(i);
}

//8 
console.log("ejercicio 8");
function saludar() {
    console.log("Hola amigos");
}

saludar();

//9
console.log("ejercicio 9");
function sumar(a,b){
    console.log(a + b);
}
sumar(5,5);

//10 
console.log("ejercicio 10");
function contar(a,b)
{
    var cuenta = null;
    for (var i = 0; i < a.length; i++) {
        if (a[i] == b) {
            cuenta++;
        } 
    }
    console.log(cuenta);
}
contar([4,4,4,4],4);