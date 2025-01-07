let rec loop x y =
    if x > 10 then
        y
    else
        loop (x + 1) (y + x + 1)

let result = loop 0 0
printf "%d" result