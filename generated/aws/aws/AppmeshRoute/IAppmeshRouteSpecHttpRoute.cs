using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRoute), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttpRoute")]
    public interface IAppmeshRouteSpecHttpRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteAction\"}")]
        aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteAction Action
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteMatch\"}")]
        aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteMatch Match
        {
            get;
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#retry_policy AppmeshRoute#retry_policy}
        /// </remarks>
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicy? RetryPolicy
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
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeout? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRoute), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttpRoute")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshRoute.IAppmeshRouteSpecHttpRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#action AppmeshRoute#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteAction\"}")]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteAction Action
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteAction>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#match AppmeshRoute#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteMatch\"}")]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteMatch Match
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteMatch>()!;
            }

            /// <summary>retry_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#retry_policy AppmeshRoute#retry_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicy\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicy? RetryPolicy
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicy?>();
            }

            /// <summary>timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#timeout AppmeshRoute#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeout\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeout? Timeout
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeout?>();
            }
        }
    }
}
