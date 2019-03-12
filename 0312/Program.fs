let increment x =
  x + 1

let f y =
  let increment x =
    x + 1
  let y = 42 /////////
  let increment x = x - 1 + 1 + 1
  y + 1

let sum a b c =
  a + b + c

// currying
let sum2 =
  function a -> (function b -> (function c -> a + b + c))

// fun keyword
let sum3 =
  // fun a -> fun b -> fun c -> a + b + c
  fun a b c -> a + b + c

let sum4 a b c = a + b + c

let result2 =
  sum2 1 2 3 // syntactic sugar for (((sum2 1) 2) 3)

let g (x: int) =
  x + 1


let sqrt x =
  let initialGuess = 1.0
  let isGoodEnough guess x =
    let threshold = 0.0001
    abs (guess * guess - x) < threshold
  let improve guess x =
    (guess + (x / guess)) / 2.0
  let rec newton guess x =
    if isGoodEnough guess x then guess
    else newton (improve guess x) x

  newton initialGuess x

[<EntryPoint>]
let main argv =
  increment 1
  // REPL

