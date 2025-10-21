using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GameliftFleet
{
    [JsiiInterface(nativeType: typeof(IGameliftFleetRuntimeConfigurationServerProcess), fullyQualifiedName: "aws.gameliftFleet.GameliftFleetRuntimeConfigurationServerProcess")]
    public interface IGameliftFleetRuntimeConfigurationServerProcess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#concurrent_executions GameliftFleet#concurrent_executions}.</summary>
        [JsiiProperty(name: "concurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
        double ConcurrentExecutions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#launch_path GameliftFleet#launch_path}.</summary>
        [JsiiProperty(name: "launchPath", typeJson: "{\"primitive\":\"string\"}")]
        string LaunchPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#parameters GameliftFleet#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Parameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftFleetRuntimeConfigurationServerProcess), fullyQualifiedName: "aws.gameliftFleet.GameliftFleetRuntimeConfigurationServerProcess")]
        internal sealed class _Proxy : DeputyBase, aws.GameliftFleet.IGameliftFleetRuntimeConfigurationServerProcess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#concurrent_executions GameliftFleet#concurrent_executions}.</summary>
            [JsiiProperty(name: "concurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
            public double ConcurrentExecutions
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#launch_path GameliftFleet#launch_path}.</summary>
            [JsiiProperty(name: "launchPath", typeJson: "{\"primitive\":\"string\"}")]
            public string LaunchPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#parameters GameliftFleet#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Parameters
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
