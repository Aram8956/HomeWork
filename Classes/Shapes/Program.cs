/*Ստեղծել Shape աբստրակտ կլասը, որի աբստրակտ մեթոդներն են՝  surface և  draw, առաջինը՝ մակերեը հաշվելու համար, երկրորդը նկարելու
Կլասն ունի նաև ոչ աբստրակտ print մեթոդը, որը կանչելիս ելքագրվում է տվյալ Shape-ի անունը, մակերեսը, ինչպես նաև պատկերը.
Կլասից ժառանգվում են՝
Square, Rectangle, կլասները.*/

namespace Shape;

class Program
{
    static void Main(string[] args)
    {
        Shapes[] shapes = new Shapes[2];
        shapes[0] = new Square(4);
        shapes[1] = new Rectangle(4,6);
        foreach(Shapes s in shapes){
            s.Print();
        }
    }
}
