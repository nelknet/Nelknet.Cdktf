using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiByValue(fqn: "aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeout")]
    public class AppmeshRouteSpecTcpRouteTimeout : aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeoutIdle\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeoutIdle? Idle
        {
            get;
            set;
        }
    }
}
