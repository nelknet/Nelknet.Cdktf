using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTemplate
{
    [JsiiInterface(nativeType: typeof(IQuicksightTemplateSourceEntitySourceTemplate), fullyQualifiedName: "aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceTemplate")]
    public interface IQuicksightTemplateSourceEntitySourceTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#arn QuicksightTemplate#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightTemplateSourceEntitySourceTemplate), fullyQualifiedName: "aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#arn QuicksightTemplate#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
