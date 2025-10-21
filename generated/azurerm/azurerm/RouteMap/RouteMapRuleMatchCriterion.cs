using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RouteMap
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.routeMap.RouteMapRuleMatchCriterion")]
    public class RouteMapRuleMatchCriterion : azurerm.RouteMap.IRouteMapRuleMatchCriterion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#match_condition RouteMap#match_condition}.</summary>
        [JsiiProperty(name: "matchCondition", typeJson: "{\"primitive\":\"string\"}")]
        public string MatchCondition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#as_path RouteMap#as_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "asPath", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AsPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#community RouteMap#community}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "community", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Community
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#route_prefix RouteMap#route_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routePrefix", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RoutePrefix
        {
            get;
            set;
        }
    }
}
