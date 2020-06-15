
namespace Playground.sesion3
{
    class ShotGallery
    {

        public void EmptyAmmo()
        {

            Uzi[] weapons = new Uzi[10];
            Cartige[] cartiges = new Cartige[20];
            for (int i = 0; i < weapons.Length; i++)
            {
                weapons[i] = new Uzi($"usi{i}");
            }
            for (int i = 0; i < cartiges.Length; i++)
            {
                cartiges[i] = new Cartige(25);

            }
            for (int x = 0; x < weapons.Length; x++)
            {

                weapons[x].Reaload(cartiges[x]);
                while (weapons[x].Shoot()) ;
                weapons[x].Reaload(cartiges[x + 10]);

            }
        }
    }
}
