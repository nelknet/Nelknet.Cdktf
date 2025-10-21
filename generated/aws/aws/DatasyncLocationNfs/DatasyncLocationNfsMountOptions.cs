using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationNfs
{
    [JsiiByValue(fqn: "aws.datasyncLocationNfs.DatasyncLocationNfsMountOptions")]
    public class DatasyncLocationNfsMountOptions : aws.DatasyncLocationNfs.IDatasyncLocationNfsMountOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#version DatasyncLocationNfs#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
