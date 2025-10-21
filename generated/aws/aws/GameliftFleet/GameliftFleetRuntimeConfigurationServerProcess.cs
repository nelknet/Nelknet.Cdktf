using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GameliftFleet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.gameliftFleet.GameliftFleetRuntimeConfigurationServerProcess")]
    public class GameliftFleetRuntimeConfigurationServerProcess : aws.GameliftFleet.IGameliftFleetRuntimeConfigurationServerProcess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#concurrent_executions GameliftFleet#concurrent_executions}.</summary>
        [JsiiProperty(name: "concurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
        public double ConcurrentExecutions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#launch_path GameliftFleet#launch_path}.</summary>
        [JsiiProperty(name: "launchPath", typeJson: "{\"primitive\":\"string\"}")]
        public string LaunchPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#parameters GameliftFleet#parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Parameters
        {
            get;
            set;
        }
    }
}
