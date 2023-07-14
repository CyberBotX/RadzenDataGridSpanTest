namespace RadzenDataGridSpanTest;

public class Cell
{
	public object? Value { get; set; }
	public int Columns { get; set; } = 1;
	public int Rows { get; set; } = 1;
	public bool Ignore { get; set; }
	public int ColSpan => this.Ignore ? 0 : this.Columns;
	public int RowSpan => this.Ignore ? 0 : this.Rows;

	public string Content => $"V: {this.Value} - C: {this.Columns} - R: {this.Rows} - I: {this.Ignore}";
}

public class Row
{
	public int RowNumber { get; set; }
	public Dictionary<string, Cell> Cells { get; set; } = null!;

	public Cell? this[string col] => (this.Cells?.TryGetValue(col, out var cell) ?? false) ? cell : null;
	public string? CellContent(string col) => this[col] is Cell cell ? $"{cell.Content} - Cell: {col}{this.RowNumber}" : null;
}
