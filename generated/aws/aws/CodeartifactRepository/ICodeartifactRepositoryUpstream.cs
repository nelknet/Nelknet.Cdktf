using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodeartifactRepository
{
    [JsiiInterface(nativeType: typeof(ICodeartifactRepositoryUpstream), fullyQualifiedName: "aws.codeartifactRepository.CodeartifactRepositoryUpstream")]
    public interface ICodeartifactRepositoryUpstream
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#repository_name CodeartifactRepository#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodeartifactRepositoryUpstream), fullyQualifiedName: "aws.codeartifactRepository.CodeartifactRepositoryUpstream")]
        internal sealed class _Proxy : DeputyBase, aws.CodeartifactRepository.ICodeartifactRepositoryUpstream
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#repository_name CodeartifactRepository#repository_name}.</summary>
            [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
