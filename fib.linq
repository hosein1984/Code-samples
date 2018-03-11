// This function iterate endlessly given an input and a 
// transformation function
let iterate f x = 
    let rec loop x = seq {
        yield x 
        yield! loop (f x)
        }
    loop x

// Generates the next fibonnachi number from the previous two
let fib (a,b) = (b,a+b)

// Generates fibonnachi numbers up to 'n'
// This function works linearly
let fibUpTo n =
    (1,1)
    |> iterate fib
    |> Seq.map fst
    |> Seq.take n
    |> Seq.iter (printfn "%d")

fibUpTo 10