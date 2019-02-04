using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BibliotecaTeca.Models
{
    [DataContract]
    public abstract class BaseModel
    {
        [DataMember]
        public long Id { get; set; }
    }
}
