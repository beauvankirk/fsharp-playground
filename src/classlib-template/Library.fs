namespace classlib_template
open FSharp.ComProvider
module Say =

    let hello name =
        printfn "Hello %s" name

    let useComProvider name =
        printfn "Hello %s" name