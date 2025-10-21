using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RouteMap
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.routeMap.RouteMapRule")]
    public class RouteMapRule : azurerm.RouteMap.IRouteMapRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#name RouteMap#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _action;

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#action RouteMap#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.routeMap.RouteMapRuleAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Action
        {
            get => _action;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.RouteMap.IRouteMapRuleAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.RouteMap.IRouteMapRuleAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _action = value;
            }
        }

        private object? _matchCriterion;

        /// <summary>match_criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#match_criterion RouteMap#match_criterion}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchCriterion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.routeMap.RouteMapRuleMatchCriterion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MatchCriterion
        {
            get => _matchCriterion;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.RouteMap.IRouteMapRuleMatchCriterion[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.RouteMap.IRouteMapRuleMatchCriterion).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _matchCriterion = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#next_step_if_matched RouteMap#next_step_if_matched}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nextStepIfMatched", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NextStepIfMatched
        {
            get;
            set;
        }
    }
}
