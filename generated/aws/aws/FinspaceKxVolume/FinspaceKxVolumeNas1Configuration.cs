using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxVolume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.finspaceKxVolume.FinspaceKxVolumeNas1Configuration")]
    public class FinspaceKxVolumeNas1Configuration : aws.FinspaceKxVolume.IFinspaceKxVolumeNas1Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#size FinspaceKxVolume#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#type FinspaceKxVolume#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
