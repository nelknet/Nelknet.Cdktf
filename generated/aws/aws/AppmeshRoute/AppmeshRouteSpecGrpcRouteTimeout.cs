using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiByValue(fqn: "aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeout")]
    public class AppmeshRouteSpecGrpcRouteTimeout : aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeoutIdle\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeoutIdle? Idle
        {
            get;
            set;
        }

        /// <summary>per_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#per_request AppmeshRoute#per_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeoutPerRequest\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeoutPerRequest? PerRequest
        {
            get;
            set;
        }
    }
}
