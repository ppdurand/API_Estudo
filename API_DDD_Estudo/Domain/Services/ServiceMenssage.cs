using Domain.Interfaces;
using Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceMenssage : IServiceMessage
    {
        private readonly IMenssage _IMenssage;
        public ServiceMenssage(IMenssage IMenssage)
        {
            _IMenssage = IMenssage;
        }

    }
}
