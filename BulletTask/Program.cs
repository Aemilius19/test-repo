using BulletTask.Models;

namespace BulletTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon newweapon = new Weapon(7,7,false);
            Console.WriteLine("|=========Welcome=========|");
            bool exit=false;
            do
            {
                Console.WriteLine("|====Choose operation====|");
                Console.WriteLine("1-Show weapon info");
                Console.WriteLine("2-To shoot");
                Console.WriteLine("3-Get Remain Bullet");
                Console.WriteLine("4-Reload");
                Console.WriteLine("5-Change weapon firemod");
                Console.WriteLine("0-Exit");
                Console.WriteLine("|=======|");
                Console.WriteLine("choose option");
                string input=Console.ReadLine();
                switch (input)
                {
                    case "1":
                        newweapon.Showallinfo();
                        if (newweapon.Firemod==false)
                        {
                            Console.WriteLine("Tekli atiw rejimi");
                        }
                        else if(newweapon.Firemod==true)
                        {
                            Console.WriteLine("Avtomatik atiw rejimi");
                        }
                        Console.WriteLine("|============|");
                        break;
                    case "2":
                        newweapon.Shoot();
                        break;
                    case "3":
                        newweapon.GetRemainBullet();
                        break;
                    case "4":
                        newweapon.Reload();
                        break;
                    case "5":
                        Console.WriteLine("Choose firemod");
                        Console.WriteLine("1-Tekli");
                        Console.WriteLine("2-Avtomatik");
                        string changechoice= Console.ReadLine();
                        
                        switch (changechoice)
                        {
                            case "1":
                                bool choicebool1 = true;
                                newweapon.ChangeFireMod(choicebool1);
                                break;
                            case "2":
                                bool choicebool2 = false;
                                newweapon.ChangeFireMod(choicebool2);
                                break;
                            default:Console.WriteLine("duzgen secin");
                                break;
                        }
                        break;
                    case "0":
                        exit = true;
                        break;
                    default: Console.WriteLine("choose the right option");
                        break;
                }

            } while (exit!=true);
        }
    }
}