using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSsmPatchBaselines
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsSsmPatchBaselines.DataAwsSsmPatchBaselinesFilter")]
    public class DataAwsSsmPatchBaselinesFilter : aws.DataAwsSsmPatchBaselines.IDataAwsSsmPatchBaselinesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baselines#key DataAwsSsmPatchBaselines#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_patch_baselines#values DataAwsSsmPatchBaselines#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
