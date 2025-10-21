using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesWorkspace
{
    [JsiiByValue(fqn: "aws.workspacesWorkspace.WorkspacesWorkspaceWorkspaceProperties")]
    public class WorkspacesWorkspaceWorkspaceProperties : aws.WorkspacesWorkspace.IWorkspacesWorkspaceWorkspaceProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#compute_type_name WorkspacesWorkspace#compute_type_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeTypeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputeTypeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#root_volume_size_gib WorkspacesWorkspace#root_volume_size_gib}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RootVolumeSizeGib
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#running_mode WorkspacesWorkspace#running_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runningMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RunningMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#running_mode_auto_stop_timeout_in_minutes WorkspacesWorkspace#running_mode_auto_stop_timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runningModeAutoStopTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RunningModeAutoStopTimeoutInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#user_volume_size_gib WorkspacesWorkspace#user_volume_size_gib}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UserVolumeSizeGib
        {
            get;
            set;
        }
    }
}
