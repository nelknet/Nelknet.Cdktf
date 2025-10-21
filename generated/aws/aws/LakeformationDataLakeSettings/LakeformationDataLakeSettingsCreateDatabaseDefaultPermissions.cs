using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationDataLakeSettings
{
    [JsiiByValue(fqn: "aws.lakeformationDataLakeSettings.LakeformationDataLakeSettingsCreateDatabaseDefaultPermissions")]
    public class LakeformationDataLakeSettingsCreateDatabaseDefaultPermissions : aws.LakeformationDataLakeSettings.ILakeformationDataLakeSettingsCreateDatabaseDefaultPermissions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#permissions LakeformationDataLakeSettings#permissions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Permissions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#principal LakeformationDataLakeSettings#principal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Principal
        {
            get;
            set;
        }
    }
}
