using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectUser.ConnectUserPhoneConfig")]
    public class ConnectUserPhoneConfig : aws.ConnectUser.IConnectUserPhoneConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#phone_type ConnectUser#phone_type}.</summary>
        [JsiiProperty(name: "phoneType", typeJson: "{\"primitive\":\"string\"}")]
        public string PhoneType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#after_contact_work_time_limit ConnectUser#after_contact_work_time_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "afterContactWorkTimeLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AfterContactWorkTimeLimit
        {
            get;
            set;
        }

        private object? _autoAccept;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#auto_accept ConnectUser#auto_accept}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoAccept", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoAccept
        {
            get => _autoAccept;
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
                _autoAccept = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#desk_phone_number ConnectUser#desk_phone_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deskPhoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeskPhoneNumber
        {
            get;
            set;
        }
    }
}
