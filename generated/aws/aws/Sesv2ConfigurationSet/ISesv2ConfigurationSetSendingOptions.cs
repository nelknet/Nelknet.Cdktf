using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiInterface(nativeType: typeof(ISesv2ConfigurationSetSendingOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSendingOptions")]
    public interface ISesv2ConfigurationSetSendingOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#sending_enabled Sesv2ConfigurationSet#sending_enabled}.</summary>
        [JsiiProperty(name: "sendingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SendingEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2ConfigurationSetSendingOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSendingOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSendingOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#sending_enabled Sesv2ConfigurationSet#sending_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sendingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SendingEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
