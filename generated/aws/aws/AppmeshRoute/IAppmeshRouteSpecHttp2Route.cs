using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttp2Route), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttp2Route")]
    public interface IAppmeshRouteSpecHttp2Route
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteAction\"}")]
        aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteAction Action
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteMatch\"}")]
        aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteMatch Match
        {
            get;
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#retry_policy AppmeshRoute#retry_policy}
        /// </remarks>
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteRetryPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteRetryPolicy? RetryPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#timeout AppmeshRoute#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteTimeout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteTimeout? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttp2Route), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttp2Route")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshRoute.IAppmeshRouteSpecHttp2Route
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#action AppmeshRoute#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteAction\"}")]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteAction Action
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteAction>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#match AppmeshRoute#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteMatch\"}")]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteMatch Match
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteMatch>()!;
            }

            /// <summary>retry_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#retry_policy AppmeshRoute#retry_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteRetryPolicy\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteRetryPolicy? RetryPolicy
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteRetryPolicy?>();
            }

            /// <summary>timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#timeout AppmeshRoute#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteTimeout\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteTimeout? Timeout
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteTimeout?>();
            }
        }
    }
}
