using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiByValue(fqn: "aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeout")]
    public class AppmeshRouteSpecHttpRouteTimeout : aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeoutIdle\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeoutIdle? Idle
        {
            get;
            set;
        }

        /// <summary>per_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#per_request AppmeshRoute#per_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeoutPerRequest\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeoutPerRequest? PerRequest
        {
            get;
            set;
        }
    }
}
