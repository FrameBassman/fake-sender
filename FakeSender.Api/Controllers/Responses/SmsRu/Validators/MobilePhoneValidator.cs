using FakeSender.Api.Controllers.Responses.SmsRu.Reports;

namespace FakeSender.Api.Controllers.Responses.SmsRu.Validators
{
    public class MobilePhoneValidator : Validator
    {
        private readonly Phone _phone;
        
        public MobilePhoneValidator(Phone phone)
        {
            this._phone = phone;
        }

        public override PhoneReport Answer()
        {
            if (this._phone.ToString().StartsWith("79") && this._phone.ToString().Length == 11)
            {
                return new OkPhoneReport();
            }

            return new BadPhoneReport(
                202,
                "Неправильно указан номер телефона получателя, либо на него нет маршрута"
            );
        }
    }
}