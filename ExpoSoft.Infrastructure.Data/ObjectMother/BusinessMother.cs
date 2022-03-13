using ExpoSoft.Domain.Entities;

namespace ExpoSoft.Infrastructure.Data.ObjectMother
{
    public static class BusinessMother
    {
        public static Business CreateBusiness()
        {
            return new Business(
                "ExpoSoft",
                "1524587",
                "exposoft@exposoft.com",
                "ExpoSoft123@",
                "Informática",
                "Cesar",
                "Valledupar",
                "Jhade",
                "Bonilla");
        }
    }
}
