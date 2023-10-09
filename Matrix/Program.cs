//initialize matrix 20x20, allNums array, random to generate random numbers
int[,] matrix = new int[20, 20];
int[] allNums = new int[400];
Random random = new Random();

//fill allNums array with random numbers
for (int i = 0; i < allNums.Length; i++)
{
    allNums[i] = random.Next(0, 10000);
}

//fill matrix with random numbers from allNums array
FillMatrix(matrix, allNums);

//find biggest and smallest numbers in allNums array
int biggestNum = allNums.Max();
int smallestNum = allNums.Min();

////print matrix on the screen
PrintMatrix(matrix);

//print smallest number with its coordinates
PrintNumberWithCoordinates(matrix, smallestNum);

//print biggest number with its coordinates
PrintNumberWithCoordinates(matrix, biggestNum);

//sort allNums array and fill sortedMatrix with sorted numbers
allNums = allNums.OrderBy(x => x).ToArray();
int[,] sortedMatrix = new int[20, 20];

FillMatrix(sortedMatrix, allNums);

////print sorted matrix on the screen
PrintMatrix(sortedMatrix);

static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < 20; i++)
    {
        for (int j = 0; j < 20; j++)
        {
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

static void PrintNumberWithCoordinates(int[,] matrix, int number)
{
    for (int i = 0; i < 20; i++)
    {
        for (int j = 0; j < 20; j++)
        {
            if (matrix[i, j] == number)
            {
                Console.WriteLine($"{i}:{j} -> {number}");
                break;
            }
        }
    }
}

static void FillMatrix(int[,] matrix, int[] nums)
{
    int indexAllNums = 0;
    for (int i = 0; i < 20; i++)
    {
        for (int j = 0; j < 20; j++)
        {
            matrix[i, j] = nums[indexAllNums];
            indexAllNums++;
        }
    }
}