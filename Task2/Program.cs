/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int getCoordFromUser(string message){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)){
                break;
        }        
        else{
            Console.WriteLine("Вы ввели не корректное число");
        }
    }
    return result;
}

/*
√ ((x2-x1) ^ 2) + (y2-y1) ^ 2 + (z2-z1) ^ 2
*/
double getDistance(int ax, int ay, int az, int bx, int by, int bz){
    double result = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by, 2) + Math.Pow(az-bz, 2));
    return result;
}

int ax = getCoordFromUser("Введите координаты x первой точки");
int ay = getCoordFromUser("Введите координаты y первой точки");
int az = getCoordFromUser("Введите координаты z первой точки");

int bx = getCoordFromUser("Введите координаты x второй точки");
int by = getCoordFromUser("Введите координаты y второй точки");
int bz = getCoordFromUser("Введите координаты z второй точки");

double distance = getDistance(ax, ay, az, bx, by, bz);

Console.WriteLine($"Distance between({ax},{ay},{az}) and ({bx},{by},{bz}) is {distance:f2}");