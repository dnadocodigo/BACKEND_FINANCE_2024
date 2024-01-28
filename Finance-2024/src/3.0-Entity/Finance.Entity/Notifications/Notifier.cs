using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finance.Entity.Notifications
{
  public class Notifier
  {
    // Construtores
    public Notifier()
    {
      Notifications = new List<Notifier>();
    }

  // Propriedades

    [NotMapped]
    public string PropertyName { get; set; }

    [NotMapped]
    public string Message { get; set; }

    [NotMapped]
    public List<Notifier> Notifications { get; set; }

    // Métodos

    // Validar propriedade de string 
    public bool StringPropertiesValidations(string value, string propertyName){
  
       if(string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName)){
         Notifications.Add(new Notifier{
            Message = "Campo obrigatório!",
            PropertyName = propertyName,
         });
         return false;
       } 
       return true;
    }
  
  // Validar propriedade de numeros inteirps
    public bool IntPropertiesValidations(int value, string propertyName){
  
       if( value < 1 || string.IsNullOrWhiteSpace(propertyName)){
         Notifications.Add(new Notifier{
            Message = "Campo obrigatório!",
            PropertyName = propertyName,
         });
         return false;
       } 
       return true;
    }
  

   // Validar propriedade de decimais
    public bool DecimalPropertiesValidations(decimal value, string propertyName){
  
       if( value < 1 || string.IsNullOrWhiteSpace(propertyName)){
         Notifications.Add(new Notifier{
            Message = "Campo obrigatório!",
            PropertyName = propertyName,
         });
         return false;
       } 
       return true;
    }
  }
}