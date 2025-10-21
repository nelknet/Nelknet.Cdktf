using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectQuickConnect
{
    [JsiiInterface(nativeType: typeof(IConnectQuickConnectQuickConnectConfig), fullyQualifiedName: "aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfig")]
    public interface IConnectQuickConnectQuickConnectConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#quick_connect_type ConnectQuickConnect#quick_connect_type}.</summary>
        [JsiiProperty(name: "quickConnectType", typeJson: "{\"primitive\":\"string\"}")]
        string QuickConnectType
        {
            get;
        }

        /// <summary>phone_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#phone_config ConnectQuickConnect#phone_config}
        /// </remarks>
        [JsiiProperty(name: "phoneConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigPhoneConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PhoneConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>queue_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#queue_config ConnectQuickConnect#queue_config}
        /// </remarks>
        [JsiiProperty(name: "queueConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigQueueConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueueConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#user_config ConnectQuickConnect#user_config}
        /// </remarks>
        [JsiiProperty(name: "userConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigUserConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectQuickConnectQuickConnectConfig), fullyQualifiedName: "aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#quick_connect_type ConnectQuickConnect#quick_connect_type}.</summary>
            [JsiiProperty(name: "quickConnectType", typeJson: "{\"primitive\":\"string\"}")]
            public string QuickConnectType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>phone_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#phone_config ConnectQuickConnect#phone_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phoneConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigPhoneConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PhoneConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>queue_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#queue_config ConnectQuickConnect#queue_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigQueueConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueueConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>user_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#user_config ConnectQuickConnect#user_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigUserConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UserConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
