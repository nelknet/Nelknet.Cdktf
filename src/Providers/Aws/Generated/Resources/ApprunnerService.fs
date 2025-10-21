namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApprunnerServiceState<'ServiceName, 'SourceConfiguration> = { assignments: ResizeArray<aws.ApprunnerService.ApprunnerServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service">aws_apprunner_service</a>.
    /// </summary>
    type ApprunnerServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApprunnerServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApprunnerServiceState<Missing, Missing>)

        member _.Zero(()) : ApprunnerServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApprunnerServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#service_name-1">ApprunnerService#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: ApprunnerServiceState<Missing, 'SourceConfiguration>, value: string) : ApprunnerServiceState<Present, 'SourceConfiguration> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : ApprunnerServiceState<Present, 'SourceConfiguration>)

        /// <summary>
        /// source_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#source_configuration-1">ApprunnerService#source_configuration</a>
        /// </summary>
        [<CustomOperation "source_configuration">]
        member _.SourceConfiguration(state: ApprunnerServiceState<'ServiceName, Missing>, value: aws.ApprunnerService.ApprunnerServiceSourceConfiguration) : ApprunnerServiceState<'ServiceName, Present> =
            state.assignments.Add(fun config -> config.SourceConfiguration <- value)
            ({ assignments = state.assignments } : ApprunnerServiceState<'ServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#auto_scaling_configuration_arn-1">ApprunnerService#auto_scaling_configuration_arn</a>.
        /// </summary>
        [<CustomOperation "auto_scaling_configuration_arn">]
        member _.AutoScalingConfigurationArn(state: ApprunnerServiceState<'ServiceName, 'SourceConfiguration>, value: string) : ApprunnerServiceState<'ServiceName, 'SourceConfiguration> =
            state.assignments.Add(fun config -> config.AutoScalingConfigurationArn <- value)
            state : ApprunnerServiceState<'ServiceName, 'SourceConfiguration>

        /// <summary>
        /// encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#encryption_configuration-1">ApprunnerService#encryption_configuration</a>
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: ApprunnerServiceState<'ServiceName, 'SourceConfiguration>, value: aws.ApprunnerService.ApprunnerServiceEncryptionConfiguration) : ApprunnerServiceState<'ServiceName, 'SourceConfiguration> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : ApprunnerServiceState<'ServiceName, 'SourceConfiguration>

        /// <summary>
        /// health_check_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#health_check_configuration-1">ApprunnerService#health_check_configuration</a>
        /// </summary>
        [<CustomOperation "health_check_configuration">]
        member _.HealthCheckConfiguration(state: ApprunnerServiceState<'ServiceName, 'SourceConfiguration>, value: aws.ApprunnerService.ApprunnerServiceHealthCheckConfiguration) : ApprunnerServiceState<'ServiceName, 'SourceConfiguration> =
            state.assignments.Add(fun config -> config.HealthCheckConfiguration <- value)
            state : ApprunnerServiceState<'ServiceName, 'SourceConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#id-1">ApprunnerService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApprunnerServiceState<'ServiceName, 'SourceConfiguration>, value: string) : ApprunnerServiceState<'ServiceName, 'SourceConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApprunnerServiceState<'ServiceName, 'SourceConfiguration>

        /// <summary>
        /// instance_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#instance_configuration-1">ApprunnerService#instance_configuration</a>
        /// </summary>
        [<CustomOperation "instance_configuration">]
        member _.InstanceConfiguration(state: ApprunnerServiceState<'ServiceName, 'SourceConfiguration>, value: aws.ApprunnerService.ApprunnerServiceInstanceConfiguration) : ApprunnerServiceState<'ServiceName, 'SourceConfiguration> =
            state.assignments.Add(fun config -> config.InstanceConfiguration <- value)
            state : ApprunnerServiceState<'ServiceName, 'SourceConfiguration>

        /// <summary>
        /// network_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#network_configuration-1">ApprunnerService#network_configuration</a>
        /// </summary>
        [<CustomOperation "network_configuration">]
        member _.NetworkConfiguration(state: ApprunnerServiceState<'ServiceName, 'SourceConfiguration>, value: aws.ApprunnerService.ApprunnerServiceNetworkConfiguration) : ApprunnerServiceState<'ServiceName, 'SourceConfiguration> =
            state.assignments.Add(fun config -> config.NetworkConfiguration <- value)
            state : ApprunnerServiceState<'ServiceName, 'SourceConfiguration>

        /// <summary>
        /// observability_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#observability_configuration-1">ApprunnerService#observability_configuration</a>
        /// </summary>
        [<CustomOperation "observability_configuration">]
        member _.ObservabilityConfiguration(state: ApprunnerServiceState<'ServiceName, 'SourceConfiguration>, value: aws.ApprunnerService.ApprunnerServiceObservabilityConfiguration) : ApprunnerServiceState<'ServiceName, 'SourceConfiguration> =
            state.assignments.Add(fun config -> config.ObservabilityConfiguration <- value)
            state : ApprunnerServiceState<'ServiceName, 'SourceConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#tags-1">ApprunnerService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApprunnerServiceState<'ServiceName, 'SourceConfiguration>, value: seq<string * string>) : ApprunnerServiceState<'ServiceName, 'SourceConfiguration> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApprunnerServiceState<'ServiceName, 'SourceConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#tags_all-1">ApprunnerService#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApprunnerServiceState<'ServiceName, 'SourceConfiguration>, value: seq<string * string>) : ApprunnerServiceState<'ServiceName, 'SourceConfiguration> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApprunnerServiceState<'ServiceName, 'SourceConfiguration>

        member _.Run(state: ApprunnerServiceState<Present, Present>) : aws.ApprunnerService.ApprunnerService =
            let config = aws.ApprunnerService.ApprunnerServiceConfig()
            for setter in state.assignments do
                setter config
            aws.ApprunnerService.ApprunnerService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apprunnerService: missing required arguments. Must call: service_name, source_configuration.", 9999, IsError = true)>]
        member _.Run(_: ApprunnerServiceState<_, _>) : aws.ApprunnerService.ApprunnerService =
            Unchecked.defaultof<aws.ApprunnerService.ApprunnerService>
