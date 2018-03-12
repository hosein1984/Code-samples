let iterate f x = 
    let rec loop x = seq {
        yield x 
        yield! loop (f x)
        }
    loop x

let fib (a,b) = (b,a+b)


let infFib =
    (1,1)
    |> iterate fib
    |> Seq.map fst

infFib 
|> Seq.takeWhile (fun x -> x < 4000000)
|> Seq.where (fun x -> x % 2 = 0)
|> Seq.sum
|> printfn "%A"