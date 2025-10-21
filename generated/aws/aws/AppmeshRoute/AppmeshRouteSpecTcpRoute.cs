using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshRoute.AppmeshRouteSpecTcpRoute")]
    public class AppmeshRouteSpecTcpRoute : aws.AppmeshRoute.IAppmeshRouteSpecTcpRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteAction\"}")]
        public aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteAction Action
        {
            get;
            set;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteMatch\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteMatch? Match
        {
            get;
            set;
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#timeout AppmeshRoute#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeout\"}", isOptional: true)]
        public aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeout? Timeout
        {
            get;
            set;
        }
    }
}
