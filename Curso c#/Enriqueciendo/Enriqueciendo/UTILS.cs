using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enriqueciendo
{
    public static class UTILS
    {

        public static bool IsValidCustomer(Customer customer, out string errorMessage)
        {

            if (customer.Age < CONSTANTS.MINIMUM_AGE)
            {
                errorMessage = string.Format(CONSTANTS.ERROR_MESSAGES.MINIMUM_AGE_ERROR_MESSAGE,
                    CONSTANTS.MINIMUM_AGE);
                return false;
            }

            errorMessage = "";
            return true;
        }



    }
}
