using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachine
{
    [JsiiByValue(fqn: "azurerm.virtualMachine.VirtualMachineStorageImageReference")]
    public class VirtualMachineStorageImageReference : azurerm.VirtualMachine.IVirtualMachineStorageImageReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#id VirtualMachine#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#offer VirtualMachine#offer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "offer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Offer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#publisher VirtualMachine#publisher}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Publisher
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#sku VirtualMachine#sku}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sku
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#version VirtualMachine#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
