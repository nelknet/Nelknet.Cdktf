using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationAccount
{
    [JsiiInterface(nativeType: typeof(IAutomationAccountEncryption), fullyQualifiedName: "azurerm.automationAccount.AutomationAccountEncryption")]
    public interface IAutomationAccountEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#key_vault_key_id AutomationAccount#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultKeyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#key_source AutomationAccount#key_source}.</summary>
        [JsiiProperty(name: "keySource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeySource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#user_assigned_identity_id AutomationAccount#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserAssignedIdentityId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomationAccountEncryption), fullyQualifiedName: "azurerm.automationAccount.AutomationAccountEncryption")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomationAccount.IAutomationAccountEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#key_vault_key_id AutomationAccount#key_vault_key_id}.</summary>
            [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultKeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#key_source AutomationAccount#key_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keySource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeySource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#user_assigned_identity_id AutomationAccount#user_assigned_identity_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserAssignedIdentityId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
