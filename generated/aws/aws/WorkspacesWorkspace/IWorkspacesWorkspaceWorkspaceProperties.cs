using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesWorkspace
{
    [JsiiInterface(nativeType: typeof(IWorkspacesWorkspaceWorkspaceProperties), fullyQualifiedName: "aws.workspacesWorkspace.WorkspacesWorkspaceWorkspaceProperties")]
    public interface IWorkspacesWorkspaceWorkspaceProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#compute_type_name WorkspacesWorkspace#compute_type_name}.</summary>
        [JsiiProperty(name: "computeTypeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeTypeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#root_volume_size_gib WorkspacesWorkspace#root_volume_size_gib}.</summary>
        [JsiiProperty(name: "rootVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RootVolumeSizeGib
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#running_mode WorkspacesWorkspace#running_mode}.</summary>
        [JsiiProperty(name: "runningMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RunningMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#running_mode_auto_stop_timeout_in_minutes WorkspacesWorkspace#running_mode_auto_stop_timeout_in_minutes}.</summary>
        [JsiiProperty(name: "runningModeAutoStopTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RunningModeAutoStopTimeoutInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#user_volume_size_gib WorkspacesWorkspace#user_volume_size_gib}.</summary>
        [JsiiProperty(name: "userVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UserVolumeSizeGib
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesWorkspaceWorkspaceProperties), fullyQualifiedName: "aws.workspacesWorkspace.WorkspacesWorkspaceWorkspaceProperties")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspacesWorkspace.IWorkspacesWorkspaceWorkspaceProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#compute_type_name WorkspacesWorkspace#compute_type_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeTypeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeTypeName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#root_volume_size_gib WorkspacesWorkspace#root_volume_size_gib}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RootVolumeSizeGib
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#running_mode WorkspacesWorkspace#running_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runningMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RunningMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#running_mode_auto_stop_timeout_in_minutes WorkspacesWorkspace#running_mode_auto_stop_timeout_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runningModeAutoStopTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RunningModeAutoStopTimeoutInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#user_volume_size_gib WorkspacesWorkspace#user_volume_size_gib}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UserVolumeSizeGib
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
