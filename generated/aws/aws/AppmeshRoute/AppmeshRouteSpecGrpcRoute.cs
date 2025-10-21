using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshRoute.AppmeshRouteSpecGrpcRoute")]
    public class AppmeshRouteSpecGrpcRoute : aws.AppmeshRoute.IAppmeshRouteSpecGrpcRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteAction\"}")]
        public aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteAction Action
        {
            get;
            set;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteMatch\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteMatch? Match
        {
            get;
            set;
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#retry_policy AppmeshRoute#retry_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteRetryPolicy\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteRetryPolicy? RetryPolicy
        {
            get;
            set;
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#timeout AppmeshRoute#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeout\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeout? Timeout
        {
            get;
            set;
        }
    }
}
