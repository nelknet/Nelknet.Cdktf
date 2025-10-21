using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlFailoverGroup
{
    [JsiiInterface(nativeType: typeof(IMssqlFailoverGroupPartnerServer), fullyQualifiedName: "azurerm.mssqlFailoverGroup.MssqlFailoverGroupPartnerServer")]
    public interface IMssqlFailoverGroupPartnerServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#id MssqlFailoverGroup#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlFailoverGroupPartnerServer), fullyQualifiedName: "azurerm.mssqlFailoverGroup.MssqlFailoverGroupPartnerServer")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlFailoverGroup.IMssqlFailoverGroupPartnerServer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#id MssqlFailoverGroup#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
