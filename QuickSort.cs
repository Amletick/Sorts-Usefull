int[] quickSort(int[] array, int leftIndex, int rightIndex){
    Console.WriteLine($"[{string.Join(", ", array)}]\nleftIndex={leftIndex}\nrightIndex={rightIndex}\n");
    int i = leftIndex, j = rightIndex, pivot = array[leftIndex];
    while (i <= j){
        while (array[i] < pivot){
            i++;
        }
        while (array[j] > pivot){
            j--;
        }
        if (i <= j){
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }
    if (leftIndex < j)
        quickSort(array, leftIndex, j);
    if (i < rightIndex)
        quickSort(array, i, rightIndex);

    return array;
}




Console.Clear();
int[] array = {3, -10, 0, 2, -1, 9, 4, 5, 3};
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", quickSort(array, 0, array.Length - 1))}]");