using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectQuickConnect
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfig")]
    public class ConnectQuickConnectQuickConnectConfig : aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#quick_connect_type ConnectQuickConnect#quick_connect_type}.</summary>
        [JsiiProperty(name: "quickConnectType", typeJson: "{\"primitive\":\"string\"}")]
        public string QuickConnectType
        {
            get;
            set;
        }

        private object? _phoneConfig;

        /// <summary>phone_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#phone_config ConnectQuickConnect#phone_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phoneConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigPhoneConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PhoneConfig
        {
            get => _phoneConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfigPhoneConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfigPhoneConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _phoneConfig = value;
            }
        }

        private object? _queueConfig;

        /// <summary>queue_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#queue_config ConnectQuickConnect#queue_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queueConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigQueueConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? QueueConfig
        {
            get => _queueConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfigQueueConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfigQueueConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queueConfig = value;
            }
        }

        private object? _userConfig;

        /// <summary>user_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#user_config ConnectQuickConnect#user_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigUserConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UserConfig
        {
            get => _userConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfigUserConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfigUserConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _userConfig = value;
            }
        }
    }
}
