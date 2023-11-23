
using Heap;

CustomHeap heap = new CustomHeap();

//heap.insert(10);
//heap.insert(5);
//heap.insert(20);

//heap.remove();

int[] numbers = { 5, 3, 10, 1, 4, 2 };

for (int i = 0; i < numbers.Length; i++)
{
    heap.insert(numbers[i]);
}

for (int i = 0;i< numbers.Length; i++)
{
    numbers[i] = heap.remove();
    Console.WriteLine(numbers[i]);
}



Console.ReadKey();


