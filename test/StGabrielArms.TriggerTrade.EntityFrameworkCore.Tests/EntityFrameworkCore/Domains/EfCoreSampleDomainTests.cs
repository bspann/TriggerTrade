using StGabrielArms.TriggerTrade.Samples;
using Xunit;

namespace StGabrielArms.TriggerTrade.EntityFrameworkCore.Domains;

[Collection(TriggerTradeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TriggerTradeEntityFrameworkCoreTestModule>
{

}
