using System.Collections;

namespace Day_8_Treetop_Tree_House;

internal struct Tree
{
   public readonly int Height;
   public readonly int X;
   public readonly int Y;

   public Tree(int height, int row, int col)
   {
      Height = height;
      X = col;
      Y = row;
   }
}

internal struct Cross
{
   // N, E, S, W
   public static int[] Vertical => new[] { -1, 0, 1, 0 };
   public static int[] Horizontal => new[] { 0, 1, 0, -1 };
   public static int Directions => 4;
}

public class Solution
{
   private readonly Grid _treeMap;
   public readonly int VisibleTrees;

   public Solution(string[] input)
   {
      _treeMap = new Grid(input);
      for (int row = 1; row < _treeMap.Length - 1; row++)
      for (int col = 1; col < _treeMap.Length - 1; col++)
      {
         Tree cursor = new Tree(_treeMap[row, col], row, col);
         if (VisibleTree(cursor))
            VisibleTrees++;
      }

      VisibleTrees += _treeMap.Length * 4 - 4;
   }

   private bool VisibleTree(Tree currentTree)
   {

      for (int i = 0; i < Cross.Directions; i++)
      {
         int x = currentTree.X + Cross.Horizontal[i];
         int y = currentTree.Y + Cross.Vertical[i];
         int edge = Cross.Horizontal[i] + Cross.Vertical[i] > 0 ? _treeMap.Length : -1;

         int count = 0;
         bool visibility = true;

         while (x != edge && y != edge)
         {
            count++;
            if (_treeMap[y, x] >= currentTree.Height)
            {
               visibility = false;
               break;
            }

            x += Cross.Horizontal[i];
            y += Cross.Vertical[i];
         }


         if (visibility) return true;
      }

      return false;
   }
}
