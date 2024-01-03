using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace StGabrielArms.TriggerTrade.Web.Pages;

public class IndexModel : TriggerTradePageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
