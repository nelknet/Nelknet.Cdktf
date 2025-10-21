using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchAccount
{
    [JsiiByValue(fqn: "azurerm.batchAccount.BatchAccountNetworkProfileNodeManagementAccess")]
    public class BatchAccountNetworkProfileNodeManagementAccess : azurerm.BatchAccount.IBatchAccountNetworkProfileNodeManagementAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#default_action BatchAccount#default_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultAction
        {
            get;
            set;
        }

        private object? _ipRule;

        /// <summary>ip_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#ip_rule BatchAccount#ip_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchAccount.BatchAccountNetworkProfileNodeManagementAccessIpRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpRule
        {
            get => _ipRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchAccount.IBatchAccountNetworkProfileNodeManagementAccessIpRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchAccount.IBatchAccountNetworkProfileNodeManagementAccessIpRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipRule = value;
            }
        }
    }
}
