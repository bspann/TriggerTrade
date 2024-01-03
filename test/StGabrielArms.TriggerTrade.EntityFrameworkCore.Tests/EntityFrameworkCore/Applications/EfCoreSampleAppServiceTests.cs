using StGabrielArms.TriggerTrade.Samples;
using Xunit;

namespace StGabrielArms.TriggerTrade.EntityFrameworkCore.Applications;

[Collection(TriggerTradeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TriggerTradeEntityFrameworkCoreTestModule>
{

}
