using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineTrigger), fullyQualifiedName: "aws.codepipeline.CodepipelineTrigger")]
    public interface ICodepipelineTrigger
    {
        /// <summary>git_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#git_configuration Codepipeline#git_configuration}
        /// </remarks>
        [JsiiProperty(name: "gitConfiguration", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfiguration\"}")]
        aws.Codepipeline.ICodepipelineTriggerGitConfiguration GitConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#provider_type Codepipeline#provider_type}.</summary>
        [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineTrigger), fullyQualifiedName: "aws.codepipeline.CodepipelineTrigger")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>git_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#git_configuration Codepipeline#git_configuration}
            /// </remarks>
            [JsiiProperty(name: "gitConfiguration", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfiguration\"}")]
            public aws.Codepipeline.ICodepipelineTriggerGitConfiguration GitConfiguration
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerGitConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#provider_type Codepipeline#provider_type}.</summary>
            [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
