using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventgridDomain
{
    [JsiiByValue(fqn: "azurerm.dataAzurermEventgridDomain.DataAzurermEventgridDomainTimeouts")]
    public class DataAzurermEventgridDomainTimeouts : azurerm.DataAzurermEventgridDomain.IDataAzurermEventgridDomainTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain#read DataAzurermEventgridDomain#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
