using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiByValue(fqn: "aws.instance.InstancePrivateDnsNameOptions")]
    public class InstancePrivateDnsNameOptions : aws.Instance.IInstancePrivateDnsNameOptions
    {
        private object? _enableResourceNameDnsAaaaRecord;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#enable_resource_name_dns_aaaa_record Instance#enable_resource_name_dns_aaaa_record}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableResourceNameDnsAaaaRecord", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableResourceNameDnsAaaaRecord
        {
            get => _enableResourceNameDnsAaaaRecord;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableResourceNameDnsAaaaRecord = value;
            }
        }

        private object? _enableResourceNameDnsARecord;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#enable_resource_name_dns_a_record Instance#enable_resource_name_dns_a_record}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableResourceNameDnsARecord", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableResourceNameDnsARecord
        {
            get => _enableResourceNameDnsARecord;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableResourceNameDnsARecord = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#hostname_type Instance#hostname_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostnameType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostnameType
        {
            get;
            set;
        }
    }
}
