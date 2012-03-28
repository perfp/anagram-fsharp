let timeCall func = 
    let stopwatch = System.Diagnostics.Stopwatch.StartNew()
    func()
    printfn "Elapsed time (ms): %d" stopwatch.ElapsedMilliseconds
    stopwatch.Stop()

