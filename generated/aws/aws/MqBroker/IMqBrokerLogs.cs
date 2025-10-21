using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MqBroker
{
    [JsiiInterface(nativeType: typeof(IMqBrokerLogs), fullyQualifiedName: "aws.mqBroker.MqBrokerLogs")]
    public interface IMqBrokerLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#audit MqBroker#audit}.</summary>
        [JsiiProperty(name: "audit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Audit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#general MqBroker#general}.</summary>
        [JsiiProperty(name: "general", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? General
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMqBrokerLogs), fullyQualifiedName: "aws.mqBroker.MqBrokerLogs")]
        internal sealed class _Proxy : DeputyBase, aws.MqBroker.IMqBrokerLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#audit MqBroker#audit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Audit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#general MqBroker#general}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "general", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? General
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
