using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrRegistryScanningConfiguration
{
    [JsiiInterface(nativeType: typeof(IEcrRegistryScanningConfigurationRule), fullyQualifiedName: "aws.ecrRegistryScanningConfiguration.EcrRegistryScanningConfigurationRule")]
    public interface IEcrRegistryScanningConfigurationRule
    {
        /// <summary>repository_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_scanning_configuration#repository_filter EcrRegistryScanningConfiguration#repository_filter}
        /// </remarks>
        [JsiiProperty(name: "repositoryFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrRegistryScanningConfiguration.EcrRegistryScanningConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}]}}")]
        object RepositoryFilter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_scanning_configuration#scan_frequency EcrRegistryScanningConfiguration#scan_frequency}.</summary>
        [JsiiProperty(name: "scanFrequency", typeJson: "{\"primitive\":\"string\"}")]
        string ScanFrequency
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrRegistryScanningConfigurationRule), fullyQualifiedName: "aws.ecrRegistryScanningConfiguration.EcrRegistryScanningConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, aws.EcrRegistryScanningConfiguration.IEcrRegistryScanningConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>repository_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_scanning_configuration#repository_filter EcrRegistryScanningConfiguration#repository_filter}
            /// </remarks>
            [JsiiProperty(name: "repositoryFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecrRegistryScanningConfiguration.EcrRegistryScanningConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}]}}")]
            public object RepositoryFilter
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_scanning_configuration#scan_frequency EcrRegistryScanningConfiguration#scan_frequency}.</summary>
            [JsiiProperty(name: "scanFrequency", typeJson: "{\"primitive\":\"string\"}")]
            public string ScanFrequency
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
