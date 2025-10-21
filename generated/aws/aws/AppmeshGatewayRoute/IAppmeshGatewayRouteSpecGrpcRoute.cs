using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecGrpcRoute), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRoute")]
    public interface IAppmeshGatewayRouteSpecGrpcRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#action AppmeshGatewayRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteAction\"}")]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteAction Action
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#match AppmeshGatewayRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteMatch\"}")]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteMatch Match
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecGrpcRoute), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRoute")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#action AppmeshGatewayRoute#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteAction\"}")]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteAction Action
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteAction>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#match AppmeshGatewayRoute#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteMatch\"}")]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteMatch Match
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteMatch>()!;
            }
        }
    }
}
