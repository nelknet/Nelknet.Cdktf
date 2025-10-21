namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2NetworkInsightsPathState<'Protocol, 'Source> = { assignments: ResizeArray<aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path">aws_ec2_network_insights_path</a>.
    /// </summary>
    type Ec2NetworkInsightsPathBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2NetworkInsightsPathState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2NetworkInsightsPathState<Missing, Missing>)

        member _.Zero(()) : Ec2NetworkInsightsPathState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2NetworkInsightsPathState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#protocol-1">Ec2NetworkInsightsPath#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: Ec2NetworkInsightsPathState<Missing, 'Source>, value: string) : Ec2NetworkInsightsPathState<Present, 'Source> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : Ec2NetworkInsightsPathState<Present, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#source-1">Ec2NetworkInsightsPath#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: Ec2NetworkInsightsPathState<'Protocol, Missing>, value: string) : Ec2NetworkInsightsPathState<'Protocol, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : Ec2NetworkInsightsPathState<'Protocol, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#destination-1">Ec2NetworkInsightsPath#destination</a>.
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: Ec2NetworkInsightsPathState<'Protocol, 'Source>, value: string) : Ec2NetworkInsightsPathState<'Protocol, 'Source> =
            state.assignments.Add(fun config -> config.Destination <- value)
            state : Ec2NetworkInsightsPathState<'Protocol, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#destination_ip-1">Ec2NetworkInsightsPath#destination_ip</a>.
        /// </summary>
        [<CustomOperation "destination_ip">]
        member _.DestinationIp(state: Ec2NetworkInsightsPathState<'Protocol, 'Source>, value: string) : Ec2NetworkInsightsPathState<'Protocol, 'Source> =
            state.assignments.Add(fun config -> config.DestinationIp <- value)
            state : Ec2NetworkInsightsPathState<'Protocol, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#destination_port-1">Ec2NetworkInsightsPath#destination_port</a>.
        /// </summary>
        [<CustomOperation "destination_port">]
        member _.DestinationPort(state: Ec2NetworkInsightsPathState<'Protocol, 'Source>, value: double) : Ec2NetworkInsightsPathState<'Protocol, 'Source> =
            state.assignments.Add(fun config -> config.DestinationPort <- value)
            state : Ec2NetworkInsightsPathState<'Protocol, 'Source>

        /// <summary>
        /// filter_at_destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#filter_at_destination-1">Ec2NetworkInsightsPath#filter_at_destination</a>
        /// </summary>
        [<CustomOperation "filter_at_destination">]
        member _.FilterAtDestination(state: Ec2NetworkInsightsPathState<'Protocol, 'Source>, value: aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestination) : Ec2NetworkInsightsPathState<'Protocol, 'Source> =
            state.assignments.Add(fun config -> config.FilterAtDestination <- value)
            state : Ec2NetworkInsightsPathState<'Protocol, 'Source>

        /// <summary>
        /// filter_at_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#filter_at_source-1">Ec2NetworkInsightsPath#filter_at_source</a>
        /// </summary>
        [<CustomOperation "filter_at_source">]
        member _.FilterAtSource(state: Ec2NetworkInsightsPathState<'Protocol, 'Source>, value: aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSource) : Ec2NetworkInsightsPathState<'Protocol, 'Source> =
            state.assignments.Add(fun config -> config.FilterAtSource <- value)
            state : Ec2NetworkInsightsPathState<'Protocol, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#id-1">Ec2NetworkInsightsPath#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2NetworkInsightsPathState<'Protocol, 'Source>, value: string) : Ec2NetworkInsightsPathState<'Protocol, 'Source> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2NetworkInsightsPathState<'Protocol, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#source_ip-1">Ec2NetworkInsightsPath#source_ip</a>.
        /// </summary>
        [<CustomOperation "source_ip">]
        member _.SourceIp(state: Ec2NetworkInsightsPathState<'Protocol, 'Source>, value: string) : Ec2NetworkInsightsPathState<'Protocol, 'Source> =
            state.assignments.Add(fun config -> config.SourceIp <- value)
            state : Ec2NetworkInsightsPathState<'Protocol, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#tags-1">Ec2NetworkInsightsPath#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2NetworkInsightsPathState<'Protocol, 'Source>, value: seq<string * string>) : Ec2NetworkInsightsPathState<'Protocol, 'Source> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2NetworkInsightsPathState<'Protocol, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#tags_all-1">Ec2NetworkInsightsPath#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2NetworkInsightsPathState<'Protocol, 'Source>, value: seq<string * string>) : Ec2NetworkInsightsPathState<'Protocol, 'Source> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2NetworkInsightsPathState<'Protocol, 'Source>

        member _.Run(state: Ec2NetworkInsightsPathState<Present, Present>) : aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPath =
            let config = aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPath(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2NetworkInsightsPath: missing required arguments. Must call: protocol, source.", 9999, IsError = true)>]
        member _.Run(_: Ec2NetworkInsightsPathState<_, _>) : aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPath =
            Unchecked.defaultof<aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPath>
