#region
// //Dado el siguiente codigo:
// int Calculate(int n)
// {
//     if (n < 5)
//     {
//         return n * 2;
//     }
//     else if (n < 10)
//     {
//         return n + 3;
//     }
//     else
//     {
//         return n - 2;
//     }
// }
// int result1 = Calculate(3);
// int result2 = Calculate(7);
// int result3 = Calculate(12);
// //a) ¿Qu ́e valor devuelve Calculate(3)?     devuelve 6
// //b) ¿Qu ́e valor devuelve Calculate(5)?     devuelve 10 
// //c) ¿Qu ́e valor devuelve Calculate(12)?    devuelve 10
#endregion
#region
// //Dado el siguiente c  ́odigo:
// int x = 10;
// int y = 3;
// if (x > 5)
// {
//     x += y;
// }
// if (x < 15)
// {
//     y += x;
// }
// else
// {
//     y -= x;
// }
// //a) ¿Cu  ́al es el valor de x despu ́es del primer bloque if?    x vale 13
// //b) ¿Cu  ́al es el valor final de y?    y vale 16
#endregion 
#region
// //Dado el siguiente c  ́odigo:
// int x = 10;
// int y = 5;
// int result = 0;
// if (x > y)
// {
//     result = x * y;
// }
// else
// {
//     result = x + y;
// }
// y = 0;
// if (result > 20)
// {
//     result -= 10;
// }
// else
// {
//     result += 10;
// }
// //a) ¿Qu ́e valor tiene result despu ́es del primer bloque if?    result vale 50
// //b) ¿Qu ́e valor tiene result despu ́es del segundo bloque if?   result vale 40
#endregion
#region 
// //Dado el siguiente c  ́odigo:
// int result = 0;
// for (int i = 0; i < 5; i++)
// {
//     if (i % 2 == 0)
//     {
//         result += i;
//     }
//     else
//     {
//         result -= i;
//     }
// }
// //a) ¿Cu  ́al es el valor de sum despu ́es de la primera iteraci  ́on?     result vale 0
// //b) ¿Cu  ́al es el valor de sum al final del bucle?                     result vale 2
#endregion
#region
// //Dado el siguiente c  ́odigo:
// string[] fruits = ["apple", "banana", "cherry"];
// string message = "";
// for (int i = 0; i < fruits.Length; i++)
// {
//     switch (fruits[i])
//     {
//         case "apple":
//             message += "A";
//             break;
//         case "banana":
//             message += "B";
//             break;
//         case "cherry":
//             message += "C";
//             break;
//         default:
//             message += "?";
//             break;
//     }
// }
// //a) ¿Cu  ́al es el valor de message al final del bucle for?     el mensaje es ABC
// //b) ¿Qu ́e ocurre si se agrega ”orange” al arreglo fruits?      el mensje sera ABC?
#endregion
#region 
// //Dado el siguiente c  ́odigo:
// int result = 1;
// for (int i = 1; i <= 5; i++)
// {
//     if (i % 2 == 0)
//     {
//         result *= i;
//     }
//     else
//     {
//         result += i;
//     }
// }
// //a) ¿Cu  ́al es el valor de result despu ́es de la primera iteraci  ́on?      result vale 2
// //b) ¿Cu  ́al es el valor de result al final del bucle?                      result vale 33
#endregion
#region 
// //Dado el siguiente c  ́odigo:
// int a = 0;
// int count = 0;
// while (a < 10)
// {
//     a++;
//     if (a % 2 == 0)
//     {
//         continue;
//     }
//     count++;
//     if (count == 3)
//     {
//         Console.WriteLine(a);
//         Console.WriteLine(count);
//         break;
//     }
// }
// //a) ¿Qu ́e valor tiene a cuando el bucle se detiene?       a vale 5
// //b) ¿Cu  ́antas veces se incrementa count?                 count se incrementa 3 veces
#endregion
#region
// //Dado el siguiente c  ́odigo:
// int sum = 0;
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         sum += i + j;
//     }
// }
// //a) ¿Cu  ́antas veces se ejecuta el bucle for interno?      se ejevuta 6 veces
// //b) ¿Cu  ́al es el valor de sum al final del c  ́odigo?      c vale 9       
#endregion
#region 
// //Dado el siguiente c  ́odigo:
// void Increment(int number)
// {
// number += 5;
// }
// int originalNumber = 10;
// Increment(originalNumber );
// //a) ¿Cu  ́al es el valor de originalNumber antes de llamar al m ́etodo Increment?        es 10
// //b) ¿Cu  ́al es el valor de originalNumber despu ́es de llamar al m ́etodo Increment?     es 10
// //c) ¿Por qu ́e sucede esto?     esto sucede pq se pasa al metodo una copia del valor por lo que el valor de la variable originalNumber no se modifica 
#endregion
#region 
// //Dado el siguiente c  ́odigo:
// void ModifyArray(int[] numbers)
// {
// numbers [0] = 99;
// }
// int[] originalArray = [1, 2, 3, 4];
// ModifyArray(originalArray );
// //a) ¿Cu  ́al es el valor de originalArray[0] antes de llamar al m ́etodo ModifyArray?        es 1
// //b) ¿Cu  ́al es el valor de originalArray[0] despu ́es de llamar al m ́etodo ModifyArray?     es 99
// //c) ¿Por qu ́e sucede esto?     esto pasa pq lo que se pasa es una referencia al valor por lo que cualquier cambio dentro del metodo se vera reflejada fuera del metodo
#endregion
#region 
// //Dado el siguiente c  ́odigo:
// int Method1(int[] arr)
// {
//     int i = 0;
//     int result = 0;
//     while (i < 4)
//     {
//         result += arr[i++];
//     }
//     return result;
// }
// int Method2(int[] arr)
// {
//     int i = 0;
//     int result = 0;
//     while (i < 4)
//     {
//         result += arr[++i];
//     }
//     return result;
// }
// int[] myArray = [10, 20, 30, 40, 50];
// int result1 = Method1(myArray);
// int result2 = Method2(myArray);
// //a) ¿Qu ́e valor guarda result1?    guardara 100
// //b) ¿Qu ́e valor guarda result2?    guardara 140
#endregion








