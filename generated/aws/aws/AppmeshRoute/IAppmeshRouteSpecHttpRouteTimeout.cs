using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteTimeout), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeout")]
    public interface IAppmeshRouteSpecHttpRouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeoutIdle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeoutIdle? Idle
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
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeoutPerRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeoutPerRequest? PerRequest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteTimeout), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeout")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#idle AppmeshRoute#idle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeoutIdle\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeoutIdle? Idle
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeoutIdle?>();
            }

            /// <summary>per_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#per_request AppmeshRoute#per_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeoutPerRequest\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeoutPerRequest? PerRequest
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeoutPerRequest?>();
            }
        }
    }
}
