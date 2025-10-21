using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectEnvironmentRegistryCredential), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectEnvironmentRegistryCredential")]
    public interface ICodebuildProjectEnvironmentRegistryCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#credential CodebuildProject#credential}.</summary>
        [JsiiProperty(name: "credential", typeJson: "{\"primitive\":\"string\"}")]
        string Credential
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#credential_provider CodebuildProject#credential_provider}.</summary>
        [JsiiProperty(name: "credentialProvider", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialProvider
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectEnvironmentRegistryCredential), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectEnvironmentRegistryCredential")]
        internal sealed class _Proxy : DeputyBase, aws.CodebuildProject.ICodebuildProjectEnvironmentRegistryCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#credential CodebuildProject#credential}.</summary>
            [JsiiProperty(name: "credential", typeJson: "{\"primitive\":\"string\"}")]
            public string Credential
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#credential_provider CodebuildProject#credential_provider}.</summary>
            [JsiiProperty(name: "credentialProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialProvider
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
