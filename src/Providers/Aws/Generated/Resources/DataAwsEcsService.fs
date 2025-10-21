namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcsServiceState<'ClusterArn, 'ServiceName> = { assignments: ResizeArray<aws.DataAwsEcsService.DataAwsEcsServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_service">aws_ecs_service</a>.
    /// </summary>
    type DataAwsEcsServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcsServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcsServiceState<Missing, Missing>)

        member _.Zero(()) : DataAwsEcsServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcsServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_service#cluster_arn-1">DataAwsEcsService#cluster_arn</a>.
        /// </summary>
        [<CustomOperation "cluster_arn">]
        member _.ClusterArn(state: DataAwsEcsServiceState<Missing, 'ServiceName>, value: string) : DataAwsEcsServiceState<Present, 'ServiceName> =
            state.assignments.Add(fun config -> config.ClusterArn <- value)
            ({ assignments = state.assignments } : DataAwsEcsServiceState<Present, 'ServiceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_service#service_name-1">DataAwsEcsService#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: DataAwsEcsServiceState<'ClusterArn, Missing>, value: string) : DataAwsEcsServiceState<'ClusterArn, Present> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : DataAwsEcsServiceState<'ClusterArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_service#id-1">DataAwsEcsService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEcsServiceState<'ClusterArn, 'ServiceName>, value: string) : DataAwsEcsServiceState<'ClusterArn, 'ServiceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEcsServiceState<'ClusterArn, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_service#tags-1">DataAwsEcsService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEcsServiceState<'ClusterArn, 'ServiceName>, value: seq<string * string>) : DataAwsEcsServiceState<'ClusterArn, 'ServiceName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEcsServiceState<'ClusterArn, 'ServiceName>

        member _.Run(state: DataAwsEcsServiceState<Present, Present>) : aws.DataAwsEcsService.DataAwsEcsService =
            let config = aws.DataAwsEcsService.DataAwsEcsServiceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcsService.DataAwsEcsService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEcsService: missing required arguments. Must call: cluster_arn, service_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEcsServiceState<_, _>) : aws.DataAwsEcsService.DataAwsEcsService =
            Unchecked.defaultof<aws.DataAwsEcsService.DataAwsEcsService>
