
int Hero = 5;
int HeroPower = 100;
int Villian = 10;
int VillianPower = 200;
 if (Hero > Villian)
{

    Console.WriteLine("poor villian");

}
else
    Console.WriteLine("poor hero");


if (VillianPower > HeroPower)

{
    Console.WriteLine("Villian");

}
else
    Console.WriteLine("Hero");

 double PlayerSpeed = 5.1;

SetSpeed(2.5);

void SetSpeed(double x)
{

   Console.WriteLine(PlayerSpeed);
    PlayerSpeed = x;
    Console.WriteLine(PlayerSpeed);

}

    