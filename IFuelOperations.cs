using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    // Интерфейс IFuelOperations, определяющий операции, связанные с топливом
    public interface IFuelOperations
    {
        // Метод для пополнения топлива
        void Refuel(decimal fuelAmount);
    }
}
