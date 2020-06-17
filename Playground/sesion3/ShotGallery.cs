
using System;

namespace Playground.sesion3
{
    class ShotGallery
    {

        public void EmptyAmmo()
        {

            Uzi[] weapons = new Uzi[10];
            Cartige[] cartiges = new Cartige[30];
            for (int i = 0; i < weapons.Length; i++)
            {
                weapons[i] = new Uzi($"usi{i}");
                cartiges[i + 0] = new Cartige(10); // 0--> 9
                cartiges[i + 10] = new Cartige(4); // 10 --> 19
            }
            for (int x = 0; x < weapons.Length; x++)
            {
                weapons[x].Reaload(cartiges[x]);
                while (weapons[x].Shoot()) ;
                weapons[x].Reaload(cartiges[x + 10]);
                while (weapons[x].Shoot()) ;
            }
            /*
                        if (new LinearSearch().Search(5, 1,2,3,4,5,7,8,9,1))
                        {
                            Console.WriteLine("Se encoontro el numero");
                        }
                        else {
                            Console.WriteLine("Kyc");
                        }

                        new LinearSearch().PrintUntil(5, 1, 2, 5, 4, 5, 7, 8, 5, 1);
                    }
            */
        }
    }
}
