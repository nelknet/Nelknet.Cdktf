using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolUserAccountsWindowsUserConfiguration), fullyQualifiedName: "azurerm.batchPool.BatchPoolUserAccountsWindowsUserConfiguration")]
    public interface IBatchPoolUserAccountsWindowsUserConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#login_mode BatchPool#login_mode}.</summary>
        [JsiiProperty(name: "loginMode", typeJson: "{\"primitive\":\"string\"}")]
        string LoginMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolUserAccountsWindowsUserConfiguration), fullyQualifiedName: "azurerm.batchPool.BatchPoolUserAccountsWindowsUserConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolUserAccountsWindowsUserConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#login_mode BatchPool#login_mode}.</summary>
            [JsiiProperty(name: "loginMode", typeJson: "{\"primitive\":\"string\"}")]
            public string LoginMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
