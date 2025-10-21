using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineTriggerGitConfigurationPullRequestFilePaths), fullyQualifiedName: "aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestFilePaths")]
    public interface ICodepipelineTriggerGitConfigurationPullRequestFilePaths
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#excludes Codepipeline#excludes}.</summary>
        [JsiiProperty(name: "excludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Excludes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#includes Codepipeline#includes}.</summary>
        [JsiiProperty(name: "includes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Includes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineTriggerGitConfigurationPullRequestFilePaths), fullyQualifiedName: "aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestFilePaths")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestFilePaths
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#excludes Codepipeline#excludes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Excludes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#includes Codepipeline#includes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Includes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
