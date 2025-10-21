using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesDirectory
{
    [JsiiByValue(fqn: "aws.workspacesDirectory.WorkspacesDirectorySamlProperties")]
    public class WorkspacesDirectorySamlProperties : aws.WorkspacesDirectory.IWorkspacesDirectorySamlProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#relay_state_parameter_name WorkspacesDirectory#relay_state_parameter_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relayStateParameterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelayStateParameterName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#status WorkspacesDirectory#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#user_access_url WorkspacesDirectory#user_access_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userAccessUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAccessUrl
        {
            get;
            set;
        }
    }
}
