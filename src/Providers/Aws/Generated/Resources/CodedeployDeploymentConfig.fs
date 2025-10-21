namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodedeployDeploymentConfigState<'DeploymentConfigName> = { assignments: ResizeArray<aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config">aws_codedeploy_deployment_config</a>.
    /// </summary>
    type CodedeployDeploymentConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodedeployDeploymentConfigState<Missing> =
            ({ assignments = ResizeArray() } : CodedeployDeploymentConfigState<Missing>)

        member _.Zero(()) : CodedeployDeploymentConfigState<Missing> =
            ({ assignments = ResizeArray() } : CodedeployDeploymentConfigState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#deployment_config_name-1">CodedeployDeploymentConfig#deployment_config_name</a>.
        /// </summary>
        [<CustomOperation "deployment_config_name">]
        member _.DeploymentConfigName(state: CodedeployDeploymentConfigState<Missing>, value: string) : CodedeployDeploymentConfigState<Present> =
            state.assignments.Add(fun config -> config.DeploymentConfigName <- value)
            ({ assignments = state.assignments } : CodedeployDeploymentConfigState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#compute_platform-1">CodedeployDeploymentConfig#compute_platform</a>.
        /// </summary>
        [<CustomOperation "compute_platform">]
        member _.ComputePlatform(state: CodedeployDeploymentConfigState<'DeploymentConfigName>, value: string) : CodedeployDeploymentConfigState<'DeploymentConfigName> =
            state.assignments.Add(fun config -> config.ComputePlatform <- value)
            state : CodedeployDeploymentConfigState<'DeploymentConfigName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#id-1">CodedeployDeploymentConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodedeployDeploymentConfigState<'DeploymentConfigName>, value: string) : CodedeployDeploymentConfigState<'DeploymentConfigName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodedeployDeploymentConfigState<'DeploymentConfigName>

        /// <summary>
        /// minimum_healthy_hosts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#minimum_healthy_hosts-1">CodedeployDeploymentConfig#minimum_healthy_hosts</a>
        /// </summary>
        [<CustomOperation "minimum_healthy_hosts">]
        member _.MinimumHealthyHosts(state: CodedeployDeploymentConfigState<'DeploymentConfigName>, value: aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigMinimumHealthyHosts) : CodedeployDeploymentConfigState<'DeploymentConfigName> =
            state.assignments.Add(fun config -> config.MinimumHealthyHosts <- value)
            state : CodedeployDeploymentConfigState<'DeploymentConfigName>

        /// <summary>
        /// traffic_routing_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#traffic_routing_config-1">CodedeployDeploymentConfig#traffic_routing_config</a>
        /// </summary>
        [<CustomOperation "traffic_routing_config">]
        member _.TrafficRoutingConfig(state: CodedeployDeploymentConfigState<'DeploymentConfigName>, value: aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfig) : CodedeployDeploymentConfigState<'DeploymentConfigName> =
            state.assignments.Add(fun config -> config.TrafficRoutingConfig <- value)
            state : CodedeployDeploymentConfigState<'DeploymentConfigName>

        /// <summary>
        /// zonal_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#zonal_config-1">CodedeployDeploymentConfig#zonal_config</a>
        /// </summary>
        [<CustomOperation "zonal_config">]
        member _.ZonalConfig(state: CodedeployDeploymentConfigState<'DeploymentConfigName>, value: aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfig) : CodedeployDeploymentConfigState<'DeploymentConfigName> =
            state.assignments.Add(fun config -> config.ZonalConfig <- value)
            state : CodedeployDeploymentConfigState<'DeploymentConfigName>

        member _.Run(state: CodedeployDeploymentConfigState<Present>) : aws.CodedeployDeploymentConfig.CodedeployDeploymentConfig =
            let config = aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigConfig()
            for setter in state.assignments do
                setter config
            aws.CodedeployDeploymentConfig.CodedeployDeploymentConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codedeployDeploymentConfig: missing required arguments. Must call: deployment_config_name.", 9999, IsError = true)>]
        member _.Run(_: CodedeployDeploymentConfigState<_>) : aws.CodedeployDeploymentConfig.CodedeployDeploymentConfig =
            Unchecked.defaultof<aws.CodedeployDeploymentConfig.CodedeployDeploymentConfig>
