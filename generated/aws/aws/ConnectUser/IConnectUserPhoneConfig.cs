using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectUser
{
    [JsiiInterface(nativeType: typeof(IConnectUserPhoneConfig), fullyQualifiedName: "aws.connectUser.ConnectUserPhoneConfig")]
    public interface IConnectUserPhoneConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#phone_type ConnectUser#phone_type}.</summary>
        [JsiiProperty(name: "phoneType", typeJson: "{\"primitive\":\"string\"}")]
        string PhoneType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#after_contact_work_time_limit ConnectUser#after_contact_work_time_limit}.</summary>
        [JsiiProperty(name: "afterContactWorkTimeLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AfterContactWorkTimeLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#auto_accept ConnectUser#auto_accept}.</summary>
        [JsiiProperty(name: "autoAccept", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoAccept
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#desk_phone_number ConnectUser#desk_phone_number}.</summary>
        [JsiiProperty(name: "deskPhoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeskPhoneNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectUserPhoneConfig), fullyQualifiedName: "aws.connectUser.ConnectUserPhoneConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectUser.IConnectUserPhoneConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#phone_type ConnectUser#phone_type}.</summary>
            [JsiiProperty(name: "phoneType", typeJson: "{\"primitive\":\"string\"}")]
            public string PhoneType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#after_contact_work_time_limit ConnectUser#after_contact_work_time_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "afterContactWorkTimeLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AfterContactWorkTimeLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#auto_accept ConnectUser#auto_accept}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoAccept", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoAccept
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#desk_phone_number ConnectUser#desk_phone_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deskPhoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeskPhoneNumber
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
