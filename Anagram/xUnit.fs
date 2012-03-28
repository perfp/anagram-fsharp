module PrimeNumber


open Xunit

let isPrimeNumber(i) = 
    let limit = int(sqrt(float(i)))
    let rec check j = 
        j > limit || (i%j <> 0 && check(j+1))
    check 2

type System.Int32 with
    member i.IsPrime
        with get() = isPrimeNumber(i)
    static member IsPrimeNumber(i) = isPrimeNumber(i)

[<Fact>]
let IsPrime_WithPrimeNumber_ShouldReturnTrue() =
    Assert.True((7).IsPrime)
 

[<Fact>]
let IsPrime_WithNonePrimeNumber_ShouldReturnFalse() = 
    Assert.False(System.Int32.IsPrimeNumber(9))