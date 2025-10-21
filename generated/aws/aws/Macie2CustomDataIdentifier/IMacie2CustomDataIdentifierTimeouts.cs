using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2CustomDataIdentifier
{
    [JsiiInterface(nativeType: typeof(IMacie2CustomDataIdentifierTimeouts), fullyQualifiedName: "aws.macie2CustomDataIdentifier.Macie2CustomDataIdentifierTimeouts")]
    public interface IMacie2CustomDataIdentifierTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#create Macie2CustomDataIdentifier#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2CustomDataIdentifierTimeouts), fullyQualifiedName: "aws.macie2CustomDataIdentifier.Macie2CustomDataIdentifierTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2CustomDataIdentifier.IMacie2CustomDataIdentifierTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#create Macie2CustomDataIdentifier#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
