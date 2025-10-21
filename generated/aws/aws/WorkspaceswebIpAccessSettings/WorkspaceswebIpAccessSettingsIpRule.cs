using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebIpAccessSettings
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.workspaceswebIpAccessSettings.WorkspaceswebIpAccessSettingsIpRule")]
    public class WorkspaceswebIpAccessSettingsIpRule : aws.WorkspaceswebIpAccessSettings.IWorkspaceswebIpAccessSettingsIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_ip_access_settings#ip_range WorkspaceswebIpAccessSettings#ip_range}.</summary>
        [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}")]
        public string IpRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_ip_access_settings#description WorkspaceswebIpAccessSettings#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
