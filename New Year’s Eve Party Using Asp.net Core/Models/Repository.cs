////using AspNetCore;

namespace New_Year_s_Eve_Party_Using_Asp.net_Core.Models
{
    public static class Repository
    {
        private static List<PartyGuestResponse> partyGuestResponses = new();
        public static IEnumerable<PartyGuestResponse>GoPartyGuestResponse => partyGuestResponses;
        public static void AddResponse(PartyGuestResponse partyGuestResponse)
        {
            Console.WriteLine(partyGuestResponse);
            partyGuestResponses.Add(partyGuestResponse);
        }
    }
}