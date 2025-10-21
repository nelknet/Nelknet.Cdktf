using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRoute53ResolverQueryLogConfig
{
    [JsiiInterface(nativeType: typeof(IDataAwsRoute53ResolverQueryLogConfigFilter), fullyQualifiedName: "aws.dataAwsRoute53ResolverQueryLogConfig.DataAwsRoute53ResolverQueryLogConfigFilter")]
    public interface IDataAwsRoute53ResolverQueryLogConfigFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_query_log_config#name DataAwsRoute53ResolverQueryLogConfig#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_query_log_config#values DataAwsRoute53ResolverQueryLogConfig#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsRoute53ResolverQueryLogConfigFilter), fullyQualifiedName: "aws.dataAwsRoute53ResolverQueryLogConfig.DataAwsRoute53ResolverQueryLogConfigFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsRoute53ResolverQueryLogConfig.IDataAwsRoute53ResolverQueryLogConfigFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_query_log_config#name DataAwsRoute53ResolverQueryLogConfig#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_query_log_config#values DataAwsRoute53ResolverQueryLogConfig#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
