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
                "3012736897",
                "5708502",
                "ExpoSoft123@",
                "exposoft@exposoft.com",
                "2021",
                "Informática",
                "Cesar",
                "Valledupar",
                "CRR 5A #20-4",
                "Jhade",
                "Bonilla");
        }
    }
}
