using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraExperience
{
    [JsiiInterface(nativeType: typeof(IKendraExperienceConfigurationUserIdentityConfiguration), fullyQualifiedName: "aws.kendraExperience.KendraExperienceConfigurationUserIdentityConfiguration")]
    public interface IKendraExperienceConfigurationUserIdentityConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#identity_attribute_name KendraExperience#identity_attribute_name}.</summary>
        [JsiiProperty(name: "identityAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityAttributeName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraExperienceConfigurationUserIdentityConfiguration), fullyQualifiedName: "aws.kendraExperience.KendraExperienceConfigurationUserIdentityConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraExperience.IKendraExperienceConfigurationUserIdentityConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#identity_attribute_name KendraExperience#identity_attribute_name}.</summary>
            [JsiiProperty(name: "identityAttributeName", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityAttributeName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
