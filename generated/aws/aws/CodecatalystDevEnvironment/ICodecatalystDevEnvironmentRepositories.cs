using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodecatalystDevEnvironment
{
    [JsiiInterface(nativeType: typeof(ICodecatalystDevEnvironmentRepositories), fullyQualifiedName: "aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentRepositories")]
    public interface ICodecatalystDevEnvironmentRepositories
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#repository_name CodecatalystDevEnvironment#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#branch_name CodecatalystDevEnvironment#branch_name}.</summary>
        [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BranchName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodecatalystDevEnvironmentRepositories), fullyQualifiedName: "aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentRepositories")]
        internal sealed class _Proxy : DeputyBase, aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentRepositories
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#repository_name CodecatalystDevEnvironment#repository_name}.</summary>
            [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#branch_name CodecatalystDevEnvironment#branch_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BranchName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
