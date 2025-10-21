using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolMountNfsMount")]
    public class BatchPoolMountNfsMount : azurerm.BatchPool.IBatchPoolMountNfsMount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#relative_mount_path BatchPool#relative_mount_path}.</summary>
        [JsiiProperty(name: "relativeMountPath", typeJson: "{\"primitive\":\"string\"}")]
        public string RelativeMountPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#source BatchPool#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#mount_options BatchPool#mount_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mountOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MountOptions
        {
            get;
            set;
        }
    }
}
