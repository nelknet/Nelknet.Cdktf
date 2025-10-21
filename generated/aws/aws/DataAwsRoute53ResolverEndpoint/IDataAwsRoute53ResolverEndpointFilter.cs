using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRoute53ResolverEndpoint
{
    [JsiiInterface(nativeType: typeof(IDataAwsRoute53ResolverEndpointFilter), fullyQualifiedName: "aws.dataAwsRoute53ResolverEndpoint.DataAwsRoute53ResolverEndpointFilter")]
    public interface IDataAwsRoute53ResolverEndpointFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_endpoint#name DataAwsRoute53ResolverEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_endpoint#values DataAwsRoute53ResolverEndpoint#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsRoute53ResolverEndpointFilter), fullyQualifiedName: "aws.dataAwsRoute53ResolverEndpoint.DataAwsRoute53ResolverEndpointFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsRoute53ResolverEndpoint.IDataAwsRoute53ResolverEndpointFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_endpoint#name DataAwsRoute53ResolverEndpoint#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_endpoint#values DataAwsRoute53ResolverEndpoint#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
