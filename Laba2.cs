using Khudyakova_2_ind;

//номер 1 

Ellipsoid figure1 = new Ellipsoid();
Ellipsoid figure2 = new Ellipsoid();

figure1.Read();
figure1.Print();

figure2.name = "Вторая фигура";
figure2.a = 8;
figure2.b = 4;
figure2.c = 4;
figure2.Print();

if (figure1.V() > figure2.V())
{
    Console.WriteLine($"Фигура с наибольшем объемом {figure1.name}");
}

else if (figure1.V() < figure2.V())
{
    Console.WriteLine($"Фигура с наибольшем объемом {figure2.name}");
}
else
{
    Console.WriteLine("объемы одинаковы");
}

double Area1 = figure1.Area();
double Area2 = figure2.Area();

if (Math.Abs(100 - Area1) > Math.Abs(100 - Area2))
{
    Console.WriteLine($"Площадь {figure1.name} ближе к 100");
}
else if (Math.Abs(100 - Area2) > Math.Abs(100 - Area1))
{
    Console.WriteLine($"Площадь {figure2.name} ближе к 100");
}

//номер 2 

Console.WriteLine("Введите кол-во фигур:  ");
int n = Convert.ToInt32(Console.ReadLine());

Ellipsoid[] figures = new Ellipsoid[n];
for (int i = 0; i < n; i++)
{
    figures[i] = new Ellipsoid();
    figures[i].Read();
}

//a

Ellipsoid largestname = new Ellipsoid();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (figures[i].name.Length > figures[j].name.Length)
        {
            largestname = figures[i]; 
        }
    }
}
largestname.Print();

//б

Ellipsoid bigfigure = new Ellipsoid();

bigfigure.name = "новая фигура";
bigfigure.a = figures[figures.Length - 1].a * 2;
bigfigure.b = figures[figures.Length - 1].b * 2;
bigfigure.c = figures[figures.Length - 1].c * 2;

bigfigure.Print(); 
Console.WriteLine($"{bigfigure.a} {bigfigure.b} {bigfigure.c}");

//c

Console.WriteLine("Все площади фигур в массиве: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(figures[i].name+"поверхности"+ figures[i].Area());
}

//д

string minArea = "";
for (int i = 0; i < n; i++)
{
    for (int j = 1; j < n; j++)
    {
        if (figures[i].Area()< figures[j].Area())
        {
            minArea = "min" + figures[i].name;
        }
    }
}
Console.WriteLine($"Минимальная площадь: {minArea}");

//e

int count = 0;
for (int i=0; i<n; i++)
{
    if (figures[i].Area() > 15)
    {
        count++;
    }
}
Console.WriteLine($"Площади больше 15: {count}");

//f

Console.WriteLine("Все объемы в массиве");
for (int i=0; i<n; i++)
{
    Console.WriteLine(figures[i].name+ "объем" + figures[i].V());
}

//g

double allVolume = 0;
for (int i = 0; i<n; i++)
{
    allVolume = figures[i].V() + allVolume;

}
Console.WriteLine($"Сумма всех объемов: {allVolume}");