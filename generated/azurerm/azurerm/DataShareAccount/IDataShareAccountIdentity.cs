using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataShareAccount
{
    [JsiiInterface(nativeType: typeof(IDataShareAccountIdentity), fullyQualifiedName: "azurerm.dataShareAccount.DataShareAccountIdentity")]
    public interface IDataShareAccountIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_account#type DataShareAccount#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataShareAccountIdentity), fullyQualifiedName: "azurerm.dataShareAccount.DataShareAccountIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataShareAccount.IDataShareAccountIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_account#type DataShareAccount#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
