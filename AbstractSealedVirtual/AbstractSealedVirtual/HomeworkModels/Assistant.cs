using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual.HomeworkModels
{
    internal class Assistant:Manager
    {
        public Employee GetFeedback(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                return GetPromotion(employee);
            }

            return employee;
        }
    }
}
