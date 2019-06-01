open System
//5.5.1. Напишите функцию g(n) = n + 5 без использования анонимной функции, и в комментариях укажите её тип.
let g n = n + 5 //int->int
let f = g 5
//printfn "%d"f

//5.5.2. Реализуйте функцию gg(n) = n + 5 с помощью лямбда-функции.
let gg = fun n -> n + 5
//printfn"%d" (gg 52)

//5.5.3. Напишите функцию h(x,y) (тип float * float -> float), где h(x,y) вычисляет корень из суммы квадратов параметров. 
//Для расчёта корня используйте стандартную функцию System.Math.Sqrt.
let h (x,y) = System.Math.Sqrt(x * x + y * y)
let r = h (3.0, 6.2) 
//printfn "%f" r
