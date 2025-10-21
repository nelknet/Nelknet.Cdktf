namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, 'VpcConnectorName> = { assignments: ResizeArray<aws.ApprunnerVpcConnector.ApprunnerVpcConnectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_connector">aws_apprunner_vpc_connector</a>.
    /// </summary>
    type ApprunnerVpcConnectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApprunnerVpcConnectorState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApprunnerVpcConnectorState<Missing, Missing, Missing>)

        member _.Zero(()) : ApprunnerVpcConnectorState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApprunnerVpcConnectorState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_connector#security_groups-1">ApprunnerVpcConnector#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: ApprunnerVpcConnectorState<Missing, 'Subnets, 'VpcConnectorName>, value: seq<string>) : ApprunnerVpcConnectorState<Present, 'Subnets, 'VpcConnectorName> =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ApprunnerVpcConnectorState<Present, 'Subnets, 'VpcConnectorName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_connector#subnets-1">ApprunnerVpcConnector#subnets</a>.
        /// </summary>
        [<CustomOperation "subnets">]
        member _.Subnets(state: ApprunnerVpcConnectorState<'SecurityGroups, Missing, 'VpcConnectorName>, value: seq<string>) : ApprunnerVpcConnectorState<'SecurityGroups, Present, 'VpcConnectorName> =
            state.assignments.Add(fun config -> config.Subnets <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ApprunnerVpcConnectorState<'SecurityGroups, Present, 'VpcConnectorName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_connector#vpc_connector_name-1">ApprunnerVpcConnector#vpc_connector_name</a>.
        /// </summary>
        [<CustomOperation "vpc_connector_name">]
        member _.VpcConnectorName(state: ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, Missing>, value: string) : ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, Present> =
            state.assignments.Add(fun config -> config.VpcConnectorName <- value)
            ({ assignments = state.assignments } : ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_connector#id-1">ApprunnerVpcConnector#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, 'VpcConnectorName>, value: string) : ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, 'VpcConnectorName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, 'VpcConnectorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_connector#tags-1">ApprunnerVpcConnector#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, 'VpcConnectorName>, value: seq<string * string>) : ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, 'VpcConnectorName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, 'VpcConnectorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_vpc_connector#tags_all-1">ApprunnerVpcConnector#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, 'VpcConnectorName>, value: seq<string * string>) : ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, 'VpcConnectorName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApprunnerVpcConnectorState<'SecurityGroups, 'Subnets, 'VpcConnectorName>

        member _.Run(state: ApprunnerVpcConnectorState<Present, Present, Present>) : aws.ApprunnerVpcConnector.ApprunnerVpcConnector =
            let config = aws.ApprunnerVpcConnector.ApprunnerVpcConnectorConfig()
            for setter in state.assignments do
                setter config
            aws.ApprunnerVpcConnector.ApprunnerVpcConnector(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apprunnerVpcConnector: missing required arguments. Must call: security_groups, subnets, vpc_connector_name.", 9999, IsError = true)>]
        member _.Run(_: ApprunnerVpcConnectorState<_, _, _>) : aws.ApprunnerVpcConnector.ApprunnerVpcConnector =
            Unchecked.defaultof<aws.ApprunnerVpcConnector.ApprunnerVpcConnector>
