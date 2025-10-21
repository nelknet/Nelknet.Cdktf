using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiByValue(fqn: "aws.appmeshRoute.AppmeshRouteSpecHttp2RouteTimeout")]
    public class AppmeshRouteSpecHttp2RouteTimeout : aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteTimeoutIdle\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteTimeoutIdle? Idle
        {
            get;
            set;
        }

        /// <summary>per_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#per_request AppmeshRoute#per_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteTimeoutPerRequest\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteTimeoutPerRequest? PerRequest
        {
            get;
            set;
        }
    }
}
