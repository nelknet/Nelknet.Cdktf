namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontContinuousDeploymentPolicyState<'Enabled> = { assignments: ResizeArray<aws.CloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy">aws_cloudfront_continuous_deployment_policy</a>.
    /// </summary>
    type CloudfrontContinuousDeploymentPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontContinuousDeploymentPolicyState<Missing> =
            ({ assignments = ResizeArray() } : CloudfrontContinuousDeploymentPolicyState<Missing>)

        member _.Zero(()) : CloudfrontContinuousDeploymentPolicyState<Missing> =
            ({ assignments = ResizeArray() } : CloudfrontContinuousDeploymentPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#enabled-1">CloudfrontContinuousDeploymentPolicy#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CloudfrontContinuousDeploymentPolicyState<Missing>, value: bool) : CloudfrontContinuousDeploymentPolicyState<Present> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : CloudfrontContinuousDeploymentPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#enabled-1">CloudfrontContinuousDeploymentPolicy#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CloudfrontContinuousDeploymentPolicyState<Missing>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontContinuousDeploymentPolicyState<Present> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : CloudfrontContinuousDeploymentPolicyState<Present>)

        /// <summary>
        /// staging_distribution_dns_names block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#staging_distribution_dns_names-1">CloudfrontContinuousDeploymentPolicy#staging_distribution_dns_names</a> Accepts: aws.IResolvable | aws.CloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicyStagingDistributionDnsNames[]
        /// </summary>
        [<CustomOperation "staging_distribution_dns_names">]
        member _.StagingDistributionDnsNames(state: CloudfrontContinuousDeploymentPolicyState<'Enabled>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontContinuousDeploymentPolicyState<'Enabled> =
            state.assignments.Add(fun config -> config.StagingDistributionDnsNames <- value)
            state : CloudfrontContinuousDeploymentPolicyState<'Enabled>

        /// <summary>
        /// traffic_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#traffic_config-1">CloudfrontContinuousDeploymentPolicy#traffic_config</a> Accepts: aws.IResolvable | aws.CloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicyTrafficConfig[]
        /// </summary>
        [<CustomOperation "traffic_config">]
        member _.TrafficConfig(state: CloudfrontContinuousDeploymentPolicyState<'Enabled>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontContinuousDeploymentPolicyState<'Enabled> =
            state.assignments.Add(fun config -> config.TrafficConfig <- value)
            state : CloudfrontContinuousDeploymentPolicyState<'Enabled>

        member _.Run(state: CloudfrontContinuousDeploymentPolicyState<Present>) : aws.CloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicy =
            let config = aws.CloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontContinuousDeploymentPolicy: missing required arguments. Must call: enabled.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontContinuousDeploymentPolicyState<_>) : aws.CloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicy =
            Unchecked.defaultof<aws.CloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicy>
