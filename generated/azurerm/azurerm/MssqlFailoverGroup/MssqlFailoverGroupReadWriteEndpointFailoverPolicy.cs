using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlFailoverGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlFailoverGroup.MssqlFailoverGroupReadWriteEndpointFailoverPolicy")]
    public class MssqlFailoverGroupReadWriteEndpointFailoverPolicy : azurerm.MssqlFailoverGroup.IMssqlFailoverGroupReadWriteEndpointFailoverPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#mode MssqlFailoverGroup#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#grace_minutes MssqlFailoverGroup#grace_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "graceMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GraceMinutes
        {
            get;
            set;
        }
    }
}
