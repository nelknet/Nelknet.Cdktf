using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationDataLakeSettings
{
    [JsiiInterface(nativeType: typeof(ILakeformationDataLakeSettingsCreateTableDefaultPermissions), fullyQualifiedName: "aws.lakeformationDataLakeSettings.LakeformationDataLakeSettingsCreateTableDefaultPermissions")]
    public interface ILakeformationDataLakeSettingsCreateTableDefaultPermissions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#permissions LakeformationDataLakeSettings#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Permissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#principal LakeformationDataLakeSettings#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Principal
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILakeformationDataLakeSettingsCreateTableDefaultPermissions), fullyQualifiedName: "aws.lakeformationDataLakeSettings.LakeformationDataLakeSettingsCreateTableDefaultPermissions")]
        internal sealed class _Proxy : DeputyBase, aws.LakeformationDataLakeSettings.ILakeformationDataLakeSettingsCreateTableDefaultPermissions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#permissions LakeformationDataLakeSettings#permissions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Permissions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#principal LakeformationDataLakeSettings#principal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Principal
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
