namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectContactFlowState<'InstanceId, 'Name> = { assignments: ResizeArray<aws.ConnectContactFlow.ConnectContactFlowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow">aws_connect_contact_flow</a>.
    /// </summary>
    type ConnectContactFlowBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectContactFlowState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectContactFlowState<Missing, Missing>)

        member _.Zero(()) : ConnectContactFlowState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectContactFlowState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow#instance_id-1">ConnectContactFlow#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectContactFlowState<Missing, 'Name>, value: string) : ConnectContactFlowState<Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectContactFlowState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow#name-1">ConnectContactFlow#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConnectContactFlowState<'InstanceId, Missing>, value: string) : ConnectContactFlowState<'InstanceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConnectContactFlowState<'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow#content-1">ConnectContactFlow#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: ConnectContactFlowState<'InstanceId, 'Name>, value: string) : ConnectContactFlowState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Content <- value)
            state : ConnectContactFlowState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow#content_hash-1">ConnectContactFlow#content_hash</a>.
        /// </summary>
        [<CustomOperation "content_hash">]
        member _.ContentHash(state: ConnectContactFlowState<'InstanceId, 'Name>, value: string) : ConnectContactFlowState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.ContentHash <- value)
            state : ConnectContactFlowState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow#description-1">ConnectContactFlow#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConnectContactFlowState<'InstanceId, 'Name>, value: string) : ConnectContactFlowState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ConnectContactFlowState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow#filename-1">ConnectContactFlow#filename</a>.
        /// </summary>
        [<CustomOperation "filename">]
        member _.Filename(state: ConnectContactFlowState<'InstanceId, 'Name>, value: string) : ConnectContactFlowState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Filename <- value)
            state : ConnectContactFlowState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow#id-1">ConnectContactFlow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectContactFlowState<'InstanceId, 'Name>, value: string) : ConnectContactFlowState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectContactFlowState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow#tags-1">ConnectContactFlow#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectContactFlowState<'InstanceId, 'Name>, value: seq<string * string>) : ConnectContactFlowState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectContactFlowState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow#tags_all-1">ConnectContactFlow#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectContactFlowState<'InstanceId, 'Name>, value: seq<string * string>) : ConnectContactFlowState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectContactFlowState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow#type-1">ConnectContactFlow#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ConnectContactFlowState<'InstanceId, 'Name>, value: string) : ConnectContactFlowState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : ConnectContactFlowState<'InstanceId, 'Name>

        member _.Run(state: ConnectContactFlowState<Present, Present>) : aws.ConnectContactFlow.ConnectContactFlow =
            let config = aws.ConnectContactFlow.ConnectContactFlowConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectContactFlow.ConnectContactFlow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectContactFlow: missing required arguments. Must call: instance_id, name.", 9999, IsError = true)>]
        member _.Run(_: ConnectContactFlowState<_, _>) : aws.ConnectContactFlow.ConnectContactFlow =
            Unchecked.defaultof<aws.ConnectContactFlow.ConnectContactFlow>
