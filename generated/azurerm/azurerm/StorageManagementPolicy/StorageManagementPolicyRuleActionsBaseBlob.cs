using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    [JsiiByValue(fqn: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleActionsBaseBlob")]
    public class StorageManagementPolicyRuleActionsBaseBlob : azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActionsBaseBlob
    {
        private object? _autoTierToHotFromCoolEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#auto_tier_to_hot_from_cool_enabled StorageManagementPolicy#auto_tier_to_hot_from_cool_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoTierToHotFromCoolEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoTierToHotFromCoolEnabled
        {
            get => _autoTierToHotFromCoolEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _autoTierToHotFromCoolEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#delete_after_days_since_creation_greater_than StorageManagementPolicy#delete_after_days_since_creation_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeleteAfterDaysSinceCreationGreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#delete_after_days_since_last_access_time_greater_than StorageManagementPolicy#delete_after_days_since_last_access_time_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeleteAfterDaysSinceLastAccessTimeGreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#delete_after_days_since_modification_greater_than StorageManagementPolicy#delete_after_days_since_modification_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeleteAfterDaysSinceModificationGreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_archive_after_days_since_creation_greater_than StorageManagementPolicy#tier_to_archive_after_days_since_creation_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierToArchiveAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TierToArchiveAfterDaysSinceCreationGreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_archive_after_days_since_last_access_time_greater_than StorageManagementPolicy#tier_to_archive_after_days_since_last_access_time_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierToArchiveAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TierToArchiveAfterDaysSinceLastAccessTimeGreaterThan
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_archive_after_days_since_modification_greater_than StorageManagementPolicy#tier_to_archive_after_days_since_modification_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierToArchiveAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TierToArchiveAfterDaysSinceModificationGreaterThan
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_cold_after_days_since_last_access_time_greater_than StorageManagementPolicy#tier_to_cold_after_days_since_last_access_time_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierToColdAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TierToColdAfterDaysSinceLastAccessTimeGreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_cold_after_days_since_modification_greater_than StorageManagementPolicy#tier_to_cold_after_days_since_modification_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierToColdAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TierToColdAfterDaysSinceModificationGreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_cool_after_days_since_creation_greater_than StorageManagementPolicy#tier_to_cool_after_days_since_creation_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierToCoolAfterDaysSinceCreationGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TierToCoolAfterDaysSinceCreationGreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_cool_after_days_since_last_access_time_greater_than StorageManagementPolicy#tier_to_cool_after_days_since_last_access_time_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierToCoolAfterDaysSinceLastAccessTimeGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TierToCoolAfterDaysSinceLastAccessTimeGreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#tier_to_cool_after_days_since_modification_greater_than StorageManagementPolicy#tier_to_cool_after_days_since_modification_greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tierToCoolAfterDaysSinceModificationGreaterThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TierToCoolAfterDaysSinceModificationGreaterThan
        {
            get;
            set;
        }
    }
}
