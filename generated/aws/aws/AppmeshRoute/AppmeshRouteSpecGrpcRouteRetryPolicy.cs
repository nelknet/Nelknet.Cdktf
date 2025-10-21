using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshRoute.AppmeshRouteSpecGrpcRouteRetryPolicy")]
    public class AppmeshRouteSpecGrpcRouteRetryPolicy : aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteRetryPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#max_retries AppmeshRoute#max_retries}.</summary>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxRetries
        {
            get;
            set;
        }

        /// <summary>per_retry_timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#per_retry_timeout AppmeshRoute#per_retry_timeout}
        /// </remarks>
        [JsiiProperty(name: "perRetryTimeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteRetryPolicyPerRetryTimeout\"}")]
        public aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteRetryPolicyPerRetryTimeout PerRetryTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#grpc_retry_events AppmeshRoute#grpc_retry_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grpcRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GrpcRetryEvents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#http_retry_events AppmeshRoute#http_retry_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HttpRetryEvents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#tcp_retry_events AppmeshRoute#tcp_retry_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tcpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TcpRetryEvents
        {
            get;
            set;
        }
    }
}
