# lab5
# Оптимизація роботи з пам'яттю
## Завдання
```C#
 int size = 7000;
 int[,] b = new int[size, size];
 int res = 0;
 for (int j = 0; j < size; j++)
 {
    for (int k = 0; k < size; k++)
    {
      b[k, j]++;
    }
 }
```
### Результати 
RunTime 00:00:01.91

## Оптимізована програма
```C#
 int size = 7000;
 int[,] b = new int[size, size];
 int res = 0;
 for (int j = 0; j < size; j++)
 {
    for (int k = 0; k < size; k++)
    {
      b[j, k]++;
    }
 }
```
### Результати 
RunTime 00:00:00.47
