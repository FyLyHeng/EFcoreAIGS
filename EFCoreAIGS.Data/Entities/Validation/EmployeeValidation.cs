using System.ComponentModel.DataAnnotations;

namespace EFCoreAIGS.Data.Entities.Validation
{
    public class EmployeeValidation : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var emp = (Employee)validationContext.ObjectInstance;
        
            if (emp.CreditCard == null)
            {
                return new ValidationResult("CreditCard can't be null");
            }
            return ValidationResult.Success;
            // return emp.CreditCard.Balance < 1000 ?
            //     new ValidationResult("Balance must be grander that 1000$")
            //     :ValidationResult.Success;
        }
    }
}
