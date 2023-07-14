# RadzenDataGrid Span Test

This repository is meant to show some issues in [Radzen's Blazor DataGrid](https://www.radzen.com/blazor-components/) in regards to using colspan and rowspan.

Included in the repository are the following examples:
* Using only colspan (despite being staggered, this renders correctly)
* Using only rowspan (despite being staggered, almost renders correctly but is missing a grid line due to CSS rules)
* Using both colspan and rowspan, in 4 different ways:
  * All cells that use colspan and rowspan are using both, and this shows that Radzen's DataGrid skips a cell as well as introduces extra cells
  * A complex example that causes an exception, found via trying to convert a similar layout from an Excel file into a DataGrid, appears to be due to multiple colspan and rowspan cells under a much larger colspan and rowspan cell
  * A more simple example of the above that contains as small a possibility of showing the exception
  * A small example that is similar to the first in this group but only has a few cells with colspan or rowspan on them

This repository is to be used in a bug report to Radzen regarding the above issues.
