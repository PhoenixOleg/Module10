using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    /// <summary>
    /// Интерфейс логгера
    /// </summary>
    public interface ILogger 
    {
        void Event(string message);

        void Error(string message);
    }
}
