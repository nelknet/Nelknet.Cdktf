using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiInterface(nativeType: typeof(IInstancePrivateDnsNameOptions), fullyQualifiedName: "aws.instance.InstancePrivateDnsNameOptions")]
    public interface IInstancePrivateDnsNameOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#enable_resource_name_dns_aaaa_record Instance#enable_resource_name_dns_aaaa_record}.</summary>
        [JsiiProperty(name: "enableResourceNameDnsAaaaRecord", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableResourceNameDnsAaaaRecord
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#enable_resource_name_dns_a_record Instance#enable_resource_name_dns_a_record}.</summary>
        [JsiiProperty(name: "enableResourceNameDnsARecord", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableResourceNameDnsARecord
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#hostname_type Instance#hostname_type}.</summary>
        [JsiiProperty(name: "hostnameType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostnameType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstancePrivateDnsNameOptions), fullyQualifiedName: "aws.instance.InstancePrivateDnsNameOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Instance.IInstancePrivateDnsNameOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#enable_resource_name_dns_aaaa_record Instance#enable_resource_name_dns_aaaa_record}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableResourceNameDnsAaaaRecord", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableResourceNameDnsAaaaRecord
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#enable_resource_name_dns_a_record Instance#enable_resource_name_dns_a_record}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableResourceNameDnsARecord", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableResourceNameDnsARecord
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#hostname_type Instance#hostname_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostnameType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostnameType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
