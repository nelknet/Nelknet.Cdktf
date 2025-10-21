using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlFailoverGroup
{
    [JsiiInterface(nativeType: typeof(IMssqlFailoverGroupReadWriteEndpointFailoverPolicy), fullyQualifiedName: "azurerm.mssqlFailoverGroup.MssqlFailoverGroupReadWriteEndpointFailoverPolicy")]
    public interface IMssqlFailoverGroupReadWriteEndpointFailoverPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#mode MssqlFailoverGroup#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#grace_minutes MssqlFailoverGroup#grace_minutes}.</summary>
        [JsiiProperty(name: "graceMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GraceMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlFailoverGroupReadWriteEndpointFailoverPolicy), fullyQualifiedName: "azurerm.mssqlFailoverGroup.MssqlFailoverGroupReadWriteEndpointFailoverPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlFailoverGroup.IMssqlFailoverGroupReadWriteEndpointFailoverPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#mode MssqlFailoverGroup#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#grace_minutes MssqlFailoverGroup#grace_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "graceMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GraceMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
