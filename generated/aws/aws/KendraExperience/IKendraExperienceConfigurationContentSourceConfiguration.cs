using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraExperience
{
    [JsiiInterface(nativeType: typeof(IKendraExperienceConfigurationContentSourceConfiguration), fullyQualifiedName: "aws.kendraExperience.KendraExperienceConfigurationContentSourceConfiguration")]
    public interface IKendraExperienceConfigurationContentSourceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#data_source_ids KendraExperience#data_source_ids}.</summary>
        [JsiiProperty(name: "dataSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DataSourceIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#direct_put_content KendraExperience#direct_put_content}.</summary>
        [JsiiProperty(name: "directPutContent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DirectPutContent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#faq_ids KendraExperience#faq_ids}.</summary>
        [JsiiProperty(name: "faqIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FaqIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraExperienceConfigurationContentSourceConfiguration), fullyQualifiedName: "aws.kendraExperience.KendraExperienceConfigurationContentSourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraExperience.IKendraExperienceConfigurationContentSourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#data_source_ids KendraExperience#data_source_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DataSourceIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#direct_put_content KendraExperience#direct_put_content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "directPutContent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DirectPutContent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#faq_ids KendraExperience#faq_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "faqIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FaqIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
