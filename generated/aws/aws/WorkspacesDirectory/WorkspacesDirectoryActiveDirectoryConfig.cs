using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesDirectory
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.workspacesDirectory.WorkspacesDirectoryActiveDirectoryConfig")]
    public class WorkspacesDirectoryActiveDirectoryConfig : aws.WorkspacesDirectory.IWorkspacesDirectoryActiveDirectoryConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#domain_name WorkspacesDirectory#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#service_account_secret_arn WorkspacesDirectory#service_account_secret_arn}.</summary>
        [JsiiProperty(name: "serviceAccountSecretArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceAccountSecretArn
        {
            get;
            set;
        }
    }
}
