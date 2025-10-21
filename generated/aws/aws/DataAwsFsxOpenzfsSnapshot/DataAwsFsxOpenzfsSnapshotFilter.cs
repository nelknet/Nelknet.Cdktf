using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsFsxOpenzfsSnapshot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsFsxOpenzfsSnapshot.DataAwsFsxOpenzfsSnapshotFilter")]
    public class DataAwsFsxOpenzfsSnapshotFilter : aws.DataAwsFsxOpenzfsSnapshot.IDataAwsFsxOpenzfsSnapshotFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_openzfs_snapshot#name DataAwsFsxOpenzfsSnapshot#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_openzfs_snapshot#values DataAwsFsxOpenzfsSnapshot#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
