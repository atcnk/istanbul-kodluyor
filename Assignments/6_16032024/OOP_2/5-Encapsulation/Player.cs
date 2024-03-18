/* Health degiskenini private tanimlayip direkt olarak erisilmesini engelledik, koruma altina alarak encapsulation yapmis olduk.
 * Ayni zamanda getter/setter kullanarak bu islemlerin kontrol altinda yapilmis olmasini sagladik.
 * Oyuncunun can araligi 0 - 100 arasi oldugu icin bu degerlerin disina cikildiginda setter ile engellemis oluyoruz.
 */

namespace OOP_2._5_Encapsulation;

public class Player
{
    private int _health;

    public int Health
    {
        get
        {
            return _health;
        }

        set 
        {
            if (value < 0)
            {
                value = 0;
            }

            if (value > 100)
            {
                value = 100;
            }

            _health = value;
        }
    }
}