using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsFsxOntapStorageVirtualMachines
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsFsxOntapStorageVirtualMachines.DataAwsFsxOntapStorageVirtualMachinesFilter")]
    public class DataAwsFsxOntapStorageVirtualMachinesFilter : aws.DataAwsFsxOntapStorageVirtualMachines.IDataAwsFsxOntapStorageVirtualMachinesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_storage_virtual_machines#name DataAwsFsxOntapStorageVirtualMachines#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_storage_virtual_machines#values DataAwsFsxOntapStorageVirtualMachines#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
