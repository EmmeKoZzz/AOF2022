namespace Day_8_Treetop_Tree_House;

public class Grid
{
   // internal Attributes
   private readonly int[,] _vessel;

   // public Attributes
   public int this[int x, int y] => _vessel[x, y];
   public readonly int Length;

   public Grid(string[] grid)
   {
      Length = grid.Length;
      _vessel = new int[Length,Length];
      int col = 0, row = 0;

      foreach (string treeRow in grid)
      {
         foreach (char tree in treeRow)
         {
            _vessel[col, row] = int.Parse(tree + "");
            row++;
         }
         row = 0;
         col++;
      }
   }
}
