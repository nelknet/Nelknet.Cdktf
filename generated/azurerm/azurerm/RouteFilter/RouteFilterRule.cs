using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RouteFilter
{
    [JsiiByValue(fqn: "azurerm.routeFilter.RouteFilterRule")]
    public class RouteFilterRule : azurerm.RouteFilter.IRouteFilterRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter#access RouteFilter#access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Access
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter#communities RouteFilter#communities}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "communities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Communities
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter#name RouteFilter#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter#rule_type RouteFilter#rule_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RuleType
        {
            get;
            set;
        }
    }
}
