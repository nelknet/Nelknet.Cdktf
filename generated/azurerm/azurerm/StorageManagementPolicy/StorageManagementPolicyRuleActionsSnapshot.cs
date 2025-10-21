using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    [JsiiByValue(fqn: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsSnapshot")]
    public class StorageManagementPolicyRuleActionsSnapshot : azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsSnapshot
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#change_tier_to_archive_after_days_since_creation StorageManagementPolicy#change_tier_to_archive_after_days_since_creation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "changeTierToArchiveAfterDaysSinceCreation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ChangeTierToArchiveAfterDaysSinceCreation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#change_tier_to_cool_after_days_since_creation StorageManagementPolicy#change_tier_to_cool_after_days_since_creation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "changeTierToCoolAfterDaysSinceCreation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ChangeTierToCoolAfterDaysSinceCreation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#delete_after_days_since_creation_greater_than StorageManagementPolicy#delete_after_days_since_creation_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeleteAfterDaysSinceCreationGreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_archive_after_days_since_last_tier_change_greater_than StorageManagementPolicy#tier_to_archive_after_days_since_last_tier_change_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierToArchiveAfterDaysSinceLastTierChangeGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_cold_after_days_since_creation_greater_than StorageManagementPolicy#tier_to_cold_after_days_since_creation_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierToColdAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TierToColdAfterDaysSinceCreationGreaterThan
        {
            get;
            set;
        }
    }
}
