using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebDataProtectionSettings
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.workspaceswebDataProtectionSettings.WorkspaceswebDataProtectionSettingsInlineRedactionConfigurationInlineRedactionPatternCustomPattern")]
    public class WorkspaceswebDataProtectionSettingsInlineRedactionConfigurationInlineRedactionPatternCustomPattern : aws.WorkspaceswebDataProtectionSettings.IWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationInlineRedactionPatternCustomPattern
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_data_protection_settings#pattern_name WorkspaceswebDataProtectionSettings#pattern_name}.</summary>
        [JsiiProperty(name: "patternName", typeJson: "{\"primitive\":\"string\"}")]
        public string PatternName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_data_protection_settings#pattern_regex WorkspaceswebDataProtectionSettings#pattern_regex}.</summary>
        [JsiiProperty(name: "patternRegex", typeJson: "{\"primitive\":\"string\"}")]
        public string PatternRegex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_data_protection_settings#keyword_regex WorkspaceswebDataProtectionSettings#keyword_regex}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keywordRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeywordRegex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_data_protection_settings#pattern_description WorkspaceswebDataProtectionSettings#pattern_description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "patternDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PatternDescription
        {
            get;
            set;
        }
    }
}
