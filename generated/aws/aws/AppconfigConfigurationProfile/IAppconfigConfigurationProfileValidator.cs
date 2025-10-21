using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppconfigConfigurationProfile
{
    [JsiiInterface(nativeType: typeof(IAppconfigConfigurationProfileValidator), fullyQualifiedName: "aws.appconfigConfigurationProfile.AppconfigConfigurationProfileValidator")]
    public interface IAppconfigConfigurationProfileValidator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#type AppconfigConfigurationProfile#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#content AppconfigConfigurationProfile#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Content
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppconfigConfigurationProfileValidator), fullyQualifiedName: "aws.appconfigConfigurationProfile.AppconfigConfigurationProfileValidator")]
        internal sealed class _Proxy : DeputyBase, aws.AppconfigConfigurationProfile.IAppconfigConfigurationProfileValidator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#type AppconfigConfigurationProfile#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#content AppconfigConfigurationProfile#content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Content
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
