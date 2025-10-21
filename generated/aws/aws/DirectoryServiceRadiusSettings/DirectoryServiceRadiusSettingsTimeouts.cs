using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DirectoryServiceRadiusSettings
{
    [JsiiByValue(fqn: "aws.directoryServiceRadiusSettings.DirectoryServiceRadiusSettingsTimeouts")]
    public class DirectoryServiceRadiusSettingsTimeouts : aws.DirectoryServiceRadiusSettings.IDirectoryServiceRadiusSettingsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#create DirectoryServiceRadiusSettings#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#update DirectoryServiceRadiusSettings#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
