using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminInstanceAccessControlAttributes
{
    [JsiiInterface(nativeType: typeof(ISsoadminInstanceAccessControlAttributesAttribute), fullyQualifiedName: "aws.ssoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesAttribute")]
    public interface ISsoadminInstanceAccessControlAttributesAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#key SsoadminInstanceAccessControlAttributes#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#value SsoadminInstanceAccessControlAttributes#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesAttributeValue\"},\"kind\":\"array\"}}]}}")]
        object Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISsoadminInstanceAccessControlAttributesAttribute), fullyQualifiedName: "aws.ssoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesAttribute")]
        internal sealed class _Proxy : DeputyBase, aws.SsoadminInstanceAccessControlAttributes.ISsoadminInstanceAccessControlAttributesAttribute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#key SsoadminInstanceAccessControlAttributes#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#value SsoadminInstanceAccessControlAttributes#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesAttributeValue\"},\"kind\":\"array\"}}]}}")]
            public object Value
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
