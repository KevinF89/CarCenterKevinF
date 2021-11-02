using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IMecanicos
{

	[OperationContract]
	List<TMecanicos> ConsultarMecanicos();

	// TODO: agregue aquí sus operaciones de servicio
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class TMecanicos
{

    [DataMember]
    public string Tipo_Documento { get; set; }
    [DataMember]
    public int Documento { get; set; }
    [DataMember]
    public string Primer_Nombre { get; set; }
    [DataMember]
    public string Segundo_Nombre { get; set; }
    [DataMember]
    public string Primer_Apellido { get; set; }
    [DataMember]
    public string Segundo_Apellido { get; set; }
    [DataMember]
    public string Celular { get; set; }
    [DataMember]
    public string Direccion { get; set; }
    [DataMember]
    public string Email { get; set; }
    [DataMember]
    public string Estado { get; set; }

}
