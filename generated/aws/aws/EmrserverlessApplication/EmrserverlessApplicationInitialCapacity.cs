using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacity")]
    public class EmrserverlessApplicationInitialCapacity : aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#initial_capacity_type EmrserverlessApplication#initial_capacity_type}.</summary>
        [JsiiProperty(name: "initialCapacityType", typeJson: "{\"primitive\":\"string\"}")]
        public string InitialCapacityType
        {
            get;
            set;
        }

        /// <summary>initial_capacity_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#initial_capacity_config EmrserverlessApplication#initial_capacity_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initialCapacityConfig", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfig\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfig? InitialCapacityConfig
        {
            get;
            set;
        }
    }
}
