using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecTcpRoute), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecTcpRoute")]
    public interface IAppmeshRouteSpecTcpRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteAction\"}")]
        aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteAction Action
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteMatch? Match
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
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeout? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecTcpRoute), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecTcpRoute")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshRoute.IAppmeshRouteSpecTcpRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#action AppmeshRoute#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteAction\"}")]
            public aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteAction Action
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteAction>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#match AppmeshRoute#match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteMatch\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteMatch? Match
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteMatch?>();
            }

            /// <summary>timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#timeout AppmeshRoute#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeout\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeout? Timeout
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeout?>();
            }
        }
    }
}
