/*Ստեղծել աբստրակտ Translator կլասը, որից ժառանգվում են Russian, Spanish, French կլասները:
Translator-ն ունի translate աբստրակտ մեթոդը, որն իբրև պարամետր ստանում է string տիպի բառ և վերադարձնում դրա թարգմանությունը համապատասխան լեզվով:
Ընդունենք, որ անհրաժեշտ է թարգմանել հետևյալ անգլերեն բառերը.
Apple, Banana, Orange, Mango, Pineapple, Grape, Strawberry, Cherry, Watermelon, Peach
Թարգմանությունները կարող եք ներկայացնել struct-ով, որն ունի original անգլերեն բառը և դրան համապատասխանող թարգմանությունը:
Նշված բառերի թարգմանություններն անհրաժեշտ է պահել համապատասխան կլասնսերում, սակայն հիշողության օպտիմալ օգտագործմամբ:*/

namespace Translate;

class Program
{
    static void Main(string[] args)
    {
        Translator[] words = new Translator[3];
        words[0] = new Spanish();
        words[1] = new French();
        words[2] = new Russian();
        foreach(Translator t in words){
            t.Translate("Banana");
        }
    }
}
