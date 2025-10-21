using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttp2RouteRetryPolicy), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttp2RouteRetryPolicy")]
    public interface IAppmeshRouteSpecHttp2RouteRetryPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#max_retries AppmeshRoute#max_retries}.</summary>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        double MaxRetries
        {
            get;
        }

        /// <summary>per_retry_timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#per_retry_timeout AppmeshRoute#per_retry_timeout}
        /// </remarks>
        [JsiiProperty(name: "perRetryTimeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteRetryPolicyPerRetryTimeout\"}")]
        aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteRetryPolicyPerRetryTimeout PerRetryTimeout
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#http_retry_events AppmeshRoute#http_retry_events}.</summary>
        [JsiiProperty(name: "httpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HttpRetryEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#tcp_retry_events AppmeshRoute#tcp_retry_events}.</summary>
        [JsiiProperty(name: "tcpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TcpRetryEvents
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttp2RouteRetryPolicy), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttp2RouteRetryPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteRetryPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#max_retries AppmeshRoute#max_retries}.</summary>
            [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxRetries
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>per_retry_timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#per_retry_timeout AppmeshRoute#per_retry_timeout}
            /// </remarks>
            [JsiiProperty(name: "perRetryTimeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteRetryPolicyPerRetryTimeout\"}")]
            public aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteRetryPolicyPerRetryTimeout PerRetryTimeout
            {
                get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteRetryPolicyPerRetryTimeout>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#http_retry_events AppmeshRoute#http_retry_events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HttpRetryEvents
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#tcp_retry_events AppmeshRoute#tcp_retry_events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tcpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TcpRetryEvents
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
