using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IStorageManagementPolicyRuleActionsVersion), fullyQualifiedName: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsVersion")]
    public interface IStorageManagementPolicyRuleActionsVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#change_tier_to_archive_after_days_since_creation StorageManagementPolicy#change_tier_to_archive_after_days_since_creation}.</summary>
        [JsiiProperty(name: "changeTierToArchiveAfterDaysSinceCreation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ChangeTierToArchiveAfterDaysSinceCreation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#change_tier_to_cool_after_days_since_creation StorageManagementPolicy#change_tier_to_cool_after_days_since_creation}.</summary>
        [JsiiProperty(name: "changeTierToCoolAfterDaysSinceCreation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ChangeTierToCoolAfterDaysSinceCreation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#delete_after_days_since_creation StorageManagementPolicy#delete_after_days_since_creation}.</summary>
        [JsiiProperty(name: "deleteAfterDaysSinceCreation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeleteAfterDaysSinceCreation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_archive_after_days_since_last_tier_change_greater_than StorageManagementPolicy#tier_to_archive_after_days_since_last_tier_change_greater_than}.</summary>
        [JsiiProperty(name: "tierToArchiveAfterDaysSinceLastTierChangeGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_cold_after_days_since_creation_greater_than StorageManagementPolicy#tier_to_cold_after_days_since_creation_greater_than}.</summary>
        [JsiiProperty(name: "tierToColdAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TierToColdAfterDaysSinceCreationGreaterThan
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageManagementPolicyRuleActionsVersion), fullyQualifiedName: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsVersion")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsVersion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#change_tier_to_archive_after_days_since_creation StorageManagementPolicy#change_tier_to_archive_after_days_since_creation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "changeTierToArchiveAfterDaysSinceCreation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ChangeTierToArchiveAfterDaysSinceCreation
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#change_tier_to_cool_after_days_since_creation StorageManagementPolicy#change_tier_to_cool_after_days_since_creation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "changeTierToCoolAfterDaysSinceCreation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ChangeTierToCoolAfterDaysSinceCreation
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#delete_after_days_since_creation StorageManagementPolicy#delete_after_days_since_creation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteAfterDaysSinceCreation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeleteAfterDaysSinceCreation
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_archive_after_days_since_last_tier_change_greater_than StorageManagementPolicy#tier_to_archive_after_days_since_last_tier_change_greater_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tierToArchiveAfterDaysSinceLastTierChangeGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_cold_after_days_since_creation_greater_than StorageManagementPolicy#tier_to_cold_after_days_since_creation_greater_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tierToColdAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TierToColdAfterDaysSinceCreationGreaterThan
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
