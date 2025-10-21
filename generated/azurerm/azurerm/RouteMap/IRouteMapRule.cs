using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RouteMap
{
    [JsiiInterface(nativeType: typeof(IRouteMapRule), fullyQualifiedName: "azurerm.routeMap.RouteMapRule")]
    public interface IRouteMapRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#name RouteMap#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#action RouteMap#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.routeMap.RouteMapRuleAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>match_criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#match_criterion RouteMap#match_criterion}
        /// </remarks>
        [JsiiProperty(name: "matchCriterion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.routeMap.RouteMapRuleMatchCriterion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchCriterion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#next_step_if_matched RouteMap#next_step_if_matched}.</summary>
        [JsiiProperty(name: "nextStepIfMatched", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NextStepIfMatched
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRouteMapRule), fullyQualifiedName: "azurerm.routeMap.RouteMapRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.RouteMap.IRouteMapRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#name RouteMap#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#action RouteMap#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.routeMap.RouteMapRuleAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Action
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>match_criterion block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#match_criterion RouteMap#match_criterion}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchCriterion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.routeMap.RouteMapRuleMatchCriterion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MatchCriterion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#next_step_if_matched RouteMap#next_step_if_matched}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nextStepIfMatched", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NextStepIfMatched
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
