<Query Kind="FSharpProgram">
  <Output>DataGrids</Output>
  <Reference>C:\Code Archive\Libraries\CDATA ADO.NET For Excel\CData.Excel.System.dll</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\ReactiveUI.dll</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\ReactiveUI.pdb</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\ReactiveUI.xml</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\Splat.dll</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\Splat.pdb</Reference>
  <Reference>C:\Code Archive\Libraries\CDATA ADO.NET For Excel\System.Data.CData.Excel.dll</Reference>
  <Reference>C:\Code Archive\Libraries\CDATA ADO.NET For Excel\System.Data.CData.Excel.Entities.EF6.dll</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\System.Reactive.Core.dll</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\System.Reactive.Core.xml</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\System.Reactive.Interfaces.dll</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\System.Reactive.Interfaces.xml</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\System.Reactive.Linq.dll</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\System.Reactive.Linq.xml</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\System.Reactive.PlatformServices.dll</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\System.Reactive.PlatformServices.xml</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\System.Reactive.Windows.Threading.dll</Reference>
  <Reference>C:\Code Archive\Libraries\ReactiveUI\System.Reactive.Windows.Threading.xml</Reference>
</Query>

// Lambda Calculus function in F#

// Church Numerals
let zero f x = x
let one f x = f x
let two f x = f (f x) 
let three f x = f (f (f x))
let toInt n = n ((+) 1) 0
let succ n f x = f (n f x)
let add n m f x =  m f (n f x)
let mult n m f x = m (n (f)) x 
let power n m = m n
let True x y = x
let False x y = y
let ifThenElse b x y = b x y
let Not b x y = b y x

let toBool b = b true false
let isZero n = n (fun _ -> False) True
let isEven n = n Not True
let And a b = a b False
let Or a b = a True b
let pair l r f = f l r
let left p = p True
let right p = p False

// see the rest of the talk for list
//let nil = pair True True
//let isEmpty = left
printfn "%A" (nil |> isEmpty )