module Chapter1

let rec fact = function
    | 0 -> 1
    | n -> n * fact (n - 1);;

let out = fact 4;;

let rec power = function    
    | (x, 0) -> 1
    | (x, n) -> x * power (x, n - 1);; 

let out1 = power (4, 4);;

let g n = n + 4;;

let ex2 x y = System.Math.Sqrt (x * x + y * y);;

let ex2out = ex2 2.1 3.3;;

let rec ex4 = function 
    | 1 -> 1
    | n -> n + ex4 (n - 1);;

let rec fibonacci = function
    | 0 -> 0
    | 1 -> 1
    | n -> fibonacci (n - 1) + fibonacci (n - 2);;
    
let fibout = fibonacci 4;;  

let rec ex6 = function
    | (m, 0) -> 0
    | (m, n) -> (m + n) + ex6 ((m, (n - 1)));;
    
let fizzBuzz n =
    let mod3 = n % 3 = 0 in
    let mod5 = n % 5 = 0 in
    printf "%d-d\n" n
    match (mod3, mod5) with
    | (true, false) -> "fizz"
    | (false, true) -> "Buzz"
    | (true, true) -> "fizzBuzz"
    | (_, _) -> n.ToString();;

(seq { 1 .. 100})
    |>  
    Seq.map 
        (fizzBuzz)  
    |> Seq.iter 
        (printf "%s\n");;