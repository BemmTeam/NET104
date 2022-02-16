
namespace ASMMAIN.Models
{

  
    public class AlertModel
    {

          public static class Type
        {
            public  const string
                success = "fas fa-check-circle",
                info = "fas fa-info-circle",
                error = "fas fa-times-circle";
        }
        
        public string message { get; set; }

        public string classType { get; set; }

        public string icon {get;set;}
        public AlertModel(string AlertType, string message)
        {

            this.message = message;
            switch (AlertType)
            {

                case Type.success: classType = "alert--success"; icon = Type.success; break;
                case Type.error: classType = "alert--error"; icon = Type.error; break;
                case Type.info: classType = "alert-info"; icon = Type.info; break;

            }

        }
        public AlertModel() { 
            
        }

    }
}