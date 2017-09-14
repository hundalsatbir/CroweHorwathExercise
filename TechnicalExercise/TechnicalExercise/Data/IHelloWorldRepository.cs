using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalExercise.Data
{
    public interface IHelloWorldRepository
    {
        string GetMessage();
        bool SaveResponse(string response);
    }
}
