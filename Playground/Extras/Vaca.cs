
namespace Playground.Extras
{
    /// <summary>
    /// Son los tipos de vaca que se manejan en el establo
    /// </summary>
    public enum Tipo
    {
        /// <summary>
        /// Este tipo se aplica a las vacas al nacer ya que no se sabe con
        /// certeza que roll desempeñan mejor
        /// </summary>
        CUALQUIERA,
        /// <summary>
        /// Este rol es especificamente para las vacas con una taza de produccion de leche
        /// que este por arriba de los 0.85 litros al dia
        /// </summary>
        LECHERA,
        /// <summary>
        /// Este rol se reserva para aquellas vacas cuya produccion de leche esta por
        /// debajo de los 0.5 litros al dia pero cuyo peso es ideal para generar cortes
        /// sabrosos y de calidad
        /// </summary>
        CARNE,
        /// <summary>
        /// Estas vacas son las mas fertiles pueden tener entre 2 y becerros al año
        /// </summary>
        PARTERA
    }
    
    public class Vaca
    {
        private readonly int _id;

        /// <summary>
        /// Este numero es una identificacion unica ára la vaca asignada
        /// al nacer y no debe ser cambiada.
        /// </summary>
        public int Id => _id;
        
        /// <summary>
        /// El nombre de la vaca
        /// </summary>
        public  string? Name { get; set; }

        /// <summary>
        /// El tipo co de la vaca
        /// </summary>
        public Tipo TipoDeVaca { get; set; } = Tipo.CUALQUIERA;

        /// <summary>
        /// La edad actual de la vaca
        /// </summary>
        public int Edad { get; set; } = 0;

        /// <summary>
        /// Es la cantidad de litros que produce la vaca en promedio mensual
        /// </summary>
        public float TazaDeProccion = 0f;
        
        public Vaca(int id)
        {
            _id = id;
        }

    }
}
