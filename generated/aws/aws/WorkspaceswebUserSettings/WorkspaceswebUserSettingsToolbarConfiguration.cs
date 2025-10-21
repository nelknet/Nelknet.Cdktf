using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebUserSettings
{
    [JsiiByValue(fqn: "aws.workspaceswebUserSettings.WorkspaceswebUserSettingsToolbarConfiguration")]
    public class WorkspaceswebUserSettingsToolbarConfiguration : aws.WorkspaceswebUserSettings.IWorkspaceswebUserSettingsToolbarConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#hidden_toolbar_items WorkspaceswebUserSettings#hidden_toolbar_items}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hiddenToolbarItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HiddenToolbarItems
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#max_display_resolution WorkspaceswebUserSettings#max_display_resolution}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxDisplayResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxDisplayResolution
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#toolbar_type WorkspaceswebUserSettings#toolbar_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toolbarType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ToolbarType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#visual_mode WorkspaceswebUserSettings#visual_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "visualMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VisualMode
        {
            get;
            set;
        }
    }
}
