using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolUserAccountsWindowsUserConfiguration")]
    public class BatchPoolUserAccountsWindowsUserConfiguration : azurerm.BatchPool.IBatchPoolUserAccountsWindowsUserConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#login_mode BatchPool#login_mode}.</summary>
        [JsiiProperty(name: "loginMode", typeJson: "{\"primitive\":\"string\"}")]
        public string LoginMode
        {
            get;
            set;
        }
    }
}
