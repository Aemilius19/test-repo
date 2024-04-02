using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BulletTask.Models
{
    internal class Weapon
    {
        byte _capacitybullet;
        public byte Capacitybullet
        {
            get { return _capacitybullet; }
            set
            {
                if (value > 0)
                {
                    _capacitybullet = value;
                }
            }
        }
        public byte CurrentBullet;
        bool _firemod;
        public bool Firemod
        {
            get { return _firemod; }
            set
            {
                if (value == false)
                {
                    _firemod = value;
                }
                else if (value == true)
                {
                    _firemod = value;
                }
            }


        }
        public void Shoot ()
        {
            if (Firemod==false)
            {
                CurrentBullet -= 1;
                Console.WriteLine("tekli atiw rejimi");
                Console.WriteLine("<---------->");
                Console.WriteLine("Gulle ugurla atildi");
                Console.WriteLine($"{CurrentBullet} dene  gulle qaldi");
            }
            else if(Firemod==true)
            {
                Console.WriteLine("avtomatik atiw rejimi");
                Console.WriteLine("<---------->");
                for (int i = CurrentBullet; i !=0; i--)
                {
                    CurrentBullet-= 1;
                    Console.WriteLine("Gulle ugurla atildi");
                    Console.WriteLine($"{CurrentBullet} dene  gulle qaldi");
                }
            }
        }
        public byte Reload()
        {
            CurrentBullet = Capacitybullet;
            Console.WriteLine($"Silah reload olundu indi gulle sayi {CurrentBullet}");
            return CurrentBullet;
        }

        public int GetRemainBullet() 
        {
            int leftcapacity = Capacitybullet - CurrentBullet;
            Console.WriteLine($"daragin dolmasi uchun {leftcapacity} geder gulle lazimdi");
            return leftcapacity;
            
        }

        public void ChangeFireMod(bool value)
        {
            if (Firemod==false&&value==true) { Firemod=value; Console.WriteLine("silah avtomatik rejime kecdi"); }
            else if (Firemod==true&&value==false) { Firemod = value; Console.WriteLine("silah tekli rejime kecdi"); }
            else
            {
                Console.WriteLine("Firemod deyiwilmedi deyerler sehf verilib ve ya rejim duzgun secilmiyib");
            }

        }
        public Weapon(byte capacitybullet,  byte currentBullet, bool firemod)
        {  
            Capacitybullet = capacitybullet;
            CurrentBullet = currentBullet;
            Firemod = firemod;
        }
        public void Showallinfo()
        {
            Console.WriteLine($"weapon capacity - {Capacitybullet},Weapom current bullet - {CurrentBullet}");
        }
    }
}
