/* Temel silah ozelliklerini base class uzerinde tanimladik
 * Base classi miras alan diger silahlar spesifik ozelliklerini kendi uzerinde tanimladi
 */

namespace OOP_2._2_Inheritance;

public class Weapon
{
    public string Name { get; set; }
    public int AttackDamage { get; set; }
    public float AttackCooldown { get; set; }
    public int Durability { get; set; }
    public float Weight { get; set; }
}

public class Bow : Weapon
{
    public string ArrowType { get; set; }
    public float Speed { get; set; }
}

public class FireStaff : Weapon
{
    public int BurnDamage { get; set; }
}
