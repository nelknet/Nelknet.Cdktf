using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrserverlessApplication.EmrserverlessApplicationImageConfiguration")]
    public class EmrserverlessApplicationImageConfiguration : aws.EmrserverlessApplication.IEmrserverlessApplicationImageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#image_uri EmrserverlessApplication#image_uri}.</summary>
        [JsiiProperty(name: "imageUri", typeJson: "{\"primitive\":\"string\"}")]
        public string ImageUri
        {
            get;
            set;
        }
    }
}
