using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataProtectionBackupPolicyPostgresqlFlexibleServer.DataProtectionBackupPolicyPostgresqlFlexibleServerDefaultRetentionRule")]
    public class DataProtectionBackupPolicyPostgresqlFlexibleServerDefaultRetentionRule : azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.IDataProtectionBackupPolicyPostgresqlFlexibleServerDefaultRetentionRule
    {
        private object _lifeCycle;

        /// <summary>life_cycle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_postgresql_flexible_server#life_cycle DataProtectionBackupPolicyPostgresqlFlexibleServer#life_cycle}
        /// </remarks>
        [JsiiProperty(name: "lifeCycle", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataProtectionBackupPolicyPostgresqlFlexibleServer.DataProtectionBackupPolicyPostgresqlFlexibleServerDefaultRetentionRuleLifeCycle\"},\"kind\":\"array\"}}]}}")]
        public object LifeCycle
        {
            get => _lifeCycle;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.IDataProtectionBackupPolicyPostgresqlFlexibleServerDefaultRetentionRuleLifeCycle[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.IDataProtectionBackupPolicyPostgresqlFlexibleServerDefaultRetentionRuleLifeCycle).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DataProtectionBackupPolicyPostgresqlFlexibleServer.IDataProtectionBackupPolicyPostgresqlFlexibleServerDefaultRetentionRuleLifeCycle).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lifeCycle = value;
            }
        }
    }
}
