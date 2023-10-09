//initialize matrix 20x20, allNums array, random to generate random numbers
int[,] matrix = new int[20, 20];
int[] allNums = new int[400];
Random random = new Random();

//fill matrix with random numbers and fill allNums array with matrix numbers
int indexAllNums = 0;
for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        matrix[i, j] = random.Next(0, 10000);
        allNums[indexAllNums] = matrix[i, j];
        indexAllNums++;
    }
}

//find biggest and smallest numbers in allNums array
int biggestNum = allNums.Max();
int smallestNum = allNums.Min();

//print matrix on the screen
for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        Console.Write(matrix[i, j] + "  ");
    }
    Console.WriteLine();
}

//print smallest number with its coordinates
for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        if (matrix[i, j] == smallestNum)
        {
            Console.WriteLine($"{i}:{j} -> {smallestNum}");
            break;
        }
    }
}

//print biggest number with its coordinates
for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        if (matrix[i, j] == biggestNum)
        {
            Console.WriteLine($"{i}:{j} -> {biggestNum}");
            break;
        }
    }
}

//sort allNums array and fill sortedMatrix with sorted numbers
int[] sortedNums = allNums.OrderBy(x => x).ToArray();
int[,] sortedMatrix = new int[20, 20];

int indexSortedNums = 0;
for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        sortedMatrix[i, j] = sortedNums[indexSortedNums];
        indexSortedNums++;
    }
}

//print sorted matrix on the screen
for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        Console.Write(sortedMatrix[i, j] + "  ");
    }
    Console.WriteLine();
}