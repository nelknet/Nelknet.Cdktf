using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminInstanceAccessControlAttributes
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesAttribute")]
    public class SsoadminInstanceAccessControlAttributesAttribute : aws.SsoadminInstanceAccessControlAttributes.ISsoadminInstanceAccessControlAttributesAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#key SsoadminInstanceAccessControlAttributes#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        private object _value;

        /// <summary>value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#value SsoadminInstanceAccessControlAttributes#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesAttributeValue\"},\"kind\":\"array\"}}]}}")]
        public object Value
        {
            get => _value;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsoadminInstanceAccessControlAttributes.ISsoadminInstanceAccessControlAttributesAttributeValue[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsoadminInstanceAccessControlAttributes.ISsoadminInstanceAccessControlAttributesAttributeValue).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsoadminInstanceAccessControlAttributes.ISsoadminInstanceAccessControlAttributesAttributeValue).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _value = value;
            }
        }
    }
}
