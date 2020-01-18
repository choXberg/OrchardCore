using GraphQL.Types;
using Microsoft.Extensions.Localization;
using OrchardCore.Apis.GraphQL.Queries;
using OrchardCore.ContentLocalization.Models;

namespace OrchardCore.ContentLocalization.GraphQL
{
    public class LocalizationInputObjectType : WhereInputObjectGraphType<LocalizationPart>
    {
        public LocalizationInputObjectType(IStringLocalizer<LocalizationInputObjectType> S)
        {
            Name = "LocalizationInputObjectType";
            Description = S["the localization part of the content item"];

            AddScalarFilterFields<StringGraphType>("culture", S["the culture of the content item to filter"]);
        }
    }
}
