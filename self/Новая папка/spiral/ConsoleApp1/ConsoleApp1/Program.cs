class Spiral
{
    static void Main()
    {
        Console.WriteLine("please, enter number");
        int number = int.Parse(Console.ReadLine());
        int[,] matrix = GetMatrix(number);
        DrawMatrix(matrix,number);
    }


    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        int count = 1;
        int top = 0;
        int bottom = size - 1;
        int left = 0;
        int right = size - 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i<=right; i++)
            {
                matrix[top,i] = count++;
            }
            top++;
            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = count++;
            }
            right--;
            for (int i = right; i >= left; i--)
            {
                matrix[bottom, i] = count++;
            }
            bottom--;
            for (int i = bottom; i >= top; i--)
            {
                matrix[i,left] = count++;
            }
            left++;
        }
            return matrix;
    }
    static void DrawMatrix(int[,]matrix, int number)
    {
        for (int i = 0; i < number; i++)
        {
            for(int j = 0; j < number; j++)
            {
                Console.Write(matrix[i,j] + "\t");
                //Console.Write(" ");
            }
            Console.WriteLine();
        }
    }


}