using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Notifies
    {
        public Notifies() 
        {
            notifies= new List<Notifies>();
        }
        [NotMapped]
        public string nomePropriedade { get; set; }
        [NotMapped]
        public string mensagem { get; set; }
        [NotMapped]
        public List<Notifies> notifies { get; set; }

        public bool StringPropertyValidate(string name, string property) 
        { 
            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(property)) 
            {
                notifies.Add(new Notifies
                {
                    mensagem = "Campo Obrigatório",
                    nomePropriedade = property
                });
                return false;
            }
            return true;
        }
        public bool IntPropertyValidate(int value, string property)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(property))
            {
                notifies.Add(new Notifies
                {
                    mensagem = "Campo Obrigatório",
                    nomePropriedade = property
                });
                return false;
            }
            return true;
        }
    }
}
