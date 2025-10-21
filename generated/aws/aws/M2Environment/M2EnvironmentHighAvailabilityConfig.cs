using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.M2Environment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.m2Environment.M2EnvironmentHighAvailabilityConfig")]
    public class M2EnvironmentHighAvailabilityConfig : aws.M2Environment.IM2EnvironmentHighAvailabilityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#desired_capacity M2Environment#desired_capacity}.</summary>
        [JsiiProperty(name: "desiredCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public double DesiredCapacity
        {
            get;
            set;
        }
    }
}
