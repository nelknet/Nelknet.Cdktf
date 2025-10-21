using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiInterface(nativeType: typeof(ISesv2ConfigurationSetSuppressionOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSuppressionOptions")]
    public interface ISesv2ConfigurationSetSuppressionOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#suppressed_reasons Sesv2ConfigurationSet#suppressed_reasons}.</summary>
        [JsiiProperty(name: "suppressedReasons", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SuppressedReasons
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2ConfigurationSetSuppressionOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSuppressionOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSuppressionOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#suppressed_reasons Sesv2ConfigurationSet#suppressed_reasons}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "suppressedReasons", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SuppressedReasons
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
