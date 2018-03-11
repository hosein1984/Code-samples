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