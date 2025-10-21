using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecGrpcRouteTimeout), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeout")]
    public interface IAppmeshRouteSpecGrpcRouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeoutIdle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeoutIdle? Idle
        {
            get
            {
                return null;
            }
        }

        /// <summary>per_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#per_request AppmeshRoute#per_request}
        /// </remarks>
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeoutPerRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeoutPerRequest? PerRequest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecGrpcRouteTimeout), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeout")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#idle AppmeshRoute#idle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeoutIdle\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeoutIdle? Idle
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeoutIdle?>();
            }

            /// <summary>per_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#per_request AppmeshRoute#per_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeoutPerRequest\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeoutPerRequest? PerRequest
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeoutPerRequest?>();
            }
        }
    }
}
