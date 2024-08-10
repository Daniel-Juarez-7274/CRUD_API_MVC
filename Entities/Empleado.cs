namespace CRUD_API.Entities
{
	public class Empleado
	{
        public int Id_Empleado { get; set; }
		public string Nombre_Completo { get; set; }
		public int Sueldo { get; set; }
		public int Id_Perfil { get; set; }
		//Referencia a la otra clase: Perfil
		public virtual Perfil Perfil_Referencia { get; set; }
    }
}
