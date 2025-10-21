using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuildProject.CodebuildProjectEnvironmentRegistryCredential")]
    public class CodebuildProjectEnvironmentRegistryCredential : aws.CodebuildProject.ICodebuildProjectEnvironmentRegistryCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#credential CodebuildProject#credential}.</summary>
        [JsiiProperty(name: "credential", typeJson: "{\"primitive\":\"string\"}")]
        public string Credential
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#credential_provider CodebuildProject#credential_provider}.</summary>
        [JsiiProperty(name: "credentialProvider", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialProvider
        {
            get;
            set;
        }
    }
}
