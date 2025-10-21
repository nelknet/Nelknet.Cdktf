using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttp2RouteMatchQueryParameter), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttp2RouteMatchQueryParameter")]
    public interface IAppmeshRouteSpecHttp2RouteMatchQueryParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#name AppmeshRoute#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteMatchQueryParameterMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteMatchQueryParameterMatch? Match
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttp2RouteMatchQueryParameter), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttp2RouteMatchQueryParameter")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteMatchQueryParameter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#name AppmeshRoute#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#match AppmeshRoute#match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteMatchQueryParameterMatch\"}", isOptional: true)]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteMatchQueryParameterMatch? Match
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteMatchQueryParameterMatch?>();
            }
        }
    }
}
