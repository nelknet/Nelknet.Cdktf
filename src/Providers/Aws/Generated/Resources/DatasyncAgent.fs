namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncAgentState = { assignments: ResizeArray<aws.DatasyncAgent.DatasyncAgentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent">aws_datasync_agent</a>.
    /// </summary>
    type DatasyncAgentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncAgentState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DatasyncAgentState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent#activation_key-1">DatasyncAgent#activation_key</a>.
        /// </summary>
        [<CustomOperation "activation_key">]
        member _.ActivationKey(state: DatasyncAgentState, value: string) : DatasyncAgentState =
            state.assignments.Add(fun config -> config.ActivationKey <- value)
            state : DatasyncAgentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent#id-1">DatasyncAgent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncAgentState, value: string) : DatasyncAgentState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncAgentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent#ip_address-1">DatasyncAgent#ip_address</a>.
        /// </summary>
        [<CustomOperation "ip_address">]
        member _.IpAddress(state: DatasyncAgentState, value: string) : DatasyncAgentState =
            state.assignments.Add(fun config -> config.IpAddress <- value)
            state : DatasyncAgentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent#name-1">DatasyncAgent#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatasyncAgentState, value: string) : DatasyncAgentState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DatasyncAgentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent#private_link_endpoint-1">DatasyncAgent#private_link_endpoint</a>.
        /// </summary>
        [<CustomOperation "private_link_endpoint">]
        member _.PrivateLinkEndpoint(state: DatasyncAgentState, value: string) : DatasyncAgentState =
            state.assignments.Add(fun config -> config.PrivateLinkEndpoint <- value)
            state : DatasyncAgentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent#security_group_arns-1">DatasyncAgent#security_group_arns</a>.
        /// </summary>
        [<CustomOperation "security_group_arns">]
        member _.SecurityGroupArns(state: DatasyncAgentState, value: seq<string>) : DatasyncAgentState =
            state.assignments.Add(fun config -> config.SecurityGroupArns <- (value |> Seq.toArray))
            state : DatasyncAgentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent#subnet_arns-1">DatasyncAgent#subnet_arns</a>.
        /// </summary>
        [<CustomOperation "subnet_arns">]
        member _.SubnetArns(state: DatasyncAgentState, value: seq<string>) : DatasyncAgentState =
            state.assignments.Add(fun config -> config.SubnetArns <- (value |> Seq.toArray))
            state : DatasyncAgentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent#tags-1">DatasyncAgent#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncAgentState, value: seq<string * string>) : DatasyncAgentState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncAgentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent#tags_all-1">DatasyncAgent#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncAgentState, value: seq<string * string>) : DatasyncAgentState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncAgentState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent#timeouts-1">DatasyncAgent#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatasyncAgentState, value: aws.DatasyncAgent.DatasyncAgentTimeouts) : DatasyncAgentState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatasyncAgentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_agent#vpc_endpoint_id-1">DatasyncAgent#vpc_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_id">]
        member _.VpcEndpointId(state: DatasyncAgentState, value: string) : DatasyncAgentState =
            state.assignments.Add(fun config -> config.VpcEndpointId <- value)
            state : DatasyncAgentState

        member _.Run(state: DatasyncAgentState) : aws.DatasyncAgent.DatasyncAgent =
            let config = aws.DatasyncAgent.DatasyncAgentConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncAgent.DatasyncAgent(StackContext.get (), logicalId, config)
