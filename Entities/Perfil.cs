namespace CRUD_API.Entities
{
	public class Perfil
	{
		public int Id_Perfil { get; set; }
		public string Nombre { get; set; }
		public virtual ICollection<Empleado> Empleados_Referencia { get; set; }
	}
}
