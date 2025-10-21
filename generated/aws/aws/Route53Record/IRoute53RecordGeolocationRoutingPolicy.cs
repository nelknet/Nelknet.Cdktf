using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Record
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordGeolocationRoutingPolicy), fullyQualifiedName: "aws.route53Record.Route53RecordGeolocationRoutingPolicy")]
    public interface IRoute53RecordGeolocationRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#continent Route53Record#continent}.</summary>
        [JsiiProperty(name: "continent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Continent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#country Route53Record#country}.</summary>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Country
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#subdivision Route53Record#subdivision}.</summary>
        [JsiiProperty(name: "subdivision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Subdivision
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordGeolocationRoutingPolicy), fullyQualifiedName: "aws.route53Record.Route53RecordGeolocationRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Route53Record.IRoute53RecordGeolocationRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#continent Route53Record#continent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "continent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Continent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#country Route53Record#country}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Country
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#subdivision Route53Record#subdivision}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subdivision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Subdivision
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
