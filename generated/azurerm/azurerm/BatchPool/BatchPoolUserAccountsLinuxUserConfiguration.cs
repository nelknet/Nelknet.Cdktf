using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolUserAccountsLinuxUserConfiguration")]
    public class BatchPoolUserAccountsLinuxUserConfiguration : azurerm.BatchPool.IBatchPoolUserAccountsLinuxUserConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#gid BatchPool#gid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Gid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#ssh_private_key BatchPool#ssh_private_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sshPrivateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SshPrivateKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#uid BatchPool#uid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Uid
        {
            get;
            set;
        }
    }
}
