Player battleUnit = new Player();

IWeapon[] inventory = { new Gun(), new RailGun(), new Knife() };

foreach (IWeapon slot in inventory)
{
    battleUnit.Fire(slot);
    Console.WriteLine();
}

class Player
{
    public void Fire(IWeapon weapon)
    {
        weapon.Fire();
    }
    public void Throw(IThrowingWeapon throwingWeapon)
    {
        throwingWeapon.Throw();
    }
}

interface IWeapon
{
    void Fire();
}

interface IThrowingWeapon : IWeapon
{
    void Throw();
}

class Gun : IWeapon
{

    public void Fire()
    {
        Console.WriteLine($"{GetType().Name} Fire!");
    }
}
class RailGun : IWeapon
{

    public void Fire()
    {
        Console.WriteLine($"{GetType().Name} Poom!");
    }

}
class Knife : IThrowingWeapon
{
    public void Fire()
    {
        Console.WriteLine($"{GetType().Name} Hish!");
    }

    public void Throw()
    {
        Console.WriteLine($"{GetType().Name} Phum!");
    }
}
