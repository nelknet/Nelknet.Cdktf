using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecTcpRouteTimeout), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeout")]
    public interface IAppmeshRouteSpecTcpRouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeoutIdle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeoutIdle? Idle
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecTcpRouteTimeout), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeout")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#idle AppmeshRoute#idle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeoutIdle\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeoutIdle? Idle
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeoutIdle?>();
            }
        }
    }
}
