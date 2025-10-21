using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRoute53ResolverEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsRoute53ResolverEndpoint.DataAwsRoute53ResolverEndpointFilter")]
    public class DataAwsRoute53ResolverEndpointFilter : aws.DataAwsRoute53ResolverEndpoint.IDataAwsRoute53ResolverEndpointFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_endpoint#name DataAwsRoute53ResolverEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_endpoint#values DataAwsRoute53ResolverEndpoint#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
