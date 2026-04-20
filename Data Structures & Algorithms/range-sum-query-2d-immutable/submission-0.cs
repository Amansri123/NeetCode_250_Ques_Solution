// Notes:

// Range Sum Matrix-1D
// arr[2,3,5,2,-5,1,4] --> you are given the range and asked the sum of that range.
// eg: range-(0,4)  Ans: 2+3+5+2+(-5)=7 Ans.
// Approach: Create an another array and insert the running SUM.
// arr1[2,5,10,12,7,8,12]
// So when asked about the range then 
// Range(0,4)- Sum of all then go to 5 and answer is 7
// Range(2,5)- 1.SUM from 0-5 in arr1 the sum until 5=8 and the sum until 2=5
//             2. Subtract 8-5=3 ANS 
// This is the faster approach.
// TAke DIFFERENCE EXAMPLE AND TRY

// About the 2D Matrix
// 3	0	1	4	2
// 5	6	3	2	1
// 1	2	0	1	5
// 4	1	0	1	7
// 1	0	3	0	5

// For prefix matrix firstly add 1 row and 1 coulum same as 1D array.
// 3	3	4	8	10
// 8				
// 9				
// 13				
// 14				

// Create the prefix matrix using formula:
// Pmatrix[i][j]=matrix[i][j] + PTop +PLeft - PTopLeft
// Basically that is the SUM of the all the elemtns of main matrix

// Prefix SUM Matrix
// 3	3	4	8	10
// 8	14	18	24	27
// 9	17	21	28	36
// 13	22	26	34	49
// 14	23	30	38	58

// For Any Range:
// Use formula: result= Total-top-left+topleft

public class NumMatrix {
   private int[][] prefix;

public NumMatrix(int[][] matrix)
{
    // Edge case
    if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
    {
        return;
    }

    int m = matrix.Length;        // rows
    int n = matrix[0].Length;     // columns

    // Use class variable 
    prefix = new int[m][];
    for (int i = 0; i < m; i++)
    {
        prefix[i] = new int[n];
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int top = (i > 0) ? prefix[i - 1][j] : 0;
            int left = (j > 0) ? prefix[i][j - 1] : 0;
            int topleft = (i > 0 && j > 0) ? prefix[i - 1][j - 1] : 0;

            prefix[i][j] = matrix[i][j] + top + left - topleft;
        }
    }
}
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        //This is for SUM Range finding

        int total=prefix[row2][col2];
        int top=(row1>0)?prefix[row1-1][col2] : 0;
        int left=(col1>0)?prefix[row2][col1-1] : 0;
        int topleft=(row1>0 && col1>0)?prefix[row1-1][col1-1] : 0;

        return total-top-left+topleft;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */