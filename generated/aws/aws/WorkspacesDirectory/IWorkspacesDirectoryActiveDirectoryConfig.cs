using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesDirectory
{
    [JsiiInterface(nativeType: typeof(IWorkspacesDirectoryActiveDirectoryConfig), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectoryActiveDirectoryConfig")]
    public interface IWorkspacesDirectoryActiveDirectoryConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#domain_name WorkspacesDirectory#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#service_account_secret_arn WorkspacesDirectory#service_account_secret_arn}.</summary>
        [JsiiProperty(name: "serviceAccountSecretArn", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceAccountSecretArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesDirectoryActiveDirectoryConfig), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectoryActiveDirectoryConfig")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspacesDirectory.IWorkspacesDirectoryActiveDirectoryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#domain_name WorkspacesDirectory#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#service_account_secret_arn WorkspacesDirectory#service_account_secret_arn}.</summary>
            [JsiiProperty(name: "serviceAccountSecretArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceAccountSecretArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
