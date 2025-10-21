using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiByValue(fqn: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptions")]
    public class Sesv2ConfigurationSetVdmOptionsGuardianOptions : aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#optimized_shared_delivery Sesv2ConfigurationSet#optimized_shared_delivery}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "optimizedSharedDelivery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OptimizedSharedDelivery
        {
            get;
            set;
        }
    }
}
