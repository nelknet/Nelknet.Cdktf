using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminInstanceAccessControlAttributes
{
    [JsiiInterface(nativeType: typeof(ISsoadminInstanceAccessControlAttributesAttributeValue), fullyQualifiedName: "aws.ssoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesAttributeValue")]
    public interface ISsoadminInstanceAccessControlAttributesAttributeValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#source SsoadminInstanceAccessControlAttributes#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Source
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISsoadminInstanceAccessControlAttributesAttributeValue), fullyQualifiedName: "aws.ssoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesAttributeValue")]
        internal sealed class _Proxy : DeputyBase, aws.SsoadminInstanceAccessControlAttributes.ISsoadminInstanceAccessControlAttributesAttributeValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#source SsoadminInstanceAccessControlAttributes#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Source
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
