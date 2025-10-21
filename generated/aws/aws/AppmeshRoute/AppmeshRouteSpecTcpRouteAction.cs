using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshRoute.AppmeshRouteSpecTcpRouteAction")]
    public class AppmeshRouteSpecTcpRouteAction : aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteAction
    {
        private object _weightedTarget;

        /// <summary>weighted_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#weighted_target AppmeshRoute#weighted_target}
        /// </remarks>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteActionWeightedTarget\"},\"kind\":\"array\"}}]}}")]
        public object WeightedTarget
        {
            get => _weightedTarget;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteActionWeightedTarget[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteActionWeightedTarget).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteActionWeightedTarget).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _weightedTarget = value;
            }
        }
    }
}
