using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RouteMap
{
    [JsiiInterface(nativeType: typeof(IRouteMapRuleMatchCriterion), fullyQualifiedName: "azurerm.routeMap.RouteMapRuleMatchCriterion")]
    public interface IRouteMapRuleMatchCriterion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#match_condition RouteMap#match_condition}.</summary>
        [JsiiProperty(name: "matchCondition", typeJson: "{\"primitive\":\"string\"}")]
        string MatchCondition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#as_path RouteMap#as_path}.</summary>
        [JsiiProperty(name: "asPath", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AsPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#community RouteMap#community}.</summary>
        [JsiiProperty(name: "community", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Community
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#route_prefix RouteMap#route_prefix}.</summary>
        [JsiiProperty(name: "routePrefix", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RoutePrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRouteMapRuleMatchCriterion), fullyQualifiedName: "azurerm.routeMap.RouteMapRuleMatchCriterion")]
        internal sealed class _Proxy : DeputyBase, azurerm.RouteMap.IRouteMapRuleMatchCriterion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#match_condition RouteMap#match_condition}.</summary>
            [JsiiProperty(name: "matchCondition", typeJson: "{\"primitive\":\"string\"}")]
            public string MatchCondition
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#as_path RouteMap#as_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "asPath", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AsPath
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#community RouteMap#community}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "community", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Community
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#route_prefix RouteMap#route_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routePrefix", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RoutePrefix
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
