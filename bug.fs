let mutable x = 0
let mutable y = 0

let rec loop x y =
    if x > 10 then
        y
    else
        x <- x + 1
        y <- y + x
        loop x y

let result = loop 0 0
printf "%d" result