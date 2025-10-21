using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryLinkedServiceOdbc
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataFactoryLinkedServiceOdbc.DataFactoryLinkedServiceOdbcBasicAuthentication")]
    public class DataFactoryLinkedServiceOdbcBasicAuthentication : azurerm.DataFactoryLinkedServiceOdbc.IDataFactoryLinkedServiceOdbcBasicAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#password DataFactoryLinkedServiceOdbc#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#username DataFactoryLinkedServiceOdbc#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
